namespace E_Docs.Presenter.DTOs;
public class EmailDTO
{
    /// <summary>
    /// Contrutor da classe
    /// </summary>
    /// <param name="emailsDestinatario">Emails do destinatário principal</param>
    /// <param name="emailsEmCopia">Emails em cópia do destinatário</param>
    /// <param name="emailsEmCopiaOculta">Emails em cópia oculta do destinatário</param>
    /// <param name="assunto">Assundo do texto</param>
    /// <param name="corpoEmail">Texto do corpo do texto</param>
    /// <param name="anexos">Lista de anxos a serem enviados no texto</param>
    /// <param name="servidorEmail">Informações do provedor e do usuário remetente</param>
    public EmailDTO(List<string> emailsDestinatario, List<string>? emailsEmCopia, List<string>? emailsEmCopiaOculta, string assunto, string corpoEmail, List<string> anexos, ServidorEmailDTO servidorEmail)
    {
        EmailsDestinatario = emailsDestinatario;
        EmailsEmCopia = emailsEmCopia;
        EmailsEmCopiaOculta = emailsEmCopiaOculta;
        Assunto = assunto;
        CorpoEmail = corpoEmail;
        Anexos = anexos;
        ServidorEmail = servidorEmail;
    }

    // Atributos da classe
    public List<string> EmailsDestinatario { get; set; }
    public List<string>? EmailsEmCopia { get; set; }
    public List<string>? EmailsEmCopiaOculta { get; set; }
    public string Assunto { get; set; }
    public string CorpoEmail { get; set; }
    public List<string> Anexos { get; set; }
    public ServidorEmailDTO ServidorEmail { get; set; }
}
