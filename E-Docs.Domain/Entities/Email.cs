namespace E_Docs.Domain.Entities;
public class Email
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
    public Email(List<string> emailsDestinatario, List<string>? emailsEmCopia, List<string>? emailsEmCopiaOculta, string assunto, string corpoEmail, List<string> anexos, ServidorEmail servidorEmail)
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
    public ServidorEmail ServidorEmail { get; set; }

    /// <summary>
    /// Método responsável por listar textos em um único textos
    /// </summary>
    /// <param name="listaEmails">Lista de textos para consolidação</param>
    /// <returns>Retorna um textos único contendo todos os textos recebidos no parâmetro</returns>
    private string ListarTextos(List<string>listaTexto)
    {
        string textos = string.Empty;
        int contator = 1;
        foreach (var texto in listaTexto)
        {
            if (listaTexto.Count > 1 && contator > 1)
            {
                textos += $" | {texto}";
            }
            else
            {
                textos = texto;
            }
        }
        return textos;
    }
    /// <summary>
    /// Sobrescrição do método "ToString()" para exibição das informações do texto.
    /// </summary>
    public override string ToString()
    {
        return $"# Remetente: {ServidorEmail.Usuario}{Environment.NewLine}" +
               $"# Destinatários: {ListarTextos(EmailsDestinatario)}{Environment.NewLine}" +
               $"# Emails em cópia: {ListarTextos(EmailsEmCopia)}{Environment.NewLine}" +
               $"# Emails em cópia oculta: {ListarTextos(EmailsEmCopiaOculta)}{Environment.NewLine}" +
               $"# Assunto: {Assunto}{Environment.NewLine}" +
               $"# Mensagem: {CorpoEmail}{Environment.NewLine}" +
               $"# Anexos: {ListarTextos(Anexos)}{Environment.NewLine}" +
               $"{Environment.NewLine}";
    }
}
