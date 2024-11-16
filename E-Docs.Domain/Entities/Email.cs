namespace E_Docs.Domain.Entities;
public class Email
{
    public Email(ServidorEmail servidorEmail, string emailDestinatario, string? emailEmCopia, string? emailEmCopiaOculta, string assunto, string corpoEmail, List<string> anexos)
    {
        ServidorEmail = servidorEmail;
        EmailDestinatario = emailDestinatario;
        EmailEmCopia = emailEmCopia;
        EmailEmCopiaOculta = emailEmCopiaOculta;
        Assunto = assunto;
        CorpoEmail = corpoEmail;
        Anexos = anexos;
    }

    public ServidorEmail ServidorEmail { get; set; }
    public string EmailDestinatario { get; set; }
    public string? EmailEmCopia { get; set; }
    public string? EmailEmCopiaOculta { get; set; }
    public string Assunto { get; set; }
    public string CorpoEmail { get; set; }
    public List<string> Anexos { get; set; }
}
