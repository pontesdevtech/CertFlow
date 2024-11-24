using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Mappings;

namespace E_Docs.Presenter.Services;
public static class EmailService
{
    public static EmailDTO EnviarEmail(EmailDTO email)
    {
         Domain.Services.EmailService.EnviarEmail(EmailMap.EmailDtoParaEmail(email));
        return email;
    }
}
