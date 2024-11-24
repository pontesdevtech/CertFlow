using E_Docs.Presenter.DTOs;
using E_Docs.Views.Common;
using E_Docs.Views.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace E_Docs.Views.Views;
public partial class ImportarMatriculasView : Form
{
    public PrincipalView TelaPrincipal { get; set; }
    private List<MatriculaDTO> Matriculas = [];
    private List<CertificadoDTO> Certificados = [];

    public ImportarMatriculasView(PrincipalView telaPrincial)
    {
        InitializeComponent();
        TelaPrincipal = telaPrincial;
    }

    /// <summary>
    /// Carrega a lista de matrículas caso o arquivo selecionado retorne valores válidos
    /// </summary>
    private void ImportarMatriculasBTN_Click(object sender, EventArgs e)
    {
        DiretorioMatriculasTXT.Text = Dialogo.SelecionarArquivo() ?? string.Empty;

        if (DiretorioMatriculasTXT.Text != string.Empty)
        {
            var retorno = ImportarMatriculasService.ImportarMatriculas(DiretorioMatriculasTXT.Text, MatriculasDGV);

            if (retorno.matriculas.Count == 0 && retorno.logs.Count > 0)
            {
                DiretorioMatriculasTXT.Text = string.Empty;
            }
            else
            {
                Matriculas = retorno.matriculas;
                Certificados.Clear();
                DiretorioCertificadosTXT.Text = string.Empty;
                // Carrega a imagem de pendente para todos os registros de matrículas e aplica o valor fallso para a coluna de caixa de seleção
                foreach (DataGridViewRow row in MatriculasDGV.Rows)
                {
                    row.Cells["[X]"].Value = false;
                    row.Cells["Certificado"].Value = Properties.Resources.PendenteVermelho;

                }
                // Carrega os certificados identificados na importação da matrícula, se houver
                Certificados = retorno.certificados;
            }
            // Se forem encontrados certificados vinculados às matrículas importadas, carrega-os no datagridview
            if (Certificados.Count > 0) Auxiliares.IdentificarMatriculasComCertificado(MatriculasDGV, Certificados);

            if (MatriculasDGV.Columns.Contains("[X]")) MatriculasDGV.Columns["[X]"].Frozen = true;
            var feedback = Auxiliares.ContarRegistros(MatriculasDGV);
            FeedbackLBL.Text = feedback.feedback;
        }
    }

    /// <summary>
    /// Carrega a lista de Certificados caso sejam encontrados no diretório
    /// </summary>
    private void ImportarCertificadosBTN_Click(object sender, EventArgs e)
    {
        DiretorioCertificadosTXT.Text = Dialogo.SelecionarPasta() ?? string.Empty;

        if (DiretorioCertificadosTXT.Text != string.Empty)
        {
            Certificados.Clear();
            var retorno = ImportarCertificadosService.ImportarCertificados(DiretorioCertificadosTXT.Text, ConfiguracaoCommon.pswd(), Matriculas);
            Certificados = retorno.certificados ?? Certificados;

            if (Certificados.Count == 0 && retorno.logs.Count > 0)
            {
                DiretorioCertificadosTXT.Text = string.Empty;
            }
            else
            {
                Auxiliares.IdentificarMatriculasComCertificado(MatriculasDGV, Certificados);
            }
            if (MatriculasDGV.Columns.Contains("[X]")) MatriculasDGV.Columns["[X]"].Frozen = true;
            var feedback = Auxiliares.ContarRegistros(MatriculasDGV);
            FeedbackLBL.Text = feedback.feedback;
        }
    }

    /// <summary>
    /// Ativa o botão para importar Certificados quando está preenchido
    /// </summary>
    private void DiretorioMatriculasTXT_TextChanged(object sender, EventArgs e)
    {
        if (DiretorioMatriculasTXT.Text == string.Empty)
        {
            ImportarCertificadosBTN.Enabled = false;
        }
        else
        {
            ImportarCertificadosBTN.Enabled = true;
        }
    }

    /// <summary>
    /// responsável pela seleção de linhas do datagridview
    /// </summary>
    private void MatriculasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // Verificar se o clique foi em uma linha válida (evitar cabeçalho)
        if (e.RowIndex >= 0)
        {
            // Verificar se existe uma coluna de CheckBox chamada "Selecionar"
            if (MatriculasDGV.Columns.Contains("[X]"))
            {
                // Obter a célula de CheckBox da linha atual
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)MatriculasDGV.Rows[e.RowIndex].Cells["[X]"];

                // Alternar o valor do CheckBox (true/false)
                checkBoxCell.Value = !(checkBoxCell.Value != null && (bool)checkBoxCell.Value);

                //DataGridViewCheckBoxCell chk;
                foreach (DataGridViewRow row in MatriculasDGV.Rows)
                {
                    checkBoxCell = (DataGridViewCheckBoxCell)MatriculasDGV.Rows[row.Index].Cells["[X]"];
                    // Verificar se o CheckBox está marcado
                    if (Convert.ToBoolean(checkBoxCell.Value))
                    {
                        // Selecionar a linha inteira
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Deselecionar a linha inteira
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Black;
                        MatriculasDGV.Rows[row.Index].Selected = false;
                    }
                }
                // Forçar o DataGridView a atualizar a célula imediatamente
                MatriculasDGV.EndEdit();
                var feedback = Auxiliares.ContarRegistros(MatriculasDGV);
                FeedbackLBL.Text = feedback.feedback;

                int count = MatriculasDGV.Rows.Cast<DataGridViewRow>()
                    .Count(linha => !linha.IsNewRow &&
                    Convert.ToBoolean(linha.Cells["[X]"].Value) &&
                    !string.IsNullOrEmpty(linha.Cells["Unidade"].Value?.ToString()));

                if (count > 0)
                {
                    ConfirmarBTN.Enabled = true;
                }
                else
                {
                    ConfirmarBTN.Enabled = false;
                }
            }
        }
    }

    /// <summary>
    /// Filtra apenas as matrículas que possuem Certificados criptografados
    /// </summary>
    private void ApenasComCertificadosCHK_CheckedChanged(object sender, EventArgs e)
    {
        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK.Checked, MatriculasDGV, Matriculas, Certificados, FeedbackLBL);
        if (MatriculasDGV.Columns.Contains("[X]")) MatriculasDGV.Columns["[X]"].Frozen = true;
    }

    /// <summary>
    /// Seleciona ou desseleciona todos os registros visíveis no datagridview
    /// </summary>
    private void MatriculasDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        // Verificar se o clique foi na coluna de CheckBox (por exemplo, na coluna com índice 0)
        if (e.ColumnIndex == MatriculasDGV.Columns["[X]"].Index)
        {
            int linhasMarcadas = Auxiliares.ContarRegistros(MatriculasDGV).selecionados;

            if (Auxiliares.ContarRegistros(MatriculasDGV).total.Equals(linhasMarcadas))
            {
                // Desmarca todos os checkbox
                foreach (DataGridViewRow row in MatriculasDGV.Rows)
                {
                    if (row.Cells["[X]"] is DataGridViewCheckBoxCell chk)
                    {
                        chk.Value = false;
                        // Deselecionar a linha inteira
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Black;
                        MatriculasDGV.Rows[row.Index].Selected = false;
                    }
                }
            }
            else
            {
                // Alternar todos os CheckBox das linhas
                foreach (DataGridViewRow row in MatriculasDGV.Rows)
                {
                    if (row.Cells["[X]"] is DataGridViewCheckBoxCell chk)
                    {
                        chk.Value = true;
                        // Selecionar a linha inteira
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        MatriculasDGV.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }

        }
        var feedback = Auxiliares.ContarRegistros(MatriculasDGV);
        FeedbackLBL.Text = feedback.feedback;
        int count = MatriculasDGV.Rows.Cast<DataGridViewRow>()
                    .Count(linha => !linha.IsNewRow &&
                    Convert.ToBoolean(linha.Cells["[X]"].Value) &&
                    !string.IsNullOrEmpty(linha.Cells["Unidade"].Value?.ToString()));

        ConfirmarBTN.Enabled = count > 0 ? true : false;
    }

    /// <summary>
    /// Fecha a tela de inmportação de matrículas
    /// </summary>
    private void CancelarBTN_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ConfirmarBTN_Click(object sender, EventArgs e)
    {
        List<MatriculaDTO> matriculas = [];
        foreach (DataGridViewRow row in MatriculasDGV.Rows)
        {
            if (Convert.ToBoolean(row.Cells["[X]"].Value)) matriculas.Add(Matriculas.FirstOrDefault(x => x.Cpf.Equals(row.Cells["Cpf"].Value)));
        }
        TelaPrincipal.Matriculas = matriculas;
        TelaPrincipal.MatriculasSelecionadasDGV.DataSource = TelaPrincipal.Matriculas;
        TelaPrincipal.Certificados = Auxiliares.IdentificarMatriculasComCertificado(TelaPrincipal.MatriculasSelecionadasDGV, Certificados);
        FormatacaoCommon.FormatarDgv(TelaPrincipal.MatriculasSelecionadasDGV);
        Auxiliares.IdentificarEmailsEnviados(TelaPrincipal.MatriculasSelecionadasDGV, new());
        TelaPrincipal.Diretorio = DiretorioCertificadosTXT.Text != string.Empty ? DiretorioCertificadosTXT.Text : Path.GetDirectoryName(DiretorioMatriculasTXT.Text);
        Close();
    }

    private void LimparBTN_Click(object sender, EventArgs e)
    {
        if (MatriculasDGV.Rows.Count > 0) Matriculas.Clear();
        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK.Checked, MatriculasDGV, Matriculas, Certificados, FeedbackLBL);
        if (MatriculasDGV.Columns.Contains("[X]")) MatriculasDGV.Columns["[X]"].Frozen = true;
    }

    private void ImportarMatriculasView_Load(object sender, EventArgs e)
    {
        ImportarCertificadosBTN.Enabled = false;
        ConfirmarBTN.Enabled = false;
        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK.Checked, MatriculasDGV, Matriculas, Certificados, FeedbackLBL);
        if (MatriculasDGV.Columns.Contains("[X]")) MatriculasDGV.Columns["[X]"].Frozen = true;
    }

    private void PesquisarTXT_TextChanged(object sender, EventArgs e)
    {
        var filtro = Matriculas.Where(x => x.Aluno.ToLower().Contains(PesquisarTXT.Text.ToLower()) ||
                                          x.Cpf.Contains(PesquisarTXT.Text) ||
                                          x.Email.ToLower().Contains(PesquisarTXT.Text.ToLower())).ToList();

        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK.Checked, MatriculasDGV, filtro, Certificados, FeedbackLBL);
    }
}
