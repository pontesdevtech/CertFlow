using E_Docs.Domain.Entities;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace E_Docs.Domain.Services;
public static class EmailService
{
    /// <summary>
    /// Método responsável por chamar os métodos de "preparação da mensagem" e de "envio da mensagem via smtp".
    /// </summary>
    /// <param name="servidor">Objeto que contém as informações do provedor e do usuário de email</param>
    /// <param name="email">Endereço de email do destinatário</param>
    /// <param name="cc">Endereco de email do usuário em cópia</param>
    /// <param name="cco">Endereco de email do usuário em cópia oculta</param>
    /// <param name="assunto">Texto do assunto do email</param>
    /// <param name="corpoEmail">Mensagem do email</param>
    /// <param name="anexo">Diretório do arquivo que será anexado</param>
    /// <returns>Retorna "true" se ocorrer tudo conforme esperado e "false", caso seja lançada alguma exceção</returns>
    public static string EnviarEmail(ServidorEmail servidor, string email, string? cc, string? cco, string assunto, string corpoEmail, string anexo)
    {
        try
        {
            // Carrega a vbariável com o retorno do método "Preparar Mensagem"
            var mensagem = PrepararMensagem(servidor, email, cc, cco, assunto, corpoEmail, anexo);
            // Invoca o método de para envio da mensagem via smtp
            EnviarEmailViaSMTP(servidor, mensagem);
            return $"SUCESSO: Email enviado com sucesso para {mensagem.To}";
        }
        catch (FormatException ex)
        {
            // Exceção lançada em caso de formato inválido de email 
            return $"ERRO: Formato de endereço de email inválido: {ex.Message}";
        }
        catch (SmtpFailedRecipientsException ex)
        {
            // Exceção lançada em caso de email inválido ou inexistente
            string erros = string.Empty;
            foreach (SmtpFailedRecipientException innerEx in ex.InnerExceptions)
            {
                erros += $"ERRO: Falha ao enviar email para {innerEx.FailedRecipient}: {innerEx.Message}";
            }
            return erros;
        }
        catch (SmtpException ex)
        {
            // Exceção lançada em caso de problema com a comunicaçao com o smtp
            return $"ERRO: Erro SMTP: {ex.Message} (Status: {ex.StatusCode})";
        }
        catch (Exception ex)
        {
            // Exceção lançada em casos diferentes dos levantados acima
            return $"ERRO: Erro inesperado: {ex.Message}";
        }
    }

    /// <summary>
    /// Método responsável por preparar a mensagem que será enviada posteriormente
    /// </summary>
    /// <param name="servidor">Objeto que contém as informações do provedor e do usuário de email</param>
    /// <param name="email">Endereço de email do destinatário</param>
    /// <param name="cc">Endereco de email do usuário em cópia</param>
    /// <param name="cco">Endereco de email do usuário em cópia oculta</param>
    /// <param name="assunto">Texto do assunto do email</param>
    /// <param name="corpoEmail">Mensagem do email</param>
    /// <param name="anexo">Diretório do arquivo que será anexado</param>
    /// <returns>Retorna um objeto "MailMessage()"</returns>
    /// <exception cref="Exception"></exception>
    private static MailMessage PrepararMensagem(ServidorEmail servidor, string email, string? cc, string? cco, string assunto, string corpoEmail, string anexo)
    {
        var mail = new MailMessage();

        try
        {
            // Configura as propriedades do objeto MailMessage
            if (servidor.Provedor != null && servidor.Usuario != null && servidor.Senha != null) mail.From = new MailAddress(servidor.Usuario);
            mail.To.Add(ValidarEmail(email));
            if (cc != null) mail.CC.Add(ValidarEmail(cc));
            if (cco != null) mail.Bcc.Add(ValidarEmail(cco));
            mail.Subject = assunto;
            mail.Body = corpoEmail;
            mail.IsBodyHtml = true;
            mail.Attachments.Add(PrepararAnexo(anexo));
        }
        catch (Exception ex)
        {
            throw new Exception($"ERRO: A preparação da imagem falhou! Message{ex.Message}");
        }

        return mail;
    }

    /// <summary>
    /// Método responsável por validar o email
    /// </summary>
    /// <param name="email">Endereço de email que será validado</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    private static MailAddress ValidarEmail(string email)
    {
        MailAddress ma = null!;
        try
        {
            if (!string.IsNullOrEmpty(email))
            {
                ma = new MailAddress(email);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"ERRO: O email {email} é inválido! Message{ex.Message}");
        }

        return ma;
    }

    /// <summary>
    /// Método responsável por preparar s anexos que serão enviados por email
    /// </summary>
    /// <param name="anexo">Diretório do arquivo que será anexado</param>
    /// <returns></returns>
    private static Attachment PrepararAnexo(string anexo)
    {
        var data = new Attachment(anexo, MediaTypeNames.Application.Octet);
        ContentDisposition disposition = data.ContentDisposition;
        // Carrega as informações de criação, modificação e de leitura do arquivo
        disposition.CreationDate = File.GetCreationTime(anexo);
        disposition.ModificationDate = File.GetLastWriteTime(anexo);
        disposition.ReadDate = File.GetLastAccessTime(anexo);
        return data;
    }

    /// <summary>
    /// Método resposnável por realizar o envio da mensagem após a conclusão da preparação
    /// </summary>
    /// <param name="servidor">Informações do provedor e do usuário do email</param>
    /// <param name="mensagem">Objeto que carregas as configurações da mensagem que será enviada</param>
    private static void EnviarEmailViaSMTP(ServidorEmail servidor, MailMessage mensagem)
    {
        SmtpClient smtpClient = new SmtpClient();

        smtpClient.Host = servidor.Provedor;
        smtpClient.Port = servidor.Porta;
        smtpClient.EnableSsl = true;
        smtpClient.Timeout = 30000; // Timout que 30 segundos
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential(servidor.Usuario, servidor.Senha);
        smtpClient.Send(mensagem);
        smtpClient.Dispose();
    }
}
