using E_Docs.Domain.Entities;
using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Text;

namespace E_Docs.Domain.Services;
public static class CertificadoService
{
    /// <summary>
    /// Método responsável por renomear os arquivos e por chamar os métodos de "DefinirSenha" e "RemoverArquivoOriginal".
    /// </summary>
    /// <param name="diretorio">Endereço da pasta onde se encontram os arquivos.</param>
    /// <param name="senhaAdmin">Senha do usuário Admin para manipulação dos arquivos</param>
    /// <param name="matriculas">Lista de matrículas para identificação dos certificados.</param>
    /// <returns>Retorna a lista de certificados renomeados e criptografados com senha e a os erros obtidos no processo</returns>
    /// <exception cref="EncoderFallbackException">Lançada quando ocorre um erro durante a codificação de caracteres.</exception>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="PathTooLongException">Lançada quando o caminho do arquivo excede o limite de caracteres permitido.</exception>
    /// <exception cref="DirectoryNotFoundException">Lançada quando o diretório especificado não é encontrado.</exception>
    /// <exception cref="UnauthorizedAccessException">Lançada quando o acesso ao arquivo ou diretório é negado devido a permissões insuficientes.</exception>
    /// <exception cref="FileNotFoundException">Lançada quando o arquivo especificado não é encontrado.</exception>
    /// <exception cref="NotSupportedException">Lançada quando uma operação não é suportada.</exception>
    /// <exception cref="IOException">Lançada quando ocorre um erro de entrada/saída durante a operação.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    public static List<Certificado> RenomearCertificados(string diretorio, string senhaAdmin, List<Matricula>matriculas)
    {
        List<Certificado> certificados = [];

        try
        {
            int contador = 0;
            string erros = string.Empty;
            var certificadosLeitura = LerArquivos(diretorio, senhaAdmin, matriculas);

            foreach (var certificado in certificadosLeitura)
            {
                // Renomeia arquivo original.
                File.Move($"{diretorio}{certificado.NomeArquivo}", $"{diretorio}{certificado.NomeAluno}.pdf");

                string senha;

                // Se o nome do aluno identificado no arquivo existir na lista de matrículas:
                if(matriculas.FirstOrDefault(x => x.Nome == certificado.NomeAluno) != null)
                {
                    // Atribui o valor do identificador (CPF do aluno) à variável senha
                    senha = matriculas.FirstOrDefault(x => x.Nome.Equals(certificado.NomeAluno)).Cpf;
                    if (!Directory.Exists($"{diretorio}\\Criptografados")) Directory.CreateDirectory($"{diretorio}\\Criptografados");
                    // Cria uma cópia do arquivo PDF atribuindu-le um novo nome (mesmo nome, apenas acrescentando a palavra [PROTEGIDO]) e define as senhas do ususário e do usuário mestre para proteção do arquivo
                    DefinirSenha($"{diretorio}{certificado.NomeAluno}.pdf", $"{diretorio}\\Criptografados\\[PROTEGIDO] {certificado.NomeAluno}.pdf", senha, senhaAdmin);
                    // Atualiza o nome do documento no objeto
                    certificado.NomeArquivo = $"[PROTEGIDO] {certificado.NomeAluno}.pdf";
                    // vincula a matrícula ao certificado
                    certificado.Matricula = matriculas.FirstOrDefault(x => x.Nome == certificado.NomeAluno);
                    // Adiciona o arquivo à lista
                    certificados.Add(certificado);
                }
                else
                {
                    erros += $"{Environment.NewLine}   Não foi possível preparar o arquivo! O nome do(a) aluno(a) '{certificado.NomeAluno}' não foi encontrado na lista de matrículas.{Environment.NewLine}";
                    contador++;
                }
            }
            if (contador >= certificadosLeitura.Count) throw new Exception();
            return certificados;
        }
        catch (EncoderFallbackException) { throw; }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (PathTooLongException) { throw; }
        catch (DirectoryNotFoundException) { throw; }
        catch (UnauthorizedAccessException) { throw; }
        catch (FileNotFoundException) { throw; }
        catch (NotSupportedException) { throw; }
        catch (IOException) { throw; }
        catch (Exception) { throw; }
    }
     
    /// <summary>
    /// Método respondável por relaizar a letura dos arquivos PDF.
    /// </summary>
    /// <param name="diretorio">Endereço da pasta onde se encontram os arquivos</param>
    /// <returns>Retorna a lista de certificados criados a partir da leitura dos arquivos</returns>
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
    public static List<Certificado> LerArquivos(string diretorio, string senhaAdmin, List<Matricula>matriculas)
    {
        string excecoes = string.Empty;
        List<Certificado> certificados = [];

        try
        {
            // Verifica se o diretório existe
            if (!Directory.Exists(diretorio)) throw new DirectoryNotFoundException();

            // Obtém todos os arquivos PDF no diretório
            string[] arquivos = Directory.GetFiles(diretorio, "*.pdf");

            // Se existir arquivos PDF no diretório informado, a leitura é realizada
            if (arquivos.Length > 0)
            {
                int contador = 1;
                foreach (string arquivo in arquivos)
                {
                    if (contador > matriculas.Count) break;
                 
                    //if(matriculas.Any(x => x.Nome.Equals(Path.GetFileNameWithoutExtension(arquivo))))
                    //{

                    // Divide o texto do arquivo PDF em linhas e as armazena em um array de linhas
                    string[] linhasTexto = ExtrairTextoDoPDF(arquivo, senhaAdmin).Split("\n");

                    // Atribui os valores ao campos do objeto
                    Certificado certificado = new
                        (
                            nomeArquivo: $"{Path.GetFileName(arquivo)}", // Essa configuração armazena apenas o nome do arquivo. Não considera o diretorio completo.
                            unidade: linhasTexto[1],
                            nomeAluno: ObterTexto(linhasTexto[2], "conferem à ", " por ter concluído"),
                            curso: linhasTexto[3],
                            cargaHoraria: ObterTexto(linhasTexto[4], "com duração de", "\n"),
                            periodo: ObterTexto(linhasTexto[5], "no período de ", "\n"),
                            matricula: matriculas.FirstOrDefault(x => x.Nome.Equals(ObterTexto(linhasTexto[2], "conferem à ", " por ter concluído")))
                        );
                        // Adiciona cada arquivo carregado a lista geral
                        certificados.Add(certificado);
                        contador++;
                    //}
                }
                return certificados;
            }
            else
            {
                throw new Exception($"{Environment.NewLine}   Não há arquivos no formado PDF no diretório informado. Diretório: '{diretorio}.{Environment.NewLine}'");
            }
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

    /// <summary>
    /// Método responsável por extrair o texto da primeira página do arquivo PDF.
    /// </summary>
    /// <param name="diretorioArquivo">Endereço completo do arquivo.</param>
    /// <param name="senhaAdmin">Senha utilizada para leitura de arquvos PDF caso esteja protegido com ela.</param>
    /// <returns>Retorna o texto extraído do documento</returns>
    /// <exception cref="BadPasswordException">Lançada quando a senha fornecida está incorreta ou não atende aos critérios.</exception>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="EncoderFallbackException">Lançada quando ocorre um erro durante a codificação de caracteres.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static string ExtrairTextoDoPDF(string diretorioArquivo, string senhaAdmin)
    {
        try
        {
            // Armazena a senha do Admin do documento nas propriedades do arquivo
            // var readerProps = new ReaderProperties().SetPassword(Encoding.UTF8.GetBytes(senhaAdmin));
            using (var pdfReader = new PdfReader(diretorioArquivo/*, readerProps*/))
            {
                // Inicia uma instância do documento passando o diretório e a senha admin
                using (PdfDocument PdfDoc = new PdfDocument(pdfReader))
                {
                    //Retorna o texto estraído do documento
                    return PdfTextExtractor.GetTextFromPage(PdfDoc.GetFirstPage(), new SimpleTextExtractionStrategy());
                }
            }
        }
        catch (BadPasswordException) { throw; }
        catch (ArgumentNullException) { throw; }
        catch (EncoderFallbackException) { throw; }
        catch (Exception) {  throw; }
    }

    /// <summary>
    /// Método responsável por localizar o nome dos alunos no arquivo PDF e remover os trechos que não fazem parte do nome.
    /// </summary>
    /// <param name="textoLinha">Texto da linha que contém o nome do aluno</param>
    /// <param name="textoAnterior">Trecho de texto que antecede o nome do aluno.</param>
    /// <param name="textoPosterior">Trecho de texto posterior ao nome do aluno.</param>
    /// <returns>Retorna do texto processado</returns>
    /// <exception cref="ArgumentOutOfRangeException">Lançada quando um argumento está fora do intervalo permitido.</exception>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static string ObterTexto(string textoLinha, string textoAnterior, string textoPosterior)
    {
        try
        {
            int indice = textoLinha.IndexOf(textoAnterior);

            if (indice != -1)
            {
                int inicio = indice + textoAnterior.Length;
                int fim = textoLinha.IndexOf(textoPosterior, inicio);

                if (fim != -1)
                {
                    return textoLinha.Substring(inicio, fim - inicio).Trim();
                }
                else
                {
                    return textoLinha.Substring(inicio).Trim();
                }
            }
            throw new Exception($"ERRO: Índice inválido para a operação. O texto {textoLinha} não pode ser cortado.");
        }
        catch (ArgumentOutOfRangeException) { throw; }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (Exception) { throw; }
    }

    /// <summary>
    /// Método responsável por definir uma senha para os arquivos de certificados
    /// </summary>
    /// <param name="arquivoEntrada">Diretório do arquivo original</param>
    /// <param name="arquivoSaida">Diretório do arquivo final</param>
    /// <param name="senha">Senha do usuário aluno: CPF</param>
    /// <param name="senhaAdmin">Senha que permite abertura do arquivo sem restrições</param>
    /// <exception cref="EncoderFallbackException">Lançada quando ocorre um erro durante a codificação de caracteres.</exception>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static void DefinirSenha(string arquivoEntrada, string arquivoSaida, string senha, string senhaAdmin)
    {
        try
        {
            // Criar um PdfReader para o arquivo existente
            PdfReader pdfReader = new PdfReader(arquivoEntrada);

            // Criar um PdfWriter para o novo arquivo com as permissões: apenas leitura e impressão
            PdfWriter pdfWriter = new PdfWriter(arquivoSaida, new WriterProperties()
                .SetStandardEncryption(Encoding.UTF8.GetBytes(senha), Encoding.UTF8.GetBytes(senhaAdmin), EncryptionConstants.ALLOW_PRINTING, EncryptionConstants.ENCRYPTION_AES_128));

            // Criar o documento PDF e o fecha
            PdfDocument pdfDoc = new PdfDocument(pdfReader, pdfWriter);
            pdfDoc.Close();

            // Remove o arquivo original
            // RemoverArquivoOriginal(arquivoEntrada);
        }

        catch (EncoderFallbackException) { throw ; }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (Exception) { throw; }
    }

    /// <summary>
    /// Método responsável por exclur o arquivo antigo substituído pelo arquivo criptografado
    /// </summary>
    /// <param name="arquivoEntrada"></param>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="PathTooLongException">Lançada quando o caminho do arquivo excede o limite de caracteres permitido.</exception>
    /// <exception cref="DirectoryNotFoundException">Lançada quando o diretório especificado não é encontrado.</exception>
    /// <exception cref="UnauthorizedAccessException">Lançada quando o acesso ao arquivo ou diretório é negado devido a permissões insuficientes.</exception>
    /// <exception cref="NotSupportedException">Lançada quando uma operação não é suportada.</exception>
    /// <exception cref="IOException">Lançada quando ocorre um erro de entrada/saída durante a operação.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static void RemoverArquivoOriginal(string arquivoEntrada)
    {
        try
        {
            // Verifica se o arquivo existe
            if (File.Exists(arquivoEntrada))
            {
                // Apaga o arquivo
                File.Delete(arquivoEntrada);
            }
        }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (PathTooLongException) { throw; }
        catch (DirectoryNotFoundException) { throw; }
        catch (UnauthorizedAccessException) { throw; }
        catch (NotSupportedException) { throw; }
        catch (IOException) { throw; }
        catch (Exception) { throw; }
    }
}
