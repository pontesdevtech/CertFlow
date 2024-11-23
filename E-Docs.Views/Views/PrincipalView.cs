using E_Docs.Views.Common;
using E_Docs.Views.Views;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace E_Docs.Views;

public partial class PrincipalView : Form
{
    public DataTable Dt { get; set; } = new DataTable();

    public PrincipalView()
    {
        InitializeComponent();
    }

    private void ImportarMatriculasBTN_Click(object sender, EventArgs e)
    {
        ImportarMatriculasView importarMatriculas = new(this);
        importarMatriculas.ShowDialog();
    }

    private void PrincipalView_Load(object sender, EventArgs e)
    {

    }

    private void PrincipalView_Activated(object sender, EventArgs e)
    {
        MatriculasSelecionadasDGV.DataSource = Dt;

        //if (MatriculasSelecionadasDGV.Rows.Count > 0)
        //{
        //    Formatacao.FormatarDgv(MatriculasSelecionadasDGV);
        //}

        foreach (DataGridViewRow linha in MatriculasSelecionadasDGV.Rows)
        {
            linha.Cells["[X]"].Value = false;
        }

        FeedbackLBL.Text = Auxiliares.ContarRegistros(MatriculasSelecionadasDGV).feedback;
    }

    private void NovoBTN_Click(object sender, EventArgs e)
    {

    }

    private void MatriculasSelecionadasDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        // Verificar se o clique foi na coluna de CheckBox (por exemplo, na coluna com índice 0)
        if (e.ColumnIndex == 6)
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
                    if ((bool)chk.Value)
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
    }
}
