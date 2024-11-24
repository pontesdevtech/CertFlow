using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Mappings;
using E_Docs.Views.Common;
using E_Docs.Views.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace E_Docs.Views;

public partial class PrincipalView : Form
{
    public List<CertificadoDTO> Certificados = [];
    public List<MatriculaDTO> Matriculas = [];
    public string? Diretorio { get; set; } = string.Empty;

    public readonly string Provedor = "smtp.office365.com";
    public readonly int Porta = 587;
    public string Usuario { get; set; } = string.Empty;
    public string Cc { get; set; } = string.Empty;
    public string Cco { get; set; } = string.Empty;
    public string Mensagem { get; set; } = string.Empty;

    public PrincipalView()
    {
        InitializeComponent();
    }

    private void ImportarMatriculasBTN_Click(object sender, EventArgs e)
    {
        ImportarMatriculasView importarMatriculas = new(this);
        importarMatriculas.ShowDialog();
    }

    private void EnviarCertificadosBTN_Click(object sender, EventArgs e)
    {
        EnviarCertificadosView enviarCertificados = new(this, Certificados);

        List<MatriculaDTO> matriculas = [];
        foreach (DataGridViewRow row in MatriculasSelecionadasDGV.Rows)
        {
            var certificado = Certificados.FirstOrDefault(x => x.Matricula.Aluno.Equals(row.Cells["Aluno"].Value));
            if (certificado != null && row.Cells["[X]"].Value is true)
            {
                matriculas.Add(certificado.Matricula);
            }
        }

        Auxiliares.FiltrarMatriculas(true, enviarCertificados.EmailsDGV, matriculas, Certificados, enviarCertificados.FeedbackLBL);

        enviarCertificados.EmailsDGV.DataSource = matriculas;
        FormatacaoCommon.FormatarDgv(enviarCertificados.EmailsDGV);

        enviarCertificados.ShowDialog();
    }

    private void MatriculasSelecionadasDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        // Verificar se o clique foi na coluna de CheckBox (por exemplo, na coluna com índice 0)
        if (e.ColumnIndex == MatriculasSelecionadasDGV.Columns["[X]"].Index)
        {
            int linhasMarcadas = Auxiliares.ContarRegistros(MatriculasSelecionadasDGV).selecionados;

            if (Auxiliares.ContarRegistros(MatriculasSelecionadasDGV).total.Equals(linhasMarcadas))
            {
                // Desmarca todos os checkbox
                foreach (DataGridViewRow row in MatriculasSelecionadasDGV.Rows)
                {
                    if (row.Cells["[X]"] is DataGridViewCheckBoxCell chk)
                    {
                        chk.Value = false;
                        // Deselecionar a linha inteira
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Black;
                        MatriculasSelecionadasDGV.Rows[row.Index].Selected = false;
                    }
                }
            }
            else
            {
                // Alternar todos os CheckBox das linhas
                foreach (DataGridViewRow row in MatriculasSelecionadasDGV.Rows)
                {
                    if (row.Cells["[X]"] is DataGridViewCheckBoxCell chk)
                    {
                        chk.Value = true;
                        // Selecionar a linha inteira
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }

        }
        FeedbackLBL.Text = Auxiliares.ContarRegistros(MatriculasSelecionadasDGV).feedback;
        int count = MatriculasSelecionadasDGV.Rows.Cast<DataGridViewRow>()
                    .Count(linha => !linha.IsNewRow &&
                    Convert.ToBoolean(linha.Cells["[X]"].Value) &&
                    !string.IsNullOrEmpty(linha.Cells["Unidade"].Value?.ToString()));

        EnviarCertificadosBTN.Enabled = count > 0 ? true : false;
    }

    private void MatriculasSelecionadasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // Verificar se o clique foi em uma linha válida (evitar cabeçalho)
        if (e.RowIndex >= 0)
        {
            // Verificar se existe uma coluna de CheckBox chamada "Selecionar"
            if (MatriculasSelecionadasDGV.Columns.Contains("[X]"))
            {
                // Obter a célula de CheckBox da linha atual
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)MatriculasSelecionadasDGV.Rows[e.RowIndex].Cells["[X]"];

                // Alternar o valor do CheckBox (true/false)
                checkBoxCell.Value = !(checkBoxCell.Value != null && (bool)checkBoxCell.Value);

                DataGridViewCheckBoxCell chk;
                foreach (DataGridViewRow row in MatriculasSelecionadasDGV.Rows)
                {
                    chk = (DataGridViewCheckBoxCell)MatriculasSelecionadasDGV.Rows[row.Index].Cells["[X]"];
                    // Verificar se o CheckBox está marcado
                    if (Convert.ToBoolean(checkBoxCell.Value))
                    {
                        // Selecionar a linha inteira
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Deselecionar a linha inteira
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        MatriculasSelecionadasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Black;
                        MatriculasSelecionadasDGV.Rows[row.Index].Selected = false;
                    }
                }
                // Forçar o DataGridView a atualizar a célula imediatamente
                MatriculasSelecionadasDGV.EndEdit();
                FeedbackLBL.Text = Auxiliares.ContarRegistros(MatriculasSelecionadasDGV).feedback;
                int count = MatriculasSelecionadasDGV.Rows.Cast<DataGridViewRow>()
                    .Count(linha => !linha.IsNewRow &&
                    Convert.ToBoolean(linha.Cells["[X]"].Value) &&
                    !string.IsNullOrEmpty(linha.Cells["Unidade"].Value?.ToString()));

                EnviarCertificadosBTN.Enabled = count > 0 ? true : false;
            }
        }
    }

    private void MatriculasSelecionadasDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        int linha = e.RowIndex;
        CursoTXT.Text = MatriculasSelecionadasDGV.Rows[linha].Cells["Curso"].Value.ToString();
        TurmaTXT.Text = MatriculasSelecionadasDGV.Rows[linha].Cells["Turma"].Value.ToString();
        AlunoTXT.Text = MatriculasSelecionadasDGV.Rows[linha].Cells["Aluno"].Value.ToString();
        CpfTXT.Text = MatriculasSelecionadasDGV.Rows[linha].Cells["CPF"].Value.ToString();
        EmailTXT.Text = MatriculasSelecionadasDGV.Rows[linha].Cells["Email"].Value.ToString();

        MatriculasSelecionadasDGV.Enabled = MatriculasSelecionadasDGV.Rows.Count > 0 ? true : false;
        PainelOpcoesPNL.Enabled = MatriculasSelecionadasDGV.Rows.Count > 0 ? true : false;
    }

    private void ApenasComCertificadosCHK_CheckedChanged(object sender, EventArgs e)
    {
        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK.Checked, MatriculasSelecionadasDGV, Matriculas, Certificados, FeedbackLBL);
        if (MatriculasSelecionadasDGV.Columns.Contains("[X]")) MatriculasSelecionadasDGV.Columns["[X]"].Frozen = true;
    }

    private void PrincipalView_Load(object sender, EventArgs e)
    {
        MatriculasSelecionadasDGV.DataSource = Matriculas;

        foreach (DataGridViewRow linha in MatriculasSelecionadasDGV.Rows)
        {
            linha.Cells["[X]"].Value = false;
        }

        FeedbackLBL.Text = Auxiliares.ContarRegistros(MatriculasSelecionadasDGV).feedback;
        int count = MatriculasSelecionadasDGV.Rows.Cast<DataGridViewRow>()
                    .Count(linha => !linha.IsNewRow &&
                    Convert.ToBoolean(linha.Cells["[X]"].Value) &&
                    !string.IsNullOrEmpty(linha.Cells["Unidade"].Value?.ToString()));

        PainelOpcoesPNL.Enabled = MatriculasSelecionadasDGV.Rows.Count > 0 ? true : false;
        EnviarCertificadosBTN.Enabled = count > 0 ? true : false;
        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK.Checked, MatriculasSelecionadasDGV, Matriculas, Certificados, FeedbackLBL);
        if (MatriculasSelecionadasDGV.Columns.Contains("[X]")) MatriculasSelecionadasDGV.Columns["[X]"].Frozen = true;
    }

    private void LimparBTN_Click(object sender, EventArgs e)
    {
        if (MatriculasSelecionadasDGV.Rows.Count > 0) Matriculas.Clear();
        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK.Checked, MatriculasSelecionadasDGV, Matriculas, Certificados, FeedbackLBL);
        if (MatriculasSelecionadasDGV.Columns.Contains("[X]")) MatriculasSelecionadasDGV.Columns["[X]"].Frozen = true;
    }
}
