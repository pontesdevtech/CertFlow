using E_Docs.Domain.Entities;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace E_Docs.Domain.Services;
public static class EmailService
{
    /// <summary>
    /// Método responsável por chamar os métodos de "preparação da mensagem" e de "envio da mensagem via smtp".
    /// </summary>
    /// <param name="servidor">Objeto que contém as informações do provedor e do usuário de email</param>
    /// <param name="email">Objeto que contém as informações dos destinatários, da mensagem e de seus anexos</param>
    /// <returns>Retorna uma mensagem de sucesso ao final da operação, caso ocorra conforme esperado</returns>
    /// <exception cref="ArgumentOutOfRangeException">Lançada quando um argumento está fora do intervalo permitido.</exception>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="PathTooLongException">Lançada quando o caminho do arquivo excede o limite de caracteres permitido.</exception>
    /// <exception cref="UnauthorizedAccessException">Lançada quando o acesso ao arquivo ou diretório é negado devido a permissões insuficientes.</exception>
    /// <exception cref="NotSupportedException">Lançada quando uma operação não é suportada.</exception>
    /// <exception cref="FormatException">Lançada quando ocorre um erro de formato ao tentar converter ou processar dados.</exception>
    /// <exception cref="ObjectDisposedException">Lançada quando uma operação é realizada em um objeto que já foi descartado.</exception>
    /// <exception cref="InvalidOperationException">Lançada quando uma operação é realizada em um estado inválido para o objeto.</exception>
    /// <exception cref="SmtpFailedRecipientsException">Lançada quando a entrega de um e-mail falha para múltiplos destinatários.</exception>
    /// <exception cref="SmtpFailedRecipientException">Lançada quando a entrega de um e-mail falha para um destinatário específico.</exception>
    /// <exception cref="SmtpException">Lançada quando ocorre um erro relacionado ao envio de um e-mail via SMTP.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    public static string EnviarEmail(ServidorEmail servidor, Email email)
    {
        try
        {
            // Carrega a variável com o retorno do método "Preparar Mensagem"
            var mensagem = PrepararMensagem(servidor, email);
            // Invoca o método de para envio da mensagem via smtp
            EnviarEmailViaSMTP(servidor, mensagem);
            //Retorna uma mensagem personalizada com os emails de destinatário principal
            string destinatarios = string.Empty;
            foreach (var destinatario in mensagem.To) destinatarios = $"{destinatario.User}; ";
            return $"SUCESSO: Email enviado com sucesso para {destinatarios}";
        }
        catch (ArgumentOutOfRangeException) { throw; }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (PathTooLongException) { throw; }
        catch (UnauthorizedAccessException) { throw; }
        catch (NotSupportedException) { throw; }
        catch (FormatException) { throw; }
        catch (ObjectDisposedException) { throw; }
        catch (InvalidOperationException) { throw; }
        catch (SmtpFailedRecipientsException) { throw; }
        catch (SmtpFailedRecipientException) { throw; }
        catch (SmtpException) { throw; }
        catch (Exception) { throw; }
    }

    /// <summary>
    /// Método responsável por preparar a mensagem que será enviada posteriormente
    /// </summary>
    /// <param name="servidor">Objeto que contém as informações do provedor e do usuário de email</param>
    /// <param name="email">Objeto que contém as informações dos destinatários, da mensagem e de seus anexos</param>
    /// <returns>Retorna um objeto "MailMessage()"</returns>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="PathTooLongException">Lançada quando o caminho do arquivo excede o limite de caracteres permitido.</exception>
    /// <exception cref="UnauthorizedAccessException">Lançada quando o acesso ao arquivo ou diretório é negado devido a permissões insuficientes.</exception>
    /// <exception cref="NotSupportedException">Lançada quando uma operação não é suportada.</exception>
    /// <exception cref="FormatException">Lançada quando ocorre um erro de formato ao tentar converter ou processar dados.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static MailMessage PrepararMensagem(ServidorEmail servidor, Email email)
    {
        MailMessage mail = new();

        try
        {
            // Configura as propriedades do objeto MailMessage
            if (servidor.Provedor != null && servidor.Usuario != null && servidor.Senha != null) mail.From = new MailAddress(servidor.Usuario);
            foreach (var to in email.EmailsDestinatario) mail.To.Add(ValidarEmail(to));
            foreach (var cc in email.EmailsEmCopia) mail.CC.Add(ValidarEmail(cc));
            foreach (var cco in email.EmailsEmCopiaOculta) mail.Bcc.Add(ValidarEmail(cco));
            mail.Subject = email.Assunto;
            mail.Body = email.CorpoEmail;
            mail.IsBodyHtml = true;
            foreach (var anexo in email.Anexos) mail.Attachments.Add(PrepararAnexo(anexo));
            return mail;
        }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (PathTooLongException) { throw; }
        catch (UnauthorizedAccessException) { throw; }
        catch (NotSupportedException) { throw; }
        catch (FormatException) { throw; }
        catch (Exception) { throw; }
    }

    /// <summary>
    /// Método responsável por validar o formato do email
    /// </summary>
    /// <param name="email">Endereço de email que será validado</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="FormatException">Lançada quando ocorre um erro de formato ao tentar converter ou processar dados.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static MailAddress ValidarEmail(string email)
    {
        MailAddress ma = null!;
        try
        {
            if (!string.IsNullOrEmpty(email))
            {
                ma = new MailAddress(email);
            }
            return ma;
        }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (FormatException) { throw; }
        catch (Exception) { throw; }
    }

    /// <summary>
    /// Método responsável por preparar os anexos que serão enviados por email
    /// </summary>
    /// <param name="anexo">Diretório do arquivo que será anexado</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="PathTooLongException">Lançada quando o caminho do arquivo excede o limite de caracteres permitido.</exception>
    /// <exception cref="UnauthorizedAccessException">Lançada quando o acesso ao arquivo ou diretório é negado devido a permissões insuficientes.</exception>
    /// <exception cref="NotSupportedException">Lançada quando uma operação não é suportada.</exception>
    /// <exception cref="FormatException">Lançada quando ocorre um erro de formato ao tentar converter ou processar dados.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static Attachment PrepararAnexo(string diretorioArquivo)
    {
        try
        {
            var anexo = new Attachment(diretorioArquivo, MediaTypeNames.Application.Octet);
            ContentDisposition? disposition = anexo.ContentDisposition;
            // Carrega as informações de criação, modificação e de leitura do arquivo
            disposition.CreationDate = File.GetCreationTime(diretorioArquivo);
            disposition.ModificationDate = File.GetLastWriteTime(diretorioArquivo);
            disposition.ReadDate = File.GetLastAccessTime(diretorioArquivo);
            return anexo;
        }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (PathTooLongException) { throw; }
        catch (UnauthorizedAccessException) { throw; }
        catch (NotSupportedException) { throw; }
        catch (FormatException) { throw; }
        catch (Exception) { throw; }
    }

    /// <summary>
    /// Método resposnável por realizar o envio da mensagem após a conclusão da preparação
    /// </summary>
    /// <param name="servidor">Informações do provedor e do usuário do email</param>
    /// <param name="mensagem">Objeto que carregas as configurações da mensagem que será enviada</param>
    /// <exception cref="ArgumentOutOfRangeException">Lançada quando um argumento está fora do intervalo permitido.</exception>
    /// <exception cref="ArgumentNullException">Lançada quando um argumento necessário é nulo.</exception>
    /// <exception cref="ArgumentException">Lançada quando um argumento é inválido ou não esperado.</exception>
    /// <exception cref="ObjectDisposedException">Lançada quando uma operação é realizada em um objeto que já foi descartado.</exception>
    /// <exception cref="InvalidOperationException">Lançada quando uma operação é realizada em um estado inválido para o objeto.</exception>
    /// <exception cref="SmtpFailedRecipientsException">Lançada quando a entrega de um e-mail falha para múltiplos destinatários.</exception>
    /// <exception cref="SmtpFailedRecipientException">Lançada quando a entrega de um e-mail falha para um destinatário específico.</exception>
    /// <exception cref="SmtpException">Lançada quando ocorre um erro relacionado ao envio de um e-mail via SMTP.</exception>
    /// <exception cref="Exception">Lançada quando ocorre um erro inesperado.</exception>
    private static void EnviarEmailViaSMTP(ServidorEmail servidor, MailMessage mensagem)
    {
        SmtpClient smtpClient = new();
        try
        {
            smtpClient.Host = servidor.Provedor;
            smtpClient.Port = servidor.Porta;
            smtpClient.EnableSsl = true;
            smtpClient.Timeout = 30000; // Timout que 30 segundos
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(servidor.Usuario, servidor.Senha);
            smtpClient.Send(mensagem);
            smtpClient.Dispose();
        }
        catch (ArgumentOutOfRangeException) { throw; }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (ObjectDisposedException) { throw; }
        catch (InvalidOperationException) { throw; }
        catch (SmtpFailedRecipientsException) { throw; }
        catch (SmtpFailedRecipientException) { throw; }
        catch (SmtpException) { throw; }
        catch (Exception) { throw; }
    }
}
