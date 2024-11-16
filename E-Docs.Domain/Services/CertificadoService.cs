using E_Docs.Domain.Entities;
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
    /// <param name="diretorio">Endereço da pasta onde se encontram os arquivos</param>
    /// <param name="matriculas">Lista de matrículas para identificação dos certificados</param>
    /// <returns></returns>
    public static (List<Matricula>matriculas, List<string> logsSucesso, List<string>logsErro) RenomearDocumentos(string diretorio, List<Matricula>alunos)
    {
        List<Certificado> documentos = LerDocumentos(diretorio);
        List<Matricula> matriculas = [];
        Matricula matricula;
        List<string> sucessos = [];
        List<string> erros = [];

        foreach (var documento in documentos)
        {
            try
            {
                // Renomeia arquivo original atribuindo-lhe um novo nome.
                File.Move($"{diretorio}{documento.NomeArquivo}", $"{diretorio}{documento.NomeAluno}.pdf");

                string senha;

                // Se o nome do aluno identificado no certificado existir na lista de matrículas:
                if(alunos.FirstOrDefault(x => x.Nome == documento.NomeAluno) != null)
                {
                    // Atribui o valor do identificador (RA ou CPF do aluno) à variável senha
                    senha = alunos.FirstOrDefault(x => x.Nome.Equals(documento.NomeAluno)).Ra;
                    // Cria uma cópia do arquivo PDF atribuindu-le um novo nome (mesmo nome, apenas acrescentando a palavra [PROTEGIDO]) e define as senhas do ususário e do usuário mestre para proteção do arquivo */
                    DefinirSenha($"{diretorio}{documento.NomeAluno}.pdf", $"{diretorio}[PROTEGIDO] {documento.NomeAluno}.pdf", senha, "Fiepa@123456789@");

                    // Remove o arquivo original deixando apenas o novo arquivo renomeado e protegido por senha
                    RemoverArquivoOriginal($"{diretorio}{documento.NomeAluno}.pdf");

                    // Atualiza o nome do documento no objeto
                    string nomeAntigoArquivo = documento.NomeArquivo;
                    documento.NomeArquivo = $"[PROTEGIDO] {documento.NomeAluno}.pdf";
                    sucessos.Add($"SUCESSO: O arquivo '{nomeAntigoArquivo}' foi renomeado para '{documento.NomeArquivo}'.");

                    // Localiza a matrícula na lista recebida
                    matricula = alunos.FirstOrDefault(x => x.Nome.Equals(documento.NomeAluno));
                    // Adiciona o certificado à matrícula
                    matricula.Certificado = documento;
                    // Adiciona a matrícula na lista de matrículas 
                    matriculas.Add(matricula);
                }
                // caso contrário:
                else
                {
                    // Registra o log do erro apresentado
                    erros.Add($"ERRO: Não foi possível preparar o certificado!{Environment.NewLine}" +
                              $"O nome do(a) aluno(a) {documento.NomeAluno} não foi encontrado na lista de matrículas.");
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }
            return (matriculas, sucessos, erros);
    }

    /// <summary>
    /// Método respondável por relaizar a letura dos arquivos PDF.
    /// </summary>
    /// <param name="diretorio">Endereço da pasta onde se encontram os arquivos</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    private static List<Certificado> LerDocumentos(string diretorio)
    {
        List<Certificado> certificados = [];

        // Verifica se o diretório existe
        if (!Directory.Exists(diretorio)) throw new Exception("Diretório não encontrado.");

        // Obtém todos os arquivos PDF no diretório
        string[] arquivos = Directory.GetFiles(diretorio, "*.pdf");

        if (arquivos.Length > 0)
        {

            foreach (string arquivo in arquivos)
            {
                // Divide o texto do arquivo PDF em linhas e as armazena em um array de linhas
                string[] linhasTexto = ExtrairTextoDoPDF(arquivo).Split("\n");
                // Atribui os valores ao campos do objeto
                Certificado certificado = new
                    (
                        nomeArquivo: $"{Path.GetFileName(arquivo)}", // Essa configuração armazena apenas o nome do arquivo. Não considera o diretorio completo.
                        unidade: linhasTexto[1],
                        nomeAluno: ObterTexto(linhasTexto[2], "conferem à ", " por ter concluído"),
                        curso: linhasTexto[3],
                        cargaHoraria: ObterTexto(linhasTexto[4], "com duração de", "\n"),
                        periodo: ObterTexto(linhasTexto[5], "no período de ", "\n")
                    );
                // Adiciona cada certificado carregado a lista geral
                certificados.Add(certificado);
            }

            return certificados;
        }
        else
        {
            throw new Exception("Não foram encontrados arquivos PDF no diretório informado.");
        }
    }

    /// <summary>
    /// Método responsável por extrair o texto da primeira página do arquivo PDF. 
    /// </summary>
    /// <param name="diretorioArquivo">Endereço completo do arquivos</param>
    /// <returns></returns>
    private static string ExtrairTextoDoPDF(string diretorioArquivo)
    {
        using (PdfDocument PdfDoc = new PdfDocument(new PdfReader(diretorioArquivo)))
        {
            return PdfTextExtractor.GetTextFromPage(PdfDoc.GetFirstPage(), new SimpleTextExtractionStrategy());
        }
    }

    /// <summary>
    /// Método responsável por localizar o nome dos alunos no arquivo PDF e remover os trechos que não fazem parte do nome.
    /// </summary>
    /// <param name="textoLinha">Texto da linha que contém o nome do aluno</param>
    /// <param name="textoAnterior">Trecho de texto que antecede o nome do aluno.</param>
    /// <param name="textoPosterior">Trecho de texto posterior ao nome do aluno.</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    private static string ObterTexto(string textoLinha, string textoAnterior, string textoPosterior)
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
        throw new Exception("Não foi encontrado o nome do aluno no arquivo");
    }

    private static void DefinirSenha(string inputFile, string outputFile, string senha, string senhaMestre)
    {
        // Criar um PdfReader para o arquivo existente
        PdfReader pdfReader = new PdfReader(inputFile);

        // Criar um PdfWriter para o novo arquivo com as permissões
        PdfWriter pdfWriter = new PdfWriter(outputFile, new WriterProperties()
            .SetStandardEncryption(Encoding.UTF8.GetBytes(senha), Encoding.UTF8.GetBytes(senhaMestre),EncryptionConstants.ALLOW_PRINTING,EncryptionConstants.ENCRYPTION_AES_128));

        // Criar o documento PDF
        PdfDocument pdfDoc = new PdfDocument(pdfReader, pdfWriter);

        pdfDoc.Close();
    }

    private static void RemoverArquivoOriginal(string diretorioArquivo)
    {
        try
        {
            // Verifica se o arquivo existe
            if (File.Exists(diretorioArquivo))
            {
                // Apaga o arquivo
                File.Delete(diretorioArquivo);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar apagar o arquivo: " + ex.Message);
        }
    }
}
