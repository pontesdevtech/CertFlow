using E_Docs.Presenter.DTOs;
using E_Docs.Views.Common;
using E_Docs.Views.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E_Docs.Views.Views;
public partial class EnviarCertificadosView : Form
{
    public PrincipalView TelaPrincipal { get; set; }
    public List<CertificadoDTO> Certificados = [];

    public EnviarCertificadosView(PrincipalView telaPrincial, List<CertificadoDTO> certificados)
    {
        InitializeComponent();
        TelaPrincipal = telaPrincial;
        Certificados = certificados;
    }

    private void TagsCBX_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (TagsCBX.SelectedItem != null)
        {
            string tag = TagsCBX.SelectedItem.ToString() ?? string.Empty;

            // Inserir a tag na posição do cursor
            int posicao = MensagemTXT.SelectionStart;
            MensagemTXT.Text = MensagemTXT.Text.Insert(posicao, Auxiliares.InserirTag(tag));

            // Atualizar a posição do cursor após a inserção
            MensagemTXT.SelectionStart = posicao + Auxiliares.InserirTag(tag).Length;

            // Redefinir a seleção do ComboBox
            TagsCBX.SelectedIndex = -1; // Deselecionar após o uso
        }
    }

    private void EnviarBTN_Click(object sender, EventArgs e)
    {
        List<EmailDTO> emails = [];

        TelaPrincipal.Usuario = RemetenteTXT.Text;
        TelaPrincipal.Cc = CcTXT.Text;
        TelaPrincipal.Cco = CcoTXT.Text;
        TelaPrincipal.Mensagem = MensagemTXT.Text;

        foreach (DataGridViewRow row in EmailsDGV.Rows)
        {
            CertificadoDTO? certificado = Certificados.FirstOrDefault(x => x.Matricula.Aluno.Equals(row.Cells["Aluno"].Value));
            var corpoEmailFinal = MensagemTXT.Text;

            corpoEmailFinal = corpoEmailFinal.Replace($"[ALUNO]", certificado.Matricula.Aluno.Split(" - ")[1]);
            corpoEmailFinal = corpoEmailFinal.Replace($"[RA]", certificado.Matricula.Aluno.Split(" - ")[0]);
            corpoEmailFinal = corpoEmailFinal.Replace($"[CPF]", certificado.Matricula.Cpf);
            corpoEmailFinal = corpoEmailFinal.Replace($"[CURSO]", certificado.Matricula.Curso);
            corpoEmailFinal = corpoEmailFinal.Replace($"[PERIODO]", certificado.Periodo);
            corpoEmailFinal = corpoEmailFinal.Replace($"[UNIDADE]", certificado.Unidade);

            EmailDTO email = new
                (
                    emailsDestinatario: [certificado.Matricula.Email],
                    emailsEmCopia: [TelaPrincipal.Cc],
                    emailsEmCopiaOculta: [TelaPrincipal.Cco],
                    assunto: $"Certificado SENAI - {certificado.Matricula.Curso} ({certificado.Matricula.Cpf})",
                    corpoEmail: corpoEmailFinal,
                    anexos: [$"{TelaPrincipal.Diretorio}\\Criptografados\\{certificado.NomeArquivo}"],
                    servidorEmail: new(TelaPrincipal.Provedor, TelaPrincipal.Porta, TelaPrincipal.Usuario, SenhaTXT.Text),
                    matricula: certificado.Matricula
                );
            var envio = EnviarEmailService.EnviarEmail(email);
            emails.Add(envio.email);
        }
        Auxiliares.IdentificarEmailsEnviados(EmailsDGV, emails);
        Auxiliares.IdentificarEmailsEnviados(TelaPrincipal.MatriculasSelecionadasDGV, emails);
        MessageBox.Show("Emails enviados com sucesso!");
    }

    private void EnviarCertificadosView_Load(object sender, EventArgs e)
    {
        //RemetenteTXT.Text = TelaPrincipal.Usuario;
        //CcTXT.Text = TelaPrincipal.Cc;
        //CcoTXT.Text = TelaPrincipal.Cco;
        //MensagemTXT.Text = TelaPrincipal.Mensagem;
        Auxiliares.IdentificarMatriculasComCertificado(EmailsDGV, Certificados);
        Auxiliares.IdentificarEmailsEnviados(EmailsDGV, new());
        if (EmailsDGV.Columns.Contains("[Aluno]")) EmailsDGV.Columns["[Aluno]"].Frozen = true;
    }
}
