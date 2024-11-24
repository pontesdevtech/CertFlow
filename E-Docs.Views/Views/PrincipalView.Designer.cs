using System.Windows.Forms;

namespace E_Docs.Views;

partial class PrincipalView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalView));
        MatriculasSelecionadasDGV = new DataGridView();
        MatriculasGBX = new GroupBox();
        PainelOpcoesPNL = new Panel();
        BarraFerramentasMatriculasTST = new ToolStrip();
        PesquisarLBL = new ToolStripLabel();
        PesquisarTXT = new ToolStripTextBox();
        LimparBTN = new ToolStripButton();
        ApenasComCertificadosCHK = new CheckBox();
        BarraStatusFeedback = new StatusStrip();
        FeedbackLBL = new ToolStripStatusLabel();
        InformacoesGBX = new GroupBox();
        EmailTXT = new TextBox();
        EmailLBL = new Label();
        CpfTXT = new TextBox();
        AlunoTXT = new TextBox();
        AlunoLBL = new Label();
        CpfLBL = new Label();
        TurmaTXT = new TextBox();
        TurmaLBL = new Label();
        CursoTXT = new TextBox();
        CursoLBL = new Label();
        BarraFerramentasPrincipalTST = new ToolStrip();
        ImportarMatriculasBTN = new ToolStripButton();
        EnviarCertificadosBTN = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        ExportarRelatorioCBX = new ToolStripDropDownButton();
        PdfBTN = new ToolStripMenuItem();
        XlsxBTN = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)MatriculasSelecionadasDGV).BeginInit();
        MatriculasGBX.SuspendLayout();
        PainelOpcoesPNL.SuspendLayout();
        BarraFerramentasMatriculasTST.SuspendLayout();
        BarraStatusFeedback.SuspendLayout();
        InformacoesGBX.SuspendLayout();
        BarraFerramentasPrincipalTST.SuspendLayout();
        SuspendLayout();
        // 
        // MatriculasSelecionadasDGV
        // 
        MatriculasSelecionadasDGV.AllowUserToAddRows = false;
        MatriculasSelecionadasDGV.AllowUserToDeleteRows = false;
        MatriculasSelecionadasDGV.BackgroundColor = System.Drawing.SystemColors.Control;
        MatriculasSelecionadasDGV.BorderStyle = BorderStyle.Fixed3D;
        MatriculasSelecionadasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MatriculasSelecionadasDGV.Dock = DockStyle.Fill;
        MatriculasSelecionadasDGV.Location = new System.Drawing.Point(3, 52);
        MatriculasSelecionadasDGV.Name = "MatriculasSelecionadasDGV";
        MatriculasSelecionadasDGV.ReadOnly = true;
        MatriculasSelecionadasDGV.RowHeadersVisible = false;
        MatriculasSelecionadasDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
        MatriculasSelecionadasDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        MatriculasSelecionadasDGV.Size = new System.Drawing.Size(853, 458);
        MatriculasSelecionadasDGV.TabIndex = 0;
        MatriculasSelecionadasDGV.CellClick += MatriculasSelecionadasDGV_CellClick;
        MatriculasSelecionadasDGV.CellEnter += MatriculasSelecionadasDGV_CellEnter;
        MatriculasSelecionadasDGV.ColumnHeaderMouseClick += MatriculasSelecionadasDGV_ColumnHeaderMouseClick;
        // 
        // MatriculasGBX
        // 
        MatriculasGBX.Controls.Add(MatriculasSelecionadasDGV);
        MatriculasGBX.Controls.Add(PainelOpcoesPNL);
        MatriculasGBX.Controls.Add(BarraStatusFeedback);
        MatriculasGBX.Dock = DockStyle.Fill;
        MatriculasGBX.Location = new System.Drawing.Point(5, 151);
        MatriculasGBX.Name = "MatriculasGBX";
        MatriculasGBX.Size = new System.Drawing.Size(859, 535);
        MatriculasGBX.TabIndex = 1;
        MatriculasGBX.TabStop = false;
        MatriculasGBX.Text = "Matrículas";
        // 
        // PainelOpcoesPNL
        // 
        PainelOpcoesPNL.BackColor = System.Drawing.SystemColors.ControlLight;
        PainelOpcoesPNL.Controls.Add(BarraFerramentasMatriculasTST);
        PainelOpcoesPNL.Controls.Add(ApenasComCertificadosCHK);
        PainelOpcoesPNL.Dock = DockStyle.Top;
        PainelOpcoesPNL.Location = new System.Drawing.Point(3, 19);
        PainelOpcoesPNL.Name = "PainelOpcoesPNL";
        PainelOpcoesPNL.Padding = new Padding(10, 3, 10, 3);
        PainelOpcoesPNL.Size = new System.Drawing.Size(853, 33);
        PainelOpcoesPNL.TabIndex = 9;
        // 
        // BarraFerramentasMatriculasTST
        // 
        BarraFerramentasMatriculasTST.BackColor = System.Drawing.SystemColors.ControlLight;
        BarraFerramentasMatriculasTST.Dock = DockStyle.Fill;
        BarraFerramentasMatriculasTST.Items.AddRange(new ToolStripItem[] { PesquisarLBL, PesquisarTXT, LimparBTN });
        BarraFerramentasMatriculasTST.Location = new System.Drawing.Point(10, 3);
        BarraFerramentasMatriculasTST.Name = "BarraFerramentasMatriculasTST";
        BarraFerramentasMatriculasTST.Padding = new Padding(0, 0, 10, 0);
        BarraFerramentasMatriculasTST.Size = new System.Drawing.Size(582, 27);
        BarraFerramentasMatriculasTST.TabIndex = 1;
        BarraFerramentasMatriculasTST.Text = "Limpar";
        // 
        // PesquisarLBL
        // 
        PesquisarLBL.Image = Properties.Resources.ProcurarVerde;
        PesquisarLBL.ImageTransparentColor = System.Drawing.Color.Magenta;
        PesquisarLBL.Name = "PesquisarLBL";
        PesquisarLBL.Size = new System.Drawing.Size(73, 24);
        PesquisarLBL.Text = "Pesquisar";
        // 
        // PesquisarTXT
        // 
        PesquisarTXT.Name = "PesquisarTXT";
        PesquisarTXT.Size = new System.Drawing.Size(300, 27);
        // 
        // LimparBTN
        // 
        LimparBTN.Alignment = ToolStripItemAlignment.Right;
        LimparBTN.Image = Properties.Resources.LimparVermelho;
        LimparBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        LimparBTN.Name = "LimparBTN";
        LimparBTN.Size = new System.Drawing.Size(64, 24);
        LimparBTN.Text = "Limpar";
        LimparBTN.Click += LimparBTN_Click;
        // 
        // ApenasComCertificadosCHK
        // 
        ApenasComCertificadosCHK.Dock = DockStyle.Right;
        ApenasComCertificadosCHK.Location = new System.Drawing.Point(592, 3);
        ApenasComCertificadosCHK.Name = "ApenasComCertificadosCHK";
        ApenasComCertificadosCHK.Size = new System.Drawing.Size(251, 27);
        ApenasComCertificadosCHK.TabIndex = 0;
        ApenasComCertificadosCHK.Text = "Exibir apenas matriculas com Certificados";
        ApenasComCertificadosCHK.UseVisualStyleBackColor = true;
        ApenasComCertificadosCHK.CheckedChanged += ApenasComCertificadosCHK_CheckedChanged;
        // 
        // BarraStatusFeedback
        // 
        BarraStatusFeedback.Items.AddRange(new ToolStripItem[] { FeedbackLBL });
        BarraStatusFeedback.Location = new System.Drawing.Point(3, 510);
        BarraStatusFeedback.Name = "BarraStatusFeedback";
        BarraStatusFeedback.Size = new System.Drawing.Size(853, 22);
        BarraStatusFeedback.TabIndex = 2;
        BarraStatusFeedback.Text = "statusStrip1";
        // 
        // FeedbackLBL
        // 
        FeedbackLBL.Name = "FeedbackLBL";
        FeedbackLBL.Size = new System.Drawing.Size(126, 17);
        FeedbackLBL.Text = "Total de Registros: 0     ";
        // 
        // InformacoesGBX
        // 
        InformacoesGBX.Controls.Add(EmailTXT);
        InformacoesGBX.Controls.Add(EmailLBL);
        InformacoesGBX.Controls.Add(CpfTXT);
        InformacoesGBX.Controls.Add(AlunoTXT);
        InformacoesGBX.Controls.Add(AlunoLBL);
        InformacoesGBX.Controls.Add(CpfLBL);
        InformacoesGBX.Controls.Add(TurmaTXT);
        InformacoesGBX.Controls.Add(TurmaLBL);
        InformacoesGBX.Controls.Add(CursoTXT);
        InformacoesGBX.Controls.Add(CursoLBL);
        InformacoesGBX.Dock = DockStyle.Top;
        InformacoesGBX.Location = new System.Drawing.Point(5, 30);
        InformacoesGBX.Name = "InformacoesGBX";
        InformacoesGBX.Size = new System.Drawing.Size(859, 121);
        InformacoesGBX.TabIndex = 2;
        InformacoesGBX.TabStop = false;
        InformacoesGBX.Text = "Informações da Matrícula";
        // 
        // EmailTXT
        // 
        EmailTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        EmailTXT.Location = new System.Drawing.Point(608, 84);
        EmailTXT.Name = "EmailTXT";
        EmailTXT.Size = new System.Drawing.Size(244, 23);
        EmailTXT.TabIndex = 12;
        // 
        // EmailLBL
        // 
        EmailLBL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        EmailLBL.AutoSize = true;
        EmailLBL.Location = new System.Drawing.Point(608, 66);
        EmailLBL.Name = "EmailLBL";
        EmailLBL.Size = new System.Drawing.Size(36, 15);
        EmailLBL.TabIndex = 11;
        EmailLBL.Text = "Email";
        // 
        // CpfTXT
        // 
        CpfTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        CpfTXT.Location = new System.Drawing.Point(468, 84);
        CpfTXT.Name = "CpfTXT";
        CpfTXT.Size = new System.Drawing.Size(134, 23);
        CpfTXT.TabIndex = 10;
        // 
        // AlunoTXT
        // 
        AlunoTXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        AlunoTXT.Location = new System.Drawing.Point(6, 84);
        AlunoTXT.Name = "AlunoTXT";
        AlunoTXT.Size = new System.Drawing.Size(456, 23);
        AlunoTXT.TabIndex = 9;
        // 
        // AlunoLBL
        // 
        AlunoLBL.AutoSize = true;
        AlunoLBL.Location = new System.Drawing.Point(6, 66);
        AlunoLBL.Name = "AlunoLBL";
        AlunoLBL.Size = new System.Drawing.Size(39, 15);
        AlunoLBL.TabIndex = 8;
        AlunoLBL.Text = "Aluno";
        // 
        // CpfLBL
        // 
        CpfLBL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        CpfLBL.AutoSize = true;
        CpfLBL.Location = new System.Drawing.Point(468, 66);
        CpfLBL.Name = "CpfLBL";
        CpfLBL.Size = new System.Drawing.Size(28, 15);
        CpfLBL.TabIndex = 6;
        CpfLBL.Text = "CPF";
        // 
        // TurmaTXT
        // 
        TurmaTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        TurmaTXT.Location = new System.Drawing.Point(727, 40);
        TurmaTXT.Name = "TurmaTXT";
        TurmaTXT.Size = new System.Drawing.Size(125, 23);
        TurmaTXT.TabIndex = 5;
        // 
        // TurmaLBL
        // 
        TurmaLBL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        TurmaLBL.AutoSize = true;
        TurmaLBL.Location = new System.Drawing.Point(727, 22);
        TurmaLBL.Name = "TurmaLBL";
        TurmaLBL.Size = new System.Drawing.Size(41, 15);
        TurmaLBL.TabIndex = 4;
        TurmaLBL.Text = "Turma";
        // 
        // CursoTXT
        // 
        CursoTXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CursoTXT.Location = new System.Drawing.Point(6, 40);
        CursoTXT.Name = "CursoTXT";
        CursoTXT.Size = new System.Drawing.Size(715, 23);
        CursoTXT.TabIndex = 3;
        // 
        // CursoLBL
        // 
        CursoLBL.AutoSize = true;
        CursoLBL.Location = new System.Drawing.Point(6, 22);
        CursoLBL.Name = "CursoLBL";
        CursoLBL.Size = new System.Drawing.Size(38, 15);
        CursoLBL.TabIndex = 2;
        CursoLBL.Text = "Curso";
        // 
        // BarraFerramentasPrincipalTST
        // 
        BarraFerramentasPrincipalTST.BackColor = System.Drawing.SystemColors.ControlLight;
        BarraFerramentasPrincipalTST.Items.AddRange(new ToolStripItem[] { ImportarMatriculasBTN, EnviarCertificadosBTN, toolStripSeparator2, ExportarRelatorioCBX });
        BarraFerramentasPrincipalTST.Location = new System.Drawing.Point(5, 5);
        BarraFerramentasPrincipalTST.Name = "BarraFerramentasPrincipalTST";
        BarraFerramentasPrincipalTST.Size = new System.Drawing.Size(859, 25);
        BarraFerramentasPrincipalTST.TabIndex = 3;
        BarraFerramentasPrincipalTST.Text = "toolStrip1";
        // 
        // ImportarMatriculasBTN
        // 
        ImportarMatriculasBTN.Image = Properties.Resources.ImportarVerde;
        ImportarMatriculasBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        ImportarMatriculasBTN.Name = "ImportarMatriculasBTN";
        ImportarMatriculasBTN.Size = new System.Drawing.Size(131, 22);
        ImportarMatriculasBTN.Text = "Importar Matrículas";
        ImportarMatriculasBTN.Click += ImportarMatriculasBTN_Click;
        // 
        // EnviarCertificadosBTN
        // 
        EnviarCertificadosBTN.Image = Properties.Resources.EmailVerde;
        EnviarCertificadosBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        EnviarCertificadosBTN.Name = "EnviarCertificadosBTN";
        EnviarCertificadosBTN.Size = new System.Drawing.Size(125, 22);
        EnviarCertificadosBTN.Text = "Enviar Certificados";
        EnviarCertificadosBTN.Click += EnviarCertificadosBTN_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
        // 
        // ExportarRelatorioCBX
        // 
        ExportarRelatorioCBX.DropDownItems.AddRange(new ToolStripItem[] { PdfBTN, XlsxBTN });
        ExportarRelatorioCBX.Image = Properties.Resources.RelatorioVerde;
        ExportarRelatorioCBX.ImageTransparentColor = System.Drawing.Color.Magenta;
        ExportarRelatorioCBX.Name = "ExportarRelatorioCBX";
        ExportarRelatorioCBX.Size = new System.Drawing.Size(130, 22);
        ExportarRelatorioCBX.Text = "Exportar Relatório";
        // 
        // PdfBTN
        // 
        PdfBTN.Name = "PdfBTN";
        PdfBTN.Size = new System.Drawing.Size(100, 22);
        PdfBTN.Text = "PDF";
        // 
        // XlsxBTN
        // 
        XlsxBTN.Name = "XlsxBTN";
        XlsxBTN.Size = new System.Drawing.Size(100, 22);
        XlsxBTN.Text = "XLSX";
        // 
        // PrincipalView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(869, 691);
        Controls.Add(MatriculasGBX);
        Controls.Add(InformacoesGBX);
        Controls.Add(BarraFerramentasPrincipalTST);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "PrincipalView";
        Padding = new Padding(5);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CertFlow - Fluxo de Preparação e Envio de Certificados Digitais";
        Load += PrincipalView_Load;
        ((System.ComponentModel.ISupportInitialize)MatriculasSelecionadasDGV).EndInit();
        MatriculasGBX.ResumeLayout(false);
        MatriculasGBX.PerformLayout();
        PainelOpcoesPNL.ResumeLayout(false);
        PainelOpcoesPNL.PerformLayout();
        BarraFerramentasMatriculasTST.ResumeLayout(false);
        BarraFerramentasMatriculasTST.PerformLayout();
        BarraStatusFeedback.ResumeLayout(false);
        BarraStatusFeedback.PerformLayout();
        InformacoesGBX.ResumeLayout(false);
        InformacoesGBX.PerformLayout();
        BarraFerramentasPrincipalTST.ResumeLayout(false);
        BarraFerramentasPrincipalTST.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private GroupBox MatriculasGBX;
    private GroupBox InformacoesGBX;
    private ToolStrip BarraFerramentasPrincipalTST;
    private ToolStripButton ImportarMatriculasBTN;
    private ToolStripButton EnviarCertificadosBTN;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripDropDownButton ExportarRelatorioCBX;
    private ToolStripMenuItem PdfBTN;
    private ToolStripMenuItem XlsxBTN;
    private ToolStrip BarraFerramentasMatriculasTST;
    private ToolStripLabel PesquisarLBL;
    private ToolStripTextBox PesquisarTXT;
    private StatusStrip BarraStatusFeedback;
    private ToolStripStatusLabel FeedbackLBL;
    private TextBox CursoTXT;
    private Label CursoLBL;
    private TextBox AlunoTXT;
    private Label AlunoLBL;
    private Label CpfLBL;
    private TextBox TurmaTXT;
    private Label TurmaLBL;
    private TextBox CpfTXT;
    private TextBox EmailTXT;
    private Label EmailLBL;
    public DataGridView MatriculasSelecionadasDGV;
    private Panel PainelOpcoesPNL;
    private CheckBox ApenasComCertificadosCHK;
    private ToolStripButton LimparBTN;
}
