using E_Docs.Domain.Entities;
using ExcelDataReader;
using System.Data;

namespace E_Docs.Domain.Services;
public class MatriculaService
{
    /// <summary>
    /// Método responsável por carregar as informações da lista de matrículas.
    /// </summary>
    /// <param name="diretorioArquivo">Endereço completo dos arquivos</param>
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
    public static List<Matricula> CarregarMatriculas(string diretorioArquivo)
    {
        List<Matricula> listaMatriculas = [];

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
                        listaMatriculas.Add(matricula);
                    }
                }
            }
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

        return listaMatriculas;
    }
}
