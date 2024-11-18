using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;

namespace E_Docs.Presenter.Mappings;
public class EmailMap
{
    /// <summary>
    /// Método responsável por converter uma "EmailDTO" em "Email".
    /// </summary>
    /// <param name="dto">"EmailDTO" que será convertida em "Email"</param>
    /// <returns>Retorna um objeto do tipo <see cref="Email"/>.</returns>
    public static Email EmailDtoParaEmail(EmailDTO dto)
    {
        ServidorEmail servidor = new ServidorEmail
        (
            provedor: dto.ServidorEmail.Provedor,
            porta: dto.ServidorEmail.Porta,
            usuario: dto.ServidorEmail.Usuario,
            senha: dto.ServidorEmail.Senha
        );

        Email email = new Email
        (
            emailsDestinatario: dto.EmailsDestinatario,
            emailsEmCopia: dto.EmailsEmCopia,
            emailsEmCopiaOculta: dto.EmailsEmCopiaOculta,
            assunto: dto.Assunto,
            corpoEmail: dto.CorpoEmail,
            anexos: dto.Anexos,
            servidorEmail: servidor
        );
        return email;
    }

    /// <summary>
    /// Método responsável por converter uma "Email" em "EmailDTO".
    /// </summary>
    /// <param name="email">"Email" que será convertida em "EmailDTO"</param>
    /// <returns>Retorna um objeto do tipo <see cref="EmailDTO"/>.</returns>
    public static EmailDTO EmailParaEmailDto(Email email)
    {
        ServidorEmailDTO servidorDto = new ServidorEmailDTO
        (
            provedor: email.ServidorEmail.Provedor,
            porta: email.ServidorEmail.Porta,
            usuario: email.ServidorEmail.Usuario,
            senha: email.ServidorEmail.Senha
        );

        EmailDTO dto = new EmailDTO
        (
            emailsDestinatario: email.EmailsDestinatario,
            emailsEmCopia: email.EmailsEmCopia,
            emailsEmCopiaOculta: email.EmailsEmCopiaOculta,
            assunto: email.Assunto,
            corpoEmail: email.CorpoEmail,
            anexos: email.Anexos,
            servidorEmail: servidorDto
        );
        return dto;
    }
}
