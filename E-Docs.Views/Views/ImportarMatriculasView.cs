using E_Docs.Presenter.DTOs;
using E_Docs.Views.Common;
using E_Docs.Views.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (retorno.logs.Count > 0)
            {
                ExcecoesView excecoesView = new();
                var contador = 1;
                foreach (var log in retorno.logs)
                {
                    if (contador == 1) excecoesView.Text = log.GetMensagem().titulo;
                    if (contador == 1) excecoesView.MensagemErroLBL.Text = log.GetMensagem().mensagem;
                    excecoesView.InformacoesBasicasTXT.Text += log.GetMensagem().informacoesBasicas;
                    excecoesView.InformacoesTecnicasTXT.Text += log.GetMensagem().informacoesTecnicas;
                    contador++;
                }
                excecoesView.ShowDialog();
            }

            if (retorno.matriculas.Count == 0 && retorno.logs.Count > 0)
            {
                DiretorioMatriculasTXT.Text = string.Empty;
            }
            else
            {
                Matriculas = retorno.matriculas;
                Certificados.Clear();
                DiretorioCertificadosTXT.Text = string.Empty;
                // Carrega a imagem de pendente para todos os registros de matrículas
                foreach (DataGridViewRow row in MatriculasDGV.Rows) row.Cells["Certificado"].Value = Properties.Resources.PendenteVermelho;
                // Carrega os certificados identificados na importação da matrícula, se houver
                Certificados = retorno.certificados;
            }
            // Se forem encontrados certificados vinculados às matrículas importadas, carrega-os no datagridview
            if (Certificados.Count > 0) Auxiliares.IdentificarMatriculasComCertificado(MatriculasDGV, Certificados);

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
            var retorno = ImportarCertificadosService.ImportarCertificados(DiretorioCertificadosTXT.Text, ConfiguracaoCommon.pswd(), Matriculas);
            Certificados = retorno.certificados ?? Certificados;

            if (retorno.logs.Count > 0)
            {
                ExcecoesView excecoesView = new();
                var contador = 1;
                foreach (var log in retorno.logs)
                {
                    if (contador == 1) excecoesView.Text = log.GetMensagem().titulo;
                    if (contador == 1) excecoesView.MensagemErroLBL.Text = log.GetMensagem().mensagem;
                    excecoesView.InformacoesBasicasTXT.Text += log.GetMensagem().informacoesBasicas;
                    excecoesView.InformacoesTecnicasTXT.Text += log.GetMensagem().informacoesTecnicas;
                    contador++;
                }
                excecoesView.ShowDialog();
            }

            if (Certificados.Count == 0 && retorno.logs.Count > 0)
            {
                DiretorioCertificadosTXT.Text = string.Empty;
            }
            else
            {
                Auxiliares.IdentificarMatriculasComCertificado(MatriculasDGV, Certificados);
            }
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
    /// Executa as ações relacioandas ao evento de abertura do formulário
    /// </summary>
    private void ImportarMatriculasView_Load(object sender, EventArgs e)
    {
        ImportarCertificadosBTN.Enabled = false;
        ConfirmarBTN.Enabled = false;
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
        Auxiliares.FiltrarMatriculas(ApenasComCertificadosCHK, MatriculasDGV, Matriculas, Certificados, FeedbackLBL);
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

        if (count > 0)
        {
            ConfirmarBTN.Enabled = true;
        }
        else
        {
            ConfirmarBTN.Enabled = false;
        }
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
        TelaPrincipal.Dt = Conversao.ConvertDataGridViewToDataTable(MatriculasDGV);
        TelaPrincipal.MatriculasSelecionadasDGV.DataSource = TelaPrincipal.Dt;
        FormatacaoCommon.FormatarDgv(TelaPrincipal.MatriculasSelecionadasDGV);
        Close();
    }
}
