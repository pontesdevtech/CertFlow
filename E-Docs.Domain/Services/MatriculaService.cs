using E_Docs.Domain.Entities;
using ExcelDataReader;
using iText.Kernel.Exceptions;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace E_Docs.Domain.Services;
public class MatriculaService
{
    /// <summary>
    /// Método responsável por carregar as informações da lista de matrículas.
    /// </summary>
    /// <param name="diretorioArquivo">Endereço completo dos arquivos</param>
    /// <param name="senhaAdmin">Senha de administrador dos arquivos criptografados</param>
    /// <returns>Retorna uma lista de matrículas carregadas</returns>
    /// <exception cref="ArgumentNullException">Lançada quando o argumento <paramref name="diretorioArquivo"/> é nulo.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Lançada quando o valor do argumento está fora do intervalo permitido.</exception>
    /// <exception cref="ArgumentException">Lançada quando o argumento <paramref name="diretorioArquivo"/> é inválido.</exception>
    /// <exception cref="NotSupportedException">Lançada quando o método não suporta o tipo de operação solicitado.</exception>
    /// <exception cref="PathTooLongException">Lançada quando o caminho do arquivo é muito longo.</exception>
    /// <exception cref="FileNotFoundException">Lançada quando o arquivo especificado não é encontrado.</exception>
    /// <exception cref="DirectoryNotFoundException">Lançada quando o diretório especificado não é encontrado.</exception>
    /// <exception cref="UnauthorizedAccessException">Lançada quando o acesso ao arquivo é negado devido a permissões insuficientes.</exception>
    /// <exception cref="IOException">Lançada quando ocorre um erro de I/O durante a leitura do arquivo.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    public static (List<Matricula>matriculas, List<Certificado>? certificados) CarregarMatriculas(string diretorioArquivo, string senhaAdmin)
    {
        List<Matricula> matriculas = [];
        List<Certificado>? certificados = [];

        try
        {
            // Configuração necessária para o ExcelDataReader trabalhar corretamente
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(diretorioArquivo, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Converter para DataSet
                    var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true // Usar a primeira linha como cabeçalho
                        }
                    });

                    DataTable tabela = dataSet.Tables[0]; // Selecionar a primeira planilha

                    // Iterar pelas linhas da tabela
                    foreach (DataRow linha in tabela.Rows)
                    {
                        // Atribui os valores obtidos na lista de matriculados aos campos do objeto
                        var matricula = new Matricula
                                            (
                                                nome: linha["ALUNO"].ToString(),
                                                ra: linha["RA"].ToString(),
                                                cpf: linha["RA"].ToString(),
                                                curso: linha["CURSO"].ToString(),
                                                turma: linha["CODTURMA"].ToString(),
                                                email: linha["EMAIL"].ToString()
                                            );
                        // Adiciona cada objeto na lista.
                        matriculas.Add(matricula);
                    }
                    certificados = ConsultarCertificadosCriptografados(diretorioArquivo, senhaAdmin, matriculas);
                }
            }

            return (matriculas, certificados);
        }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentOutOfRangeException) { throw; }
        catch (ArgumentException) { throw; }
        catch (NotSupportedException) { throw; }
        catch (PathTooLongException) { throw; }
        catch (FileNotFoundException) { throw; }
        catch (DirectoryNotFoundException) { throw; }
        catch (UnauthorizedAccessException) { throw; }
        catch (IOException) { throw; }
        catch (Exception) { throw; }

        
    }

    /// <summary>
    /// Método responsável por carregar as informações da lista de certificados criptografados.
    /// </summary>
    /// <param name="diretorio">Endereço completo dos arquivos</param>
    /// <param name="senhaAdmin">Senha de administrador dos arquivos criptografados</param>
    /// <param name="matriculas">Lista de matrículas que será utilizada para a consulta de certificados criptografasos</param>
    /// <exception cref="EncoderFallbackException">Lançada quando ocorre um erro durante a codificação de caracteres.</exception>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Lançada quando um argumento está fora do intervalo permitido.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="PathTooLongException">Lançada quando o caminho do arquivo excede o limite de caracteres permitido.</exception>
    /// <exception cref="DirectoryNotFoundException">Lançada quando o diretório especificado não é encontrado.</exception>
    /// <exception cref="UnauthorizedAccessException">Lançada quando o acesso ao arquivo ou diretório é negado devido a permissões insuficientes.</exception>
    /// <exception cref="IOException">Lançada quando ocorre um erro de entrada/saída durante a operação.</exception>
    /// <exception cref="BadPasswordException">Lançada quando a senha fornecida está incorreta ou não atende aos critérios.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static List<Certificado>? ConsultarCertificadosCriptografados(string diretorio, string senhaAdmin, List<Matricula> matriculas)
    {
        try
        {
            List<Matricula> matriculasCertificado = [];
            List<Certificado>? certificadosMatriculas = [];

            // Realisa a contagem de certificados que já estão criptografados
            foreach (var matricula in matriculas)
            {
                if (File.Exists($"{Path.GetDirectoryName(diretorio)}\\Criptografados\\[PROTEGIDO] {matricula.Nome}.pdf"))
                {
                    matriculasCertificado.Add(matricula);
                }
            }

            // Se a quantidade de certificados for maior que 0, retorna a lista de certificados vinculando suas respectivas matrículas
            if (matriculasCertificado.Count > 0) 
            { 
                var certificados = CertificadoService.LerArquivos($"{Path.GetDirectoryName(diretorio)}", senhaAdmin, matriculasCertificado);

                foreach (var certificado in certificados)
                {
                    certificado.Matricula = matriculas.FirstOrDefault(x => x.Nome.Equals(certificado.NomeAluno));
                    certificado.NomeArquivo = $"[PROTEGIDO] {certificado.NomeAluno}.pdf";
                    certificadosMatriculas.Add(certificado);
                }
            }
            // Caso contrário, retorna uma lista
            else
            {
                certificadosMatriculas = null;
            }

            return certificadosMatriculas;
        }
        catch (EncoderFallbackException) { throw; }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentOutOfRangeException) { throw; }
        catch (ArgumentException) { throw; }
        catch (PathTooLongException) { throw; }
        catch (DirectoryNotFoundException) { throw; }
        catch (UnauthorizedAccessException) { throw; }
        catch (IOException) { throw; }
        catch (BadPasswordException) { throw; }
        catch (Exception) { throw; }

    }
}


