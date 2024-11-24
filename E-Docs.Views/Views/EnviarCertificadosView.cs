using E_Docs.Presenter.DTOs;
using E_Docs.Views.Common;
using System;
using System.Collections.Generic;
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

    private void EnviarCertificadosView_Load(object sender, EventArgs e)
    {

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

    private void RemetenteTXT_TextChanged(object sender, EventArgs e)
    {
        TelaPrincipal.Usuario = RemetenteTXT.Text;
        TelaPrincipal.Cc = CcTXT.Text;
        TelaPrincipal.Cco = CcoTXT.Text;
        TelaPrincipal.Mensagem = MensagemTXT.Text;
    }

    private void CcTXT_TextChanged(object sender, EventArgs e)
    {
        TelaPrincipal.Usuario = RemetenteTXT.Text;
        TelaPrincipal.Cc = CcTXT.Text;
        TelaPrincipal.Cco = CcoTXT.Text;
        TelaPrincipal.Mensagem = MensagemTXT.Text;
    }

    private void CcoTXT_TextChanged(object sender, EventArgs e)
    {
        TelaPrincipal.Usuario = RemetenteTXT.Text;
        TelaPrincipal.Cc = CcTXT.Text;
        TelaPrincipal.Cco = CcoTXT.Text;
        TelaPrincipal.Mensagem = MensagemTXT.Text;
    }

    private void MensagemTXT_TextChanged(object sender, EventArgs e)
    {
        TelaPrincipal.Usuario = RemetenteTXT.Text;
        TelaPrincipal.Cc = CcTXT.Text;
        TelaPrincipal.Cco = CcoTXT.Text;
        TelaPrincipal.Mensagem = MensagemTXT.Text;
    }

    private void EnviarBTN_Click(object sender, EventArgs e)
    {

    }

    private void EnviarCertificadosView_Activated(object sender, EventArgs e)
    {
        EmailsDGV.Columns[0].Frozen = true;
        Auxiliares.IdentificarMatriculasComCertificado(EmailsDGV, Certificados);
        Auxiliares.IdentificarEmailsEnviados(EmailsDGV, new());
        if (EmailsDGV.Columns.Contains("[Aluno]")) EmailsDGV.Columns["[Aluno]"].Frozen = true;

    }
}
