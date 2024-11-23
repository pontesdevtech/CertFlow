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
        MatriculasSelecionadasDGV = new System.Windows.Forms.DataGridView();
        MatriculasGBX = new System.Windows.Forms.GroupBox();
        BarraStatusFeedback = new System.Windows.Forms.StatusStrip();
        FeedbackLBL = new System.Windows.Forms.ToolStripStatusLabel();
        BarraFerramentasMatriculasTST = new System.Windows.Forms.ToolStrip();
        PesquisarLBL = new System.Windows.Forms.ToolStripLabel();
        PesquisarTXT = new System.Windows.Forms.ToolStripTextBox();
        ErroBTN = new System.Windows.Forms.ToolStripButton();
        CertificadoBTN = new System.Windows.Forms.ToolStripButton();
        InformacoesGBX = new System.Windows.Forms.GroupBox();
        EmailTXT = new System.Windows.Forms.TextBox();
        EmailLBL = new System.Windows.Forms.Label();
        CpfTXT = new System.Windows.Forms.TextBox();
        AlunoTXT = new System.Windows.Forms.TextBox();
        AlunoLBL = new System.Windows.Forms.Label();
        CpfLBL = new System.Windows.Forms.Label();
        TurmaTXT = new System.Windows.Forms.TextBox();
        TurmaLBL = new System.Windows.Forms.Label();
        CursoTXT = new System.Windows.Forms.TextBox();
        CursoLBL = new System.Windows.Forms.Label();
        BarraFerramentasPrincipalTST = new System.Windows.Forms.ToolStrip();
        LogoLBL = new System.Windows.Forms.ToolStripLabel();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        ImportarMatriculasBTN = new System.Windows.Forms.ToolStripButton();
        EnviarCertificadosBTN = new System.Windows.Forms.ToolStripButton();
        toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        ExportarRelatorioCBX = new System.Windows.Forms.ToolStripDropDownButton();
        PdfBTN = new System.Windows.Forms.ToolStripMenuItem();
        XlsxBTN = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)MatriculasSelecionadasDGV).BeginInit();
        MatriculasGBX.SuspendLayout();
        BarraStatusFeedback.SuspendLayout();
        BarraFerramentasMatriculasTST.SuspendLayout();
        InformacoesGBX.SuspendLayout();
        BarraFerramentasPrincipalTST.SuspendLayout();
        this.SuspendLayout();
        // 
        // MatriculasSelecionadasDGV
        // 
        MatriculasSelecionadasDGV.AllowUserToAddRows = false;
        MatriculasSelecionadasDGV.AllowUserToDeleteRows = false;
        MatriculasSelecionadasDGV.BackgroundColor = System.Drawing.SystemColors.Control;
        MatriculasSelecionadasDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        MatriculasSelecionadasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MatriculasSelecionadasDGV.Dock = System.Windows.Forms.DockStyle.Fill;
        MatriculasSelecionadasDGV.Location = new System.Drawing.Point(3, 44);
        MatriculasSelecionadasDGV.Name = "MatriculasSelecionadasDGV";
        MatriculasSelecionadasDGV.ReadOnly = true;
        MatriculasSelecionadasDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
        MatriculasSelecionadasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        MatriculasSelecionadasDGV.Size = new System.Drawing.Size(853, 458);
        MatriculasSelecionadasDGV.TabIndex = 0;
        MatriculasSelecionadasDGV.CellClick += this.MatriculasSelecionadasDGV_CellClick;
        MatriculasSelecionadasDGV.CellEnter += this.MatriculasSelecionadasDGV_CellEnter;
        MatriculasSelecionadasDGV.ColumnHeaderMouseClick += this.MatriculasSelecionadasDGV_ColumnHeaderMouseClick;
        // 
        // MatriculasGBX
        // 
        MatriculasGBX.Controls.Add(MatriculasSelecionadasDGV);
        MatriculasGBX.Controls.Add(BarraStatusFeedback);
        MatriculasGBX.Controls.Add(BarraFerramentasMatriculasTST);
        MatriculasGBX.Dock = System.Windows.Forms.DockStyle.Fill;
        MatriculasGBX.Location = new System.Drawing.Point(5, 159);
        MatriculasGBX.Name = "MatriculasGBX";
        MatriculasGBX.Size = new System.Drawing.Size(859, 527);
        MatriculasGBX.TabIndex = 1;
        MatriculasGBX.TabStop = false;
        MatriculasGBX.Text = "Matrículas";
        // 
        // BarraStatusFeedback
        // 
        BarraStatusFeedback.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { FeedbackLBL });
        BarraStatusFeedback.Location = new System.Drawing.Point(3, 502);
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
        // BarraFerramentasMatriculasTST
        // 
        BarraFerramentasMatriculasTST.BackColor = System.Drawing.SystemColors.ControlLight;
        BarraFerramentasMatriculasTST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { PesquisarLBL, PesquisarTXT, ErroBTN, CertificadoBTN });
        BarraFerramentasMatriculasTST.Location = new System.Drawing.Point(3, 19);
        BarraFerramentasMatriculasTST.Name = "BarraFerramentasMatriculasTST";
        BarraFerramentasMatriculasTST.Size = new System.Drawing.Size(853, 25);
        BarraFerramentasMatriculasTST.TabIndex = 1;
        BarraFerramentasMatriculasTST.Text = "toolStrip1";
        // 
        // PesquisarLBL
        // 
        PesquisarLBL.Image = Properties.Resources.ProcurarVerde;
        PesquisarLBL.ImageTransparentColor = System.Drawing.Color.Magenta;
        PesquisarLBL.Name = "PesquisarLBL";
        PesquisarLBL.Size = new System.Drawing.Size(73, 22);
        PesquisarLBL.Text = "Pesquisar";
        // 
        // PesquisarTXT
        // 
        PesquisarTXT.Name = "PesquisarTXT";
        PesquisarTXT.Size = new System.Drawing.Size(300, 25);
        // 
        // ErroBTN
        // 
        ErroBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        ErroBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        ErroBTN.Image = Properties.Resources.PendenteVermelho;
        ErroBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        ErroBTN.Name = "ErroBTN";
        ErroBTN.Size = new System.Drawing.Size(23, 22);
        ErroBTN.Text = "Erro";
        // 
        // CertificadoBTN
        // 
        CertificadoBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        CertificadoBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        CertificadoBTN.Image = Properties.Resources.CertificadoVerde;
        CertificadoBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        CertificadoBTN.Name = "CertificadoBTN";
        CertificadoBTN.Size = new System.Drawing.Size(23, 22);
        CertificadoBTN.Text = "Certificado";
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
        InformacoesGBX.Dock = System.Windows.Forms.DockStyle.Top;
        InformacoesGBX.Location = new System.Drawing.Point(5, 38);
        InformacoesGBX.Name = "InformacoesGBX";
        InformacoesGBX.Size = new System.Drawing.Size(859, 121);
        InformacoesGBX.TabIndex = 2;
        InformacoesGBX.TabStop = false;
        InformacoesGBX.Text = "Informações da Matrícula";
        // 
        // EmailTXT
        // 
        EmailTXT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        EmailTXT.Location = new System.Drawing.Point(608, 84);
        EmailTXT.Name = "EmailTXT";
        EmailTXT.Size = new System.Drawing.Size(244, 23);
        EmailTXT.TabIndex = 12;
        // 
        // EmailLBL
        // 
        EmailLBL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        EmailLBL.AutoSize = true;
        EmailLBL.Location = new System.Drawing.Point(608, 66);
        EmailLBL.Name = "EmailLBL";
        EmailLBL.Size = new System.Drawing.Size(36, 15);
        EmailLBL.TabIndex = 11;
        EmailLBL.Text = "Email";
        // 
        // CpfTXT
        // 
        CpfTXT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        CpfTXT.Location = new System.Drawing.Point(468, 84);
        CpfTXT.Name = "CpfTXT";
        CpfTXT.Size = new System.Drawing.Size(134, 23);
        CpfTXT.TabIndex = 10;
        // 
        // AlunoTXT
        // 
        AlunoTXT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
        CpfLBL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        CpfLBL.AutoSize = true;
        CpfLBL.Location = new System.Drawing.Point(468, 66);
        CpfLBL.Name = "CpfLBL";
        CpfLBL.Size = new System.Drawing.Size(28, 15);
        CpfLBL.TabIndex = 6;
        CpfLBL.Text = "CPF";
        // 
        // TurmaTXT
        // 
        TurmaTXT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        TurmaTXT.Location = new System.Drawing.Point(727, 40);
        TurmaTXT.Name = "TurmaTXT";
        TurmaTXT.Size = new System.Drawing.Size(125, 23);
        TurmaTXT.TabIndex = 5;
        // 
        // TurmaLBL
        // 
        TurmaLBL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        TurmaLBL.AutoSize = true;
        TurmaLBL.Location = new System.Drawing.Point(727, 22);
        TurmaLBL.Name = "TurmaLBL";
        TurmaLBL.Size = new System.Drawing.Size(41, 15);
        TurmaLBL.TabIndex = 4;
        TurmaLBL.Text = "Turma";
        // 
        // CursoTXT
        // 
        CursoTXT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
        BarraFerramentasPrincipalTST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { LogoLBL, toolStripSeparator1, ImportarMatriculasBTN, EnviarCertificadosBTN, toolStripSeparator2, ExportarRelatorioCBX });
        BarraFerramentasPrincipalTST.Location = new System.Drawing.Point(5, 5);
        BarraFerramentasPrincipalTST.Name = "BarraFerramentasPrincipalTST";
        BarraFerramentasPrincipalTST.Size = new System.Drawing.Size(859, 33);
        BarraFerramentasPrincipalTST.TabIndex = 3;
        BarraFerramentasPrincipalTST.Text = "toolStrip1";
        // 
        // LogoLBL
        // 
        LogoLBL.AutoSize = false;
        LogoLBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        LogoLBL.Name = "LogoLBL";
        LogoLBL.Size = new System.Drawing.Size(86, 30);
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
        // 
        // ImportarMatriculasBTN
        // 
        ImportarMatriculasBTN.Image = Properties.Resources.ImportarVerde;
        ImportarMatriculasBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        ImportarMatriculasBTN.Name = "ImportarMatriculasBTN";
        ImportarMatriculasBTN.Size = new System.Drawing.Size(131, 30);
        ImportarMatriculasBTN.Text = "Importar Matrículas";
        ImportarMatriculasBTN.Click += this.ImportarMatriculasBTN_Click;
        // 
        // EnviarCertificadosBTN
        // 
        EnviarCertificadosBTN.Image = Properties.Resources.EmailVerde;
        EnviarCertificadosBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        EnviarCertificadosBTN.Name = "EnviarCertificadosBTN";
        EnviarCertificadosBTN.Size = new System.Drawing.Size(125, 30);
        EnviarCertificadosBTN.Text = "Enviar Certificados";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
        // 
        // ExportarRelatorioCBX
        // 
        ExportarRelatorioCBX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { PdfBTN, XlsxBTN });
        ExportarRelatorioCBX.Image = Properties.Resources.RelatorioVerde;
        ExportarRelatorioCBX.ImageTransparentColor = System.Drawing.Color.Magenta;
        ExportarRelatorioCBX.Name = "ExportarRelatorioCBX";
        ExportarRelatorioCBX.Size = new System.Drawing.Size(130, 30);
        ExportarRelatorioCBX.Text = "Exportar Relatório";
        // 
        // PdfBTN
        // 
        PdfBTN.Name = "PdfBTN";
        PdfBTN.Size = new System.Drawing.Size(180, 22);
        PdfBTN.Text = "PDF";
        // 
        // XlsxBTN
        // 
        XlsxBTN.Name = "XlsxBTN";
        XlsxBTN.Size = new System.Drawing.Size(180, 22);
        XlsxBTN.Text = "XLSX";
        // 
        // PrincipalView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(869, 691);
        this.Controls.Add(MatriculasGBX);
        this.Controls.Add(InformacoesGBX);
        this.Controls.Add(BarraFerramentasPrincipalTST);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "PrincipalView";
        this.Padding = new System.Windows.Forms.Padding(5);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "PrincipalView";
        this.Activated += this.PrincipalView_Activated;
        this.Load += this.PrincipalView_Load;
        ((System.ComponentModel.ISupportInitialize)MatriculasSelecionadasDGV).EndInit();
        MatriculasGBX.ResumeLayout(false);
        MatriculasGBX.PerformLayout();
        BarraStatusFeedback.ResumeLayout(false);
        BarraStatusFeedback.PerformLayout();
        BarraFerramentasMatriculasTST.ResumeLayout(false);
        BarraFerramentasMatriculasTST.PerformLayout();
        InformacoesGBX.ResumeLayout(false);
        InformacoesGBX.PerformLayout();
        BarraFerramentasPrincipalTST.ResumeLayout(false);
        BarraFerramentasPrincipalTST.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
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
    public DataGridView MatriculasSelecionadasDGV;
    private ToolStripButton ErroBTN;
    private ToolStripButton CertificadoBTN;
}
