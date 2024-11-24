using System.Windows.Forms;

namespace E_Docs.Views.Views;

partial class ImportarMatriculasView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        OrietacaoImportacaoLBL = new Label();
        ImagemSelecaoArquivoIMG = new PictureBox();
        OrientacoesGBX = new GroupBox();
        ImportacaoGBX = new GroupBox();
        MatriculasGBX = new GroupBox();
        MatriculasDGV = new DataGridView();
        PainelOpcoesPNL = new Panel();
        ApenasComCertificadosCHK = new CheckBox();
        panel1 = new Panel();
        DiretorioMatriculasLBL = new Label();
        DiretorioMatriculasTXT = new TextBox();
        ImportarCertificadosBTN = new Button();
        DiretorioCertificadosTXT = new TextBox();
        ImportarMatriculasBTN = new Button();
        DiretorioCertificadosLBL = new Label();
        BarraFerramentasTST = new ToolStrip();
        CancelarBTN = new ToolStripButton();
        ConfirmarBTN = new ToolStripButton();
        FeedbackLBL = new ToolStripLabel();
        ((System.ComponentModel.ISupportInitialize)ImagemSelecaoArquivoIMG).BeginInit();
        OrientacoesGBX.SuspendLayout();
        ImportacaoGBX.SuspendLayout();
        MatriculasGBX.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)MatriculasDGV).BeginInit();
        PainelOpcoesPNL.SuspendLayout();
        panel1.SuspendLayout();
        BarraFerramentasTST.SuspendLayout();
        SuspendLayout();
        // 
        // OrietacaoImportacaoLBL
        // 
        OrietacaoImportacaoLBL.Dock = DockStyle.Fill;
        OrietacaoImportacaoLBL.Location = new System.Drawing.Point(105, 21);
        OrietacaoImportacaoLBL.Name = "OrietacaoImportacaoLBL";
        OrietacaoImportacaoLBL.Padding = new Padding(10);
        OrietacaoImportacaoLBL.Size = new System.Drawing.Size(545, 96);
        OrietacaoImportacaoLBL.TabIndex = 0;
        OrietacaoImportacaoLBL.Text = "Selecione o local onde estão armazenados a lista de matrículados e os Certificados para ajuste e envio.";
        OrietacaoImportacaoLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ImagemSelecaoArquivoIMG
        // 
        ImagemSelecaoArquivoIMG.BackColor = System.Drawing.SystemColors.ControlLight;
        ImagemSelecaoArquivoIMG.Dock = DockStyle.Left;
        ImagemSelecaoArquivoIMG.Image = Properties.Resources.ImportarVerde;
        ImagemSelecaoArquivoIMG.Location = new System.Drawing.Point(5, 21);
        ImagemSelecaoArquivoIMG.Name = "ImagemSelecaoArquivoIMG";
        ImagemSelecaoArquivoIMG.Size = new System.Drawing.Size(100, 96);
        ImagemSelecaoArquivoIMG.SizeMode = PictureBoxSizeMode.Zoom;
        ImagemSelecaoArquivoIMG.TabIndex = 1;
        ImagemSelecaoArquivoIMG.TabStop = false;
        // 
        // OrientacoesGBX
        // 
        OrientacoesGBX.BackColor = System.Drawing.SystemColors.ControlLight;
        OrientacoesGBX.Controls.Add(OrietacaoImportacaoLBL);
        OrientacoesGBX.Controls.Add(ImagemSelecaoArquivoIMG);
        OrientacoesGBX.Dock = DockStyle.Top;
        OrientacoesGBX.Location = new System.Drawing.Point(5, 5);
        OrientacoesGBX.Name = "OrientacoesGBX";
        OrientacoesGBX.Padding = new Padding(5);
        OrientacoesGBX.Size = new System.Drawing.Size(655, 122);
        OrientacoesGBX.TabIndex = 2;
        OrientacoesGBX.TabStop = false;
        OrientacoesGBX.Text = "Seleção dos Arquivos";
        // 
        // ImportacaoGBX
        // 
        ImportacaoGBX.Controls.Add(MatriculasGBX);
        ImportacaoGBX.Controls.Add(panel1);
        ImportacaoGBX.Dock = DockStyle.Fill;
        ImportacaoGBX.Location = new System.Drawing.Point(5, 127);
        ImportacaoGBX.Name = "ImportacaoGBX";
        ImportacaoGBX.Size = new System.Drawing.Size(655, 462);
        ImportacaoGBX.TabIndex = 3;
        ImportacaoGBX.TabStop = false;
        ImportacaoGBX.Text = "Importação";
        // 
        // MatriculasGBX
        // 
        MatriculasGBX.Controls.Add(MatriculasDGV);
        MatriculasGBX.Controls.Add(PainelOpcoesPNL);
        MatriculasGBX.Dock = DockStyle.Fill;
        MatriculasGBX.Location = new System.Drawing.Point(3, 110);
        MatriculasGBX.Name = "MatriculasGBX";
        MatriculasGBX.Size = new System.Drawing.Size(649, 349);
        MatriculasGBX.TabIndex = 10;
        MatriculasGBX.TabStop = false;
        MatriculasGBX.Text = "Matrículas";
        // 
        // MatriculasDGV
        // 
        MatriculasDGV.AllowUserToAddRows = false;
        MatriculasDGV.AllowUserToDeleteRows = false;
        MatriculasDGV.BackgroundColor = System.Drawing.SystemColors.Control;
        MatriculasDGV.BorderStyle = BorderStyle.Fixed3D;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        MatriculasDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        MatriculasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        MatriculasDGV.DefaultCellStyle = dataGridViewCellStyle2;
        MatriculasDGV.Dock = DockStyle.Fill;
        MatriculasDGV.Location = new System.Drawing.Point(3, 44);
        MatriculasDGV.Name = "MatriculasDGV";
        MatriculasDGV.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        MatriculasDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        MatriculasDGV.RowHeadersVisible = false;
        MatriculasDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
        MatriculasDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        MatriculasDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        MatriculasDGV.Size = new System.Drawing.Size(643, 302);
        MatriculasDGV.TabIndex = 7;
        MatriculasDGV.CellClick += MatriculasDGV_CellClick;
        MatriculasDGV.ColumnHeaderMouseClick += MatriculasDGV_ColumnHeaderMouseClick;
        // 
        // PainelOpcoesPNL
        // 
        PainelOpcoesPNL.Controls.Add(ApenasComCertificadosCHK);
        PainelOpcoesPNL.Dock = DockStyle.Top;
        PainelOpcoesPNL.Location = new System.Drawing.Point(3, 19);
        PainelOpcoesPNL.Name = "PainelOpcoesPNL";
        PainelOpcoesPNL.Padding = new Padding(10, 0, 0, 0);
        PainelOpcoesPNL.Size = new System.Drawing.Size(643, 25);
        PainelOpcoesPNL.TabIndex = 8;
        // 
        // ApenasComCertificadosCHK
        // 
        ApenasComCertificadosCHK.Dock = DockStyle.Left;
        ApenasComCertificadosCHK.Location = new System.Drawing.Point(10, 0);
        ApenasComCertificadosCHK.Name = "ApenasComCertificadosCHK";
        ApenasComCertificadosCHK.Size = new System.Drawing.Size(251, 25);
        ApenasComCertificadosCHK.TabIndex = 0;
        ApenasComCertificadosCHK.Text = "Exibir apenas matriculas com Certificados";
        ApenasComCertificadosCHK.UseVisualStyleBackColor = true;
        ApenasComCertificadosCHK.CheckedChanged += ApenasComCertificadosCHK_CheckedChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(DiretorioMatriculasLBL);
        panel1.Controls.Add(DiretorioMatriculasTXT);
        panel1.Controls.Add(ImportarCertificadosBTN);
        panel1.Controls.Add(DiretorioCertificadosTXT);
        panel1.Controls.Add(ImportarMatriculasBTN);
        panel1.Controls.Add(DiretorioCertificadosLBL);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new System.Drawing.Point(3, 19);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(649, 91);
        panel1.TabIndex = 9;
        // 
        // DiretorioMatriculasLBL
        // 
        DiretorioMatriculasLBL.AutoSize = true;
        DiretorioMatriculasLBL.Location = new System.Drawing.Point(3, 0);
        DiretorioMatriculasLBL.Name = "DiretorioMatriculasLBL";
        DiretorioMatriculasLBL.Size = new System.Drawing.Size(170, 15);
        DiretorioMatriculasLBL.TabIndex = 2;
        DiretorioMatriculasLBL.Text = "Local da Planilha de Matrículas";
        // 
        // DiretorioMatriculasTXT
        // 
        DiretorioMatriculasTXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        DiretorioMatriculasTXT.Location = new System.Drawing.Point(4, 18);
        DiretorioMatriculasTXT.Name = "DiretorioMatriculasTXT";
        DiretorioMatriculasTXT.ReadOnly = true;
        DiretorioMatriculasTXT.Size = new System.Drawing.Size(613, 23);
        DiretorioMatriculasTXT.TabIndex = 0;
        DiretorioMatriculasTXT.TextChanged += DiretorioMatriculasTXT_TextChanged;
        // 
        // ImportarCertificadosBTN
        // 
        ImportarCertificadosBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        ImportarCertificadosBTN.BackgroundImage = Properties.Resources.ProcurarVerde;
        ImportarCertificadosBTN.BackgroundImageLayout = ImageLayout.Zoom;
        ImportarCertificadosBTN.Location = new System.Drawing.Point(617, 61);
        ImportarCertificadosBTN.Name = "ImportarCertificadosBTN";
        ImportarCertificadosBTN.Size = new System.Drawing.Size(26, 25);
        ImportarCertificadosBTN.TabIndex = 5;
        ImportarCertificadosBTN.UseVisualStyleBackColor = true;
        ImportarCertificadosBTN.Click += ImportarCertificadosBTN_Click;
        // 
        // DiretorioCertificadosTXT
        // 
        DiretorioCertificadosTXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        DiretorioCertificadosTXT.Location = new System.Drawing.Point(4, 62);
        DiretorioCertificadosTXT.Name = "DiretorioCertificadosTXT";
        DiretorioCertificadosTXT.ReadOnly = true;
        DiretorioCertificadosTXT.Size = new System.Drawing.Size(613, 23);
        DiretorioCertificadosTXT.TabIndex = 1;
        // 
        // ImportarMatriculasBTN
        // 
        ImportarMatriculasBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        ImportarMatriculasBTN.BackgroundImage = Properties.Resources.ProcurarVerde;
        ImportarMatriculasBTN.BackgroundImageLayout = ImageLayout.Zoom;
        ImportarMatriculasBTN.Location = new System.Drawing.Point(617, 17);
        ImportarMatriculasBTN.Name = "ImportarMatriculasBTN";
        ImportarMatriculasBTN.Size = new System.Drawing.Size(26, 25);
        ImportarMatriculasBTN.TabIndex = 4;
        ImportarMatriculasBTN.UseVisualStyleBackColor = true;
        ImportarMatriculasBTN.Click += ImportarMatriculasBTN_Click;
        // 
        // DiretorioCertificadosLBL
        // 
        DiretorioCertificadosLBL.AutoSize = true;
        DiretorioCertificadosLBL.Location = new System.Drawing.Point(4, 44);
        DiretorioCertificadosLBL.Name = "DiretorioCertificadosLBL";
        DiretorioCertificadosLBL.Size = new System.Drawing.Size(123, 15);
        DiretorioCertificadosLBL.TabIndex = 3;
        DiretorioCertificadosLBL.Text = "Local dos Certificados";
        // 
        // BarraFerramentasTST
        // 
        BarraFerramentasTST.Dock = DockStyle.Bottom;
        BarraFerramentasTST.Items.AddRange(new ToolStripItem[] { CancelarBTN, ConfirmarBTN, FeedbackLBL });
        BarraFerramentasTST.Location = new System.Drawing.Point(5, 589);
        BarraFerramentasTST.Name = "BarraFerramentasTST";
        BarraFerramentasTST.Size = new System.Drawing.Size(655, 25);
        BarraFerramentasTST.TabIndex = 4;
        BarraFerramentasTST.Text = "toolStrip1";
        // 
        // CancelarBTN
        // 
        CancelarBTN.Alignment = ToolStripItemAlignment.Right;
        CancelarBTN.Image = Properties.Resources.CancelarVermelho;
        CancelarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        CancelarBTN.Name = "CancelarBTN";
        CancelarBTN.Size = new System.Drawing.Size(73, 22);
        CancelarBTN.Text = "Cancelar";
        CancelarBTN.Click += CancelarBTN_Click;
        // 
        // ConfirmarBTN
        // 
        ConfirmarBTN.Alignment = ToolStripItemAlignment.Right;
        ConfirmarBTN.Image = Properties.Resources.ConfirmarVerde;
        ConfirmarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        ConfirmarBTN.Name = "ConfirmarBTN";
        ConfirmarBTN.Size = new System.Drawing.Size(81, 22);
        ConfirmarBTN.Text = "Confirmar";
        ConfirmarBTN.Click += ConfirmarBTN_Click;
        // 
        // FeedbackLBL
        // 
        FeedbackLBL.Name = "FeedbackLBL";
        FeedbackLBL.Size = new System.Drawing.Size(150, 22);
        FeedbackLBL.Text = "Registros Selecionados: 0/0";
        // 
        // ImportarMatriculasView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(665, 619);
        Controls.Add(ImportacaoGBX);
        Controls.Add(OrientacoesGBX);
        Controls.Add(BarraFerramentasTST);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "ImportarMatriculasView";
        Padding = new Padding(5);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CertFlow - Importar Matriculas";
        Activated += ImportarMatriculasView_Activated;
        ((System.ComponentModel.ISupportInitialize)ImagemSelecaoArquivoIMG).EndInit();
        OrientacoesGBX.ResumeLayout(false);
        ImportacaoGBX.ResumeLayout(false);
        MatriculasGBX.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)MatriculasDGV).EndInit();
        PainelOpcoesPNL.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        BarraFerramentasTST.ResumeLayout(false);
        BarraFerramentasTST.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label OrietacaoImportacaoLBL;
    private PictureBox ImagemSelecaoArquivoIMG;
    private GroupBox OrientacoesGBX;
    private GroupBox ImportacaoGBX;
    private Label DiretorioCertificadosLBL;
    private Label DiretorioMatriculasLBL;
    private TextBox DiretorioCertificadosTXT;
    private TextBox DiretorioMatriculasTXT;
    private Button ImportarCertificadosBTN;
    private Button ImportarMatriculasBTN;
    private DataGridView MatriculasDGV;
    private Panel panel1;
    private ToolStrip BarraFerramentasTST;
    private ToolStripButton ConfirmarBTN;
    private ToolStripButton CancelarBTN;
    private ToolStripLabel FeedbackLBL;
    private GroupBox MatriculasGBX;
    private Panel PainelOpcoesPNL;
    private CheckBox ApenasComCertificadosCHK;
}