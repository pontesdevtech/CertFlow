using E_Docs.Presenter.Common;
using E_Docs.Presenter.Common.Enums;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Services;
using E_Docs.Views.Common;
using E_Docs.Views.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_Docs.Views.Services;
internal static class EnviarEmailService
{
    /// <summary>
    /// Método responsável por monitorar o envio de emails
    /// </summary>
    /// <param name="emailEnvio">Objeto email para envio da mensagem</param>
    /// <returns>Retorna uma lista de logs de erros e o objeto email para utilização na interface do usuário</returns>
    internal static (EmailDTO? email, List<LogDTO>logs) EnviarEmail(EmailDTO emailEnvio)
    {
        // Monitorar a execução do processo
        var email = ExecutorProcessosCommon.ExecutarProcesso(ENomeProcessoCommon.EnviarEmail, () => EmailService.EnviarEmail(emailEnvio));

        if (email.logs.Count > 0)
        {
            ExcecoesView excecoesView = new();
            var contador = 1;
            foreach (var log in email.logs)
            {
                if (contador == 1) excecoesView.Text = log.GetMensagem().titulo;
                if (contador == 1) excecoesView.MensagemErroLBL.Text = log.GetMensagem().mensagem;
                excecoesView.InformacoesBasicasTXT.Text += log.GetMensagem().informacoesBasicas;
                excecoesView.InformacoesTecnicasTXT.Text += log.GetMensagem().informacoesTecnicas;
                contador++;
            }
            excecoesView.ShowDialog();
        }

        return (email.retorno,email.logs);
    }
}
