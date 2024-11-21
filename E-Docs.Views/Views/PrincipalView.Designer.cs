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
        BarraStatusFeedback = new StatusStrip();
        FeedbackLBL = new ToolStripStatusLabel();
        BarraFerramentasMatriculasTST = new ToolStrip();
        PesquisarLBL = new ToolStripLabel();
        PesquisarTXT = new ToolStripTextBox();
        InformacoesGBX = new GroupBox();
        BarraFerramentasInformacoesTST = new ToolStrip();
        ErroBTN = new ToolStripButton();
        CertificadoBTN = new ToolStripButton();
        UnidadeLBL = new ToolStripLabel();
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
        LogoLBL = new ToolStripLabel();
        toolStripSeparator1 = new ToolStripSeparator();
        ImportarMatriculasBTN = new ToolStripButton();
        EnviarCertificadosBTN = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        ExportarRelatorioCBX = new ToolStripDropDownButton();
        PdfBTN = new ToolStripMenuItem();
        XlsxBTN = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)MatriculasSelecionadasDGV).BeginInit();
        MatriculasGBX.SuspendLayout();
        BarraStatusFeedback.SuspendLayout();
        BarraFerramentasMatriculasTST.SuspendLayout();
        InformacoesGBX.SuspendLayout();
        BarraFerramentasInformacoesTST.SuspendLayout();
        BarraFerramentasPrincipalTST.SuspendLayout();
        SuspendLayout();
        // 
        // MatriculasSelecionadasDGV
        // 
        MatriculasSelecionadasDGV.AllowUserToAddRows = false;
        MatriculasSelecionadasDGV.AllowUserToDeleteRows = false;
        MatriculasSelecionadasDGV.BackgroundColor = SystemColors.Control;
        MatriculasSelecionadasDGV.BorderStyle = BorderStyle.Fixed3D;
        MatriculasSelecionadasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MatriculasSelecionadasDGV.Dock = DockStyle.Fill;
        MatriculasSelecionadasDGV.Location = new Point(3, 44);
        MatriculasSelecionadasDGV.Name = "MatriculasSelecionadasDGV";
        MatriculasSelecionadasDGV.ReadOnly = true;
        MatriculasSelecionadasDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
        MatriculasSelecionadasDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        MatriculasSelecionadasDGV.Size = new Size(772, 420);
        MatriculasSelecionadasDGV.TabIndex = 0;
        MatriculasSelecionadasDGV.CellClick += MatriculasSelecionadasDGV_CellClick;
        MatriculasSelecionadasDGV.CellEnter += MatriculasSelecionadasDGV_CellEnter;
        MatriculasSelecionadasDGV.ColumnHeaderMouseClick += MatriculasSelecionadasDGV_ColumnHeaderMouseClick;
        // 
        // MatriculasGBX
        // 
        MatriculasGBX.Controls.Add(MatriculasSelecionadasDGV);
        MatriculasGBX.Controls.Add(BarraStatusFeedback);
        MatriculasGBX.Controls.Add(BarraFerramentasMatriculasTST);
        MatriculasGBX.Dock = DockStyle.Fill;
        MatriculasGBX.Location = new Point(5, 178);
        MatriculasGBX.Name = "MatriculasGBX";
        MatriculasGBX.Size = new Size(778, 489);
        MatriculasGBX.TabIndex = 1;
        MatriculasGBX.TabStop = false;
        MatriculasGBX.Text = "Matrículas";
        // 
        // BarraStatusFeedback
        // 
        BarraStatusFeedback.Items.AddRange(new ToolStripItem[] { FeedbackLBL });
        BarraStatusFeedback.Location = new Point(3, 464);
        BarraStatusFeedback.Name = "BarraStatusFeedback";
        BarraStatusFeedback.Size = new Size(772, 22);
        BarraStatusFeedback.TabIndex = 2;
        BarraStatusFeedback.Text = "statusStrip1";
        // 
        // FeedbackLBL
        // 
        FeedbackLBL.Name = "FeedbackLBL";
        FeedbackLBL.Size = new Size(126, 17);
        FeedbackLBL.Text = "Total de Registros: 0     ";
        // 
        // BarraFerramentasMatriculasTST
        // 
        BarraFerramentasMatriculasTST.BackColor = SystemColors.ControlLight;
        BarraFerramentasMatriculasTST.Items.AddRange(new ToolStripItem[] { PesquisarLBL, PesquisarTXT });
        BarraFerramentasMatriculasTST.Location = new Point(3, 19);
        BarraFerramentasMatriculasTST.Name = "BarraFerramentasMatriculasTST";
        BarraFerramentasMatriculasTST.Size = new Size(772, 25);
        BarraFerramentasMatriculasTST.TabIndex = 1;
        BarraFerramentasMatriculasTST.Text = "toolStrip1";
        // 
        // PesquisarLBL
        // 
        PesquisarLBL.Image = (Image)resources.GetObject("PesquisarLBL.Image");
        PesquisarLBL.ImageTransparentColor = Color.Magenta;
        PesquisarLBL.Name = "PesquisarLBL";
        PesquisarLBL.Size = new Size(73, 22);
        PesquisarLBL.Text = "Pesquisar";
        // 
        // PesquisarTXT
        // 
        PesquisarTXT.Name = "PesquisarTXT";
        PesquisarTXT.Size = new Size(300, 25);
        // 
        // InformacoesGBX
        // 
        InformacoesGBX.Controls.Add(BarraFerramentasInformacoesTST);
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
        InformacoesGBX.Location = new Point(5, 38);
        InformacoesGBX.Name = "InformacoesGBX";
        InformacoesGBX.Size = new Size(778, 140);
        InformacoesGBX.TabIndex = 2;
        InformacoesGBX.TabStop = false;
        InformacoesGBX.Text = "Informações da Matrícula";
        // 
        // BarraFerramentasInformacoesTST
        // 
        BarraFerramentasInformacoesTST.BackColor = SystemColors.ControlLight;
        BarraFerramentasInformacoesTST.Items.AddRange(new ToolStripItem[] { ErroBTN, CertificadoBTN, UnidadeLBL });
        BarraFerramentasInformacoesTST.Location = new Point(3, 19);
        BarraFerramentasInformacoesTST.Name = "BarraFerramentasInformacoesTST";
        BarraFerramentasInformacoesTST.Size = new Size(772, 25);
        BarraFerramentasInformacoesTST.TabIndex = 13;
        BarraFerramentasInformacoesTST.Text = "toolStrip1";
        // 
        // ErroBTN
        // 
        ErroBTN.Alignment = ToolStripItemAlignment.Right;
        ErroBTN.DisplayStyle = ToolStripItemDisplayStyle.Image;
        ErroBTN.Image = (Image)resources.GetObject("ErroBTN.Image");
        ErroBTN.ImageTransparentColor = Color.Magenta;
        ErroBTN.Name = "ErroBTN";
        ErroBTN.Size = new Size(23, 22);
        ErroBTN.Text = "Erro";
        // 
        // CertificadoBTN
        // 
        CertificadoBTN.Alignment = ToolStripItemAlignment.Right;
        CertificadoBTN.DisplayStyle = ToolStripItemDisplayStyle.Image;
        CertificadoBTN.Image = (Image)resources.GetObject("CertificadoBTN.Image");
        CertificadoBTN.ImageTransparentColor = Color.Magenta;
        CertificadoBTN.Name = "CertificadoBTN";
        CertificadoBTN.Size = new Size(23, 22);
        CertificadoBTN.Text = "Certificado";
        // 
        // UnidadeLBL
        // 
        UnidadeLBL.Name = "UnidadeLBL";
        UnidadeLBL.Size = new Size(118, 22);
        UnidadeLBL.Text = "Unidade Operacional";
        // 
        // EmailTXT
        // 
        EmailTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        EmailTXT.Location = new Point(527, 106);
        EmailTXT.Name = "EmailTXT";
        EmailTXT.Size = new Size(244, 23);
        EmailTXT.TabIndex = 12;
        // 
        // EmailLBL
        // 
        EmailLBL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        EmailLBL.AutoSize = true;
        EmailLBL.Location = new Point(527, 88);
        EmailLBL.Name = "EmailLBL";
        EmailLBL.Size = new Size(36, 15);
        EmailLBL.TabIndex = 11;
        EmailLBL.Text = "Email";
        // 
        // CpfTXT
        // 
        CpfTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        CpfTXT.Location = new Point(387, 106);
        CpfTXT.Name = "CpfTXT";
        CpfTXT.Size = new Size(134, 23);
        CpfTXT.TabIndex = 10;
        // 
        // AlunoTXT
        // 
        AlunoTXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        AlunoTXT.Location = new Point(6, 106);
        AlunoTXT.Name = "AlunoTXT";
        AlunoTXT.Size = new Size(375, 23);
        AlunoTXT.TabIndex = 9;
        // 
        // AlunoLBL
        // 
        AlunoLBL.AutoSize = true;
        AlunoLBL.Location = new Point(6, 88);
        AlunoLBL.Name = "AlunoLBL";
        AlunoLBL.Size = new Size(39, 15);
        AlunoLBL.TabIndex = 8;
        AlunoLBL.Text = "Aluno";
        // 
        // CpfLBL
        // 
        CpfLBL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        CpfLBL.AutoSize = true;
        CpfLBL.Location = new Point(387, 88);
        CpfLBL.Name = "CpfLBL";
        CpfLBL.Size = new Size(28, 15);
        CpfLBL.TabIndex = 6;
        CpfLBL.Text = "CPF";
        // 
        // TurmaTXT
        // 
        TurmaTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        TurmaTXT.Location = new Point(646, 62);
        TurmaTXT.Name = "TurmaTXT";
        TurmaTXT.Size = new Size(125, 23);
        TurmaTXT.TabIndex = 5;
        // 
        // TurmaLBL
        // 
        TurmaLBL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        TurmaLBL.AutoSize = true;
        TurmaLBL.Location = new Point(646, 44);
        TurmaLBL.Name = "TurmaLBL";
        TurmaLBL.Size = new Size(41, 15);
        TurmaLBL.TabIndex = 4;
        TurmaLBL.Text = "Turma";
        // 
        // CursoTXT
        // 
        CursoTXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CursoTXT.Location = new Point(6, 62);
        CursoTXT.Name = "CursoTXT";
        CursoTXT.Size = new Size(634, 23);
        CursoTXT.TabIndex = 3;
        // 
        // CursoLBL
        // 
        CursoLBL.AutoSize = true;
        CursoLBL.Location = new Point(6, 44);
        CursoLBL.Name = "CursoLBL";
        CursoLBL.Size = new Size(38, 15);
        CursoLBL.TabIndex = 2;
        CursoLBL.Text = "Curso";
        // 
        // BarraFerramentasPrincipalTST
        // 
        BarraFerramentasPrincipalTST.BackColor = SystemColors.ControlLight;
        BarraFerramentasPrincipalTST.Items.AddRange(new ToolStripItem[] { LogoLBL, toolStripSeparator1, ImportarMatriculasBTN, EnviarCertificadosBTN, toolStripSeparator2, ExportarRelatorioCBX });
        BarraFerramentasPrincipalTST.Location = new Point(5, 5);
        BarraFerramentasPrincipalTST.Name = "BarraFerramentasPrincipalTST";
        BarraFerramentasPrincipalTST.Size = new Size(778, 33);
        BarraFerramentasPrincipalTST.TabIndex = 3;
        BarraFerramentasPrincipalTST.Text = "toolStrip1";
        // 
        // LogoLBL
        // 
        LogoLBL.AutoSize = false;
        LogoLBL.Name = "LogoLBL";
        LogoLBL.Size = new Size(86, 30);
        LogoLBL.Text = "SUA LOGO";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 33);
        // 
        // ImportarMatriculasBTN
        // 
        ImportarMatriculasBTN.Image = (Image)resources.GetObject("ImportarMatriculasBTN.Image");
        ImportarMatriculasBTN.ImageTransparentColor = Color.Magenta;
        ImportarMatriculasBTN.Name = "ImportarMatriculasBTN";
        ImportarMatriculasBTN.Size = new Size(131, 30);
        ImportarMatriculasBTN.Text = "Importar Matrículas";
        ImportarMatriculasBTN.Click += ImportarMatriculasBTN_Click;
        // 
        // EnviarCertificadosBTN
        // 
        EnviarCertificadosBTN.Image = (Image)resources.GetObject("EnviarCertificadosBTN.Image");
        EnviarCertificadosBTN.ImageTransparentColor = Color.Magenta;
        EnviarCertificadosBTN.Name = "EnviarCertificadosBTN";
        EnviarCertificadosBTN.Size = new Size(125, 30);
        EnviarCertificadosBTN.Text = "Enviar Certificados";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 33);
        // 
        // ExportarRelatorioCBX
        // 
        ExportarRelatorioCBX.DropDownItems.AddRange(new ToolStripItem[] { PdfBTN, XlsxBTN });
        ExportarRelatorioCBX.Image = (Image)resources.GetObject("ExportarRelatorioCBX.Image");
        ExportarRelatorioCBX.ImageTransparentColor = Color.Magenta;
        ExportarRelatorioCBX.Name = "ExportarRelatorioCBX";
        ExportarRelatorioCBX.Size = new Size(130, 30);
        ExportarRelatorioCBX.Text = "Exportar Relatório";
        // 
        // PdfBTN
        // 
        PdfBTN.Name = "PdfBTN";
        PdfBTN.Size = new Size(180, 22);
        PdfBTN.Text = "PDF";
        // 
        // XlsxBTN
        // 
        XlsxBTN.Name = "XlsxBTN";
        XlsxBTN.Size = new Size(180, 22);
        XlsxBTN.Text = "XLSX";
        // 
        // PrincipalView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(788, 672);
        Controls.Add(MatriculasGBX);
        Controls.Add(InformacoesGBX);
        Controls.Add(BarraFerramentasPrincipalTST);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "PrincipalView";
        Padding = new Padding(5);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PrincipalView";
        Activated += PrincipalView_Activated;
        Load += PrincipalView_Load;
        ((System.ComponentModel.ISupportInitialize)MatriculasSelecionadasDGV).EndInit();
        MatriculasGBX.ResumeLayout(false);
        MatriculasGBX.PerformLayout();
        BarraStatusFeedback.ResumeLayout(false);
        BarraStatusFeedback.PerformLayout();
        BarraFerramentasMatriculasTST.ResumeLayout(false);
        BarraFerramentasMatriculasTST.PerformLayout();
        InformacoesGBX.ResumeLayout(false);
        InformacoesGBX.PerformLayout();
        BarraFerramentasInformacoesTST.ResumeLayout(false);
        BarraFerramentasInformacoesTST.PerformLayout();
        BarraFerramentasPrincipalTST.ResumeLayout(false);
        BarraFerramentasPrincipalTST.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private GroupBox MatriculasGBX;
    private GroupBox InformacoesGBX;
    private ToolStrip BarraFerramentasPrincipalTST;
    private ToolStripLabel LogoLBL;
    private ToolStripSeparator toolStripSeparator1;
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
    private ToolStrip BarraFerramentasInformacoesTST;
    private ToolStripButton ErroBTN;
    private ToolStripButton CertificadoBTN;
    private ToolStripLabel UnidadeLBL;
    public DataGridView MatriculasSelecionadasDGV;
}
