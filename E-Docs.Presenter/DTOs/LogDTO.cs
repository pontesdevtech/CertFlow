using System.Net.Mail;
using System.Text;

namespace E_Docs.Presenter.DTOs;
public class LogDTO
{
    /// <summary>
    /// Método construtor da classe
    /// </summary>
    /// <param name="excecao">Exceção capturada durante a execução de um processo</param>
    /// <param name="nomeProcesso">Nome do processo que lançou a exceção</param>
    public LogDTO(Exception excecao, string nomeProcesso)
    {
        NomeProcesso = nomeProcesso ?? string.Empty;
        DtCriacao = DateTime.Now;
        TipoExcecao = excecao.GetType();
        Mensagem = excecao.Message ?? string.Empty;
        StackTrace = excecao.StackTrace ?? string.Empty;
        InnerExceptionMessage = excecao.InnerException.Message ?? string.Empty;
        MensagemUsuario = GerarMensagemParaUsuario(excecao) ?? string.Empty;
    }

    // Atributos da classe
    public string NomeProcesso { get; set; }
    public DateTime DtCriacao { get; set; }
    public Type TipoExcecao { get; set; }
    public string Mensagem { get; set; }
    public string StackTrace { get; set; }
    public string InnerExceptionMessage { get; set; }
    public string MensagemUsuario { get; set; }

    /// <summary>
    /// Método responsável por gerar a mensagem amigavel para o usuário final
    /// </summary>
    /// <param name="excecao">Exceção capturada durante a execução de um processo</param>
    /// <returns>Retorna uma mensagem amigável para o usuário final</returns>
    private string GerarMensagemParaUsuario(Exception excecao)
    {
        return excecao switch
        {
            EncoderFallbackException => "Erro ao codificar o texto. Verifique os caracteres especiais e tente novamente.",
            ArgumentNullException => "Um valor necessário está ausente. Por favor, verifique e tente novamente.",
            ArgumentOutOfRangeException => "O valor fornecido está fora do intervalo permitido. Verifique e ajuste o valor.",
            ArgumentException => "Há um erro nos parâmetros fornecidos. Verifique as informações e tente novamente.",
            PathTooLongException => "O caminho especificado é muito longo. Reduza o comprimento do caminho e tente novamente.",
            DirectoryNotFoundException => "O diretório especificado não foi encontrado. Verifique o caminho e tente novamente.",
            UnauthorizedAccessException => "Você não tem permissão para acessar este recurso. Verifique suas permissões.",
            FileNotFoundException => "O arquivo especificado não foi encontrado. Verifique o caminho e tente novamente.",
            NotSupportedException => "Esta operação não é suportada. Verifique a documentação.",
            IOException => "Ocorreu um erro de entrada/saída ao acessar o recurso. Verifique e tente novamente.",
            FormatException => "O formato dos dados fornecidos é inválido. Verifique e tente novamente.",
            ObjectDisposedException => "Tentativa de acessar um recurso que já foi liberado. Reinicie o processo e tente novamente.",
            InvalidOperationException => "A operação solicitada não é válida neste contexto. Verifique a lógica do processo.",
            SmtpFailedRecipientsException => "Falha ao enviar e-mail para um ou mais destinatários. Verifique os endereços e tente novamente.",
            SmtpFailedRecipientException => "Falha ao enviar e-mail para o destinatário. Verifique o endereço e tente novamente.",
            SmtpException => "Ocorreu um erro ao enviar o e-mail. Verifique a conexão e as configurações de SMTP.",
            _ => "Ocorreu um erro inesperado. Tente novamente ou entre em contato com o suporte."
        };

    }


}
