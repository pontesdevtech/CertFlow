namespace E_Docs.Views.Views;

partial class EnviarCertificadosView
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        OrientacoesGBX = new System.Windows.Forms.GroupBox();
        OrietacaoEnvioLBL = new System.Windows.Forms.Label();
        ImagemEnvioCertificadoIMG = new System.Windows.Forms.PictureBox();
        BarraFerramentasTST = new System.Windows.Forms.ToolStrip();
        CancelarBTN = new System.Windows.Forms.ToolStripButton();
        EnviarBTN = new System.Windows.Forms.ToolStripButton();
        FeedbackLBL = new System.Windows.Forms.ToolStripLabel();
        InformacoesGBX = new System.Windows.Forms.GroupBox();
        TagsCBX = new System.Windows.Forms.ComboBox();
        TagsLBL = new System.Windows.Forms.Label();
        MensagemTXT = new System.Windows.Forms.TextBox();
        MensagemLBL = new System.Windows.Forms.Label();
        CcoTXT = new System.Windows.Forms.TextBox();
        CcoLBL = new System.Windows.Forms.Label();
        SenhaTXT = new System.Windows.Forms.TextBox();
        SenhaLBL = new System.Windows.Forms.Label();
        CcTXT = new System.Windows.Forms.TextBox();
        CcLBL = new System.Windows.Forms.Label();
        RemetenteTXT = new System.Windows.Forms.TextBox();
        RemetenteLBL = new System.Windows.Forms.Label();
        EmailsGBX = new System.Windows.Forms.GroupBox();
        EmailsDGV = new System.Windows.Forms.DataGridView();
        OrientacoesGBX.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ImagemEnvioCertificadoIMG).BeginInit();
        BarraFerramentasTST.SuspendLayout();
        InformacoesGBX.SuspendLayout();
        EmailsGBX.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EmailsDGV).BeginInit();
        SuspendLayout();
        // 
        // OrientacoesGBX
        // 
        OrientacoesGBX.BackColor = System.Drawing.SystemColors.ControlLight;
        OrientacoesGBX.Controls.Add(OrietacaoEnvioLBL);
        OrientacoesGBX.Controls.Add(ImagemEnvioCertificadoIMG);
        OrientacoesGBX.Dock = System.Windows.Forms.DockStyle.Top;
        OrientacoesGBX.Location = new System.Drawing.Point(5, 5);
        OrientacoesGBX.Name = "OrientacoesGBX";
        OrientacoesGBX.Padding = new System.Windows.Forms.Padding(5);
        OrientacoesGBX.Size = new System.Drawing.Size(788, 122);
        OrientacoesGBX.TabIndex = 3;
        OrientacoesGBX.TabStop = false;
        OrientacoesGBX.Text = "Envio de Certificados";
        // 
        // OrietacaoEnvioLBL
        // 
        OrietacaoEnvioLBL.Dock = System.Windows.Forms.DockStyle.Fill;
        OrietacaoEnvioLBL.Location = new System.Drawing.Point(105, 21);
        OrietacaoEnvioLBL.Name = "OrietacaoEnvioLBL";
        OrietacaoEnvioLBL.Padding = new System.Windows.Forms.Padding(10);
        OrietacaoEnvioLBL.Size = new System.Drawing.Size(678, 96);
        OrietacaoEnvioLBL.TabIndex = 0;
        OrietacaoEnvioLBL.Text = "Selecione o local onde estão armazenados a lista de matrículados e os Certificados para ajuste e envio.";
        OrietacaoEnvioLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ImagemEnvioCertificadoIMG
        // 
        ImagemEnvioCertificadoIMG.BackColor = System.Drawing.SystemColors.ControlLight;
        ImagemEnvioCertificadoIMG.Dock = System.Windows.Forms.DockStyle.Left;
        ImagemEnvioCertificadoIMG.Image = Properties.Resources.EmailVerde;
        ImagemEnvioCertificadoIMG.Location = new System.Drawing.Point(5, 21);
        ImagemEnvioCertificadoIMG.Name = "ImagemEnvioCertificadoIMG";
        ImagemEnvioCertificadoIMG.Size = new System.Drawing.Size(100, 96);
        ImagemEnvioCertificadoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        ImagemEnvioCertificadoIMG.TabIndex = 1;
        ImagemEnvioCertificadoIMG.TabStop = false;
        // 
        // BarraFerramentasTST
        // 
        BarraFerramentasTST.Dock = System.Windows.Forms.DockStyle.Bottom;
        BarraFerramentasTST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { CancelarBTN, EnviarBTN, FeedbackLBL });
        BarraFerramentasTST.Location = new System.Drawing.Point(5, 674);
        BarraFerramentasTST.Name = "BarraFerramentasTST";
        BarraFerramentasTST.Size = new System.Drawing.Size(788, 25);
        BarraFerramentasTST.TabIndex = 5;
        BarraFerramentasTST.Text = "toolStrip1";
        // 
        // CancelarBTN
        // 
        CancelarBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        CancelarBTN.Image = Properties.Resources.CancelarVermelho;
        CancelarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        CancelarBTN.Name = "CancelarBTN";
        CancelarBTN.Size = new System.Drawing.Size(73, 22);
        CancelarBTN.Text = "Cancelar";
        // 
        // EnviarBTN
        // 
        EnviarBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        EnviarBTN.Image = Properties.Resources.EnviarVerde;
        EnviarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
        EnviarBTN.Name = "EnviarBTN";
        EnviarBTN.Size = new System.Drawing.Size(59, 22);
        EnviarBTN.Text = "Enviar";
        EnviarBTN.Click += EnviarBTN_Click;
        // 
        // FeedbackLBL
        // 
        FeedbackLBL.Name = "FeedbackLBL";
        FeedbackLBL.Size = new System.Drawing.Size(150, 22);
        FeedbackLBL.Text = "Registros Selecionados: 0/0";
        // 
        // InformacoesGBX
        // 
        InformacoesGBX.Controls.Add(TagsCBX);
        InformacoesGBX.Controls.Add(TagsLBL);
        InformacoesGBX.Controls.Add(MensagemTXT);
        InformacoesGBX.Controls.Add(MensagemLBL);
        InformacoesGBX.Controls.Add(CcoTXT);
        InformacoesGBX.Controls.Add(CcoLBL);
        InformacoesGBX.Controls.Add(SenhaTXT);
        InformacoesGBX.Controls.Add(SenhaLBL);
        InformacoesGBX.Controls.Add(CcTXT);
        InformacoesGBX.Controls.Add(CcLBL);
        InformacoesGBX.Controls.Add(RemetenteTXT);
        InformacoesGBX.Controls.Add(RemetenteLBL);
        InformacoesGBX.Dock = System.Windows.Forms.DockStyle.Top;
        InformacoesGBX.Location = new System.Drawing.Point(5, 127);
        InformacoesGBX.Name = "InformacoesGBX";
        InformacoesGBX.Size = new System.Drawing.Size(788, 208);
        InformacoesGBX.TabIndex = 6;
        InformacoesGBX.TabStop = false;
        InformacoesGBX.Text = "Informações para Envio";
        // 
        // TagsCBX
        // 
        TagsCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        TagsCBX.FormattingEnabled = true;
        TagsCBX.Items.AddRange(new object[] { "ALUNO", "RA", "CPF", "CURSO", "PERIODO", "UNIDADE" });
        TagsCBX.Location = new System.Drawing.Point(617, 18);
        TagsCBX.Name = "TagsCBX";
        TagsCBX.Size = new System.Drawing.Size(165, 23);
        TagsCBX.TabIndex = 16;
        TagsCBX.SelectedIndexChanged += TagsCBX_SelectedIndexChanged;
        // 
        // TagsLBL
        // 
        TagsLBL.AutoSize = true;
        TagsLBL.Location = new System.Drawing.Point(581, 22);
        TagsLBL.Name = "TagsLBL";
        TagsLBL.Size = new System.Drawing.Size(30, 15);
        TagsLBL.TabIndex = 17;
        TagsLBL.Text = "Tags";
        // 
        // MensagemTXT
        // 
        MensagemTXT.Location = new System.Drawing.Point(275, 40);
        MensagemTXT.Multiline = true;
        MensagemTXT.Name = "MensagemTXT";
        MensagemTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        MensagemTXT.Size = new System.Drawing.Size(507, 155);
        MensagemTXT.TabIndex = 5;
        // 
        // MensagemLBL
        // 
        MensagemLBL.AutoSize = true;
        MensagemLBL.Location = new System.Drawing.Point(275, 22);
        MensagemLBL.Name = "MensagemLBL";
        MensagemLBL.Size = new System.Drawing.Size(66, 15);
        MensagemLBL.TabIndex = 14;
        MensagemLBL.Text = "Mensagem";
        // 
        // CcoTXT
        // 
        CcoTXT.Location = new System.Drawing.Point(6, 172);
        CcoTXT.Name = "CcoTXT";
        CcoTXT.Size = new System.Drawing.Size(244, 23);
        CcoTXT.TabIndex = 4;
        // 
        // CcoLBL
        // 
        CcoLBL.AutoSize = true;
        CcoLBL.Location = new System.Drawing.Point(6, 154);
        CcoLBL.Name = "CcoLBL";
        CcoLBL.Size = new System.Drawing.Size(28, 15);
        CcoLBL.TabIndex = 12;
        CcoLBL.Text = "Cco";
        // 
        // SenhaTXT
        // 
        SenhaTXT.Location = new System.Drawing.Point(6, 84);
        SenhaTXT.Name = "SenhaTXT";
        SenhaTXT.PasswordChar = '*';
        SenhaTXT.Size = new System.Drawing.Size(244, 23);
        SenhaTXT.TabIndex = 2;
        // 
        // SenhaLBL
        // 
        SenhaLBL.AutoSize = true;
        SenhaLBL.Location = new System.Drawing.Point(6, 66);
        SenhaLBL.Name = "SenhaLBL";
        SenhaLBL.Size = new System.Drawing.Size(39, 15);
        SenhaLBL.TabIndex = 10;
        SenhaLBL.Text = "Senha";
        // 
        // CcTXT
        // 
        CcTXT.Location = new System.Drawing.Point(6, 128);
        CcTXT.Name = "CcTXT";
        CcTXT.Size = new System.Drawing.Size(244, 23);
        CcTXT.TabIndex = 3;
        // 
        // CcLBL
        // 
        CcLBL.AutoSize = true;
        CcLBL.Location = new System.Drawing.Point(6, 110);
        CcLBL.Name = "CcLBL";
        CcLBL.Size = new System.Drawing.Size(21, 15);
        CcLBL.TabIndex = 8;
        CcLBL.Text = "Cc";
        // 
        // RemetenteTXT
        // 
        RemetenteTXT.Location = new System.Drawing.Point(6, 40);
        RemetenteTXT.Name = "RemetenteTXT";
        RemetenteTXT.Size = new System.Drawing.Size(244, 23);
        RemetenteTXT.TabIndex = 1;
        // 
        // RemetenteLBL
        // 
        RemetenteLBL.AutoSize = true;
        RemetenteLBL.Location = new System.Drawing.Point(6, 22);
        RemetenteLBL.Name = "RemetenteLBL";
        RemetenteLBL.Size = new System.Drawing.Size(113, 15);
        RemetenteLBL.TabIndex = 2;
        RemetenteLBL.Text = "Email do Remetente";
        // 
        // EmailsGBX
        // 
        EmailsGBX.Controls.Add(EmailsDGV);
        EmailsGBX.Dock = System.Windows.Forms.DockStyle.Fill;
        EmailsGBX.Location = new System.Drawing.Point(5, 335);
        EmailsGBX.Name = "EmailsGBX";
        EmailsGBX.Size = new System.Drawing.Size(788, 339);
        EmailsGBX.TabIndex = 11;
        EmailsGBX.TabStop = false;
        EmailsGBX.Text = "Emails";
        // 
        // EmailsDGV
        // 
        EmailsDGV.AllowUserToAddRows = false;
        EmailsDGV.AllowUserToDeleteRows = false;
        EmailsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
        EmailsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        EmailsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        EmailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        EmailsDGV.DefaultCellStyle = dataGridViewCellStyle2;
        EmailsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
        EmailsDGV.Location = new System.Drawing.Point(3, 19);
        EmailsDGV.Name = "EmailsDGV";
        EmailsDGV.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        EmailsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        EmailsDGV.RowHeadersVisible = false;
        EmailsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
        EmailsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        EmailsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        EmailsDGV.Size = new System.Drawing.Size(782, 317);
        EmailsDGV.TabIndex = 7;
        // 
        // EnviarCertificadosView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(798, 704);
        Controls.Add(EmailsGBX);
        Controls.Add(InformacoesGBX);
        Controls.Add(BarraFerramentasTST);
        Controls.Add(OrientacoesGBX);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Name = "EnviarCertificadosView";
        Padding = new System.Windows.Forms.Padding(5);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "CertFlow - Enviar Certificados";
        Load += EnviarCertificadosView_Load;
        OrientacoesGBX.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)ImagemEnvioCertificadoIMG).EndInit();
        BarraFerramentasTST.ResumeLayout(false);
        BarraFerramentasTST.PerformLayout();
        InformacoesGBX.ResumeLayout(false);
        InformacoesGBX.PerformLayout();
        EmailsGBX.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)EmailsDGV).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.GroupBox OrientacoesGBX;
    private System.Windows.Forms.Label OrietacaoEnvioLBL;
    private System.Windows.Forms.PictureBox ImagemEnvioCertificadoIMG;
    private System.Windows.Forms.ToolStrip BarraFerramentasTST;
    private System.Windows.Forms.ToolStripButton CancelarBTN;
    private System.Windows.Forms.ToolStripButton EnviarBTN;
    private System.Windows.Forms.GroupBox InformacoesGBX;
    private System.Windows.Forms.TextBox CcTXT;
    private System.Windows.Forms.Label CcLBL;
    private System.Windows.Forms.TextBox RemetenteTXT;
    private System.Windows.Forms.Label RemetenteLBL;
    private System.Windows.Forms.TextBox SenhaTXT;
    private System.Windows.Forms.Label SenhaLBL;
    private System.Windows.Forms.TextBox CcoTXT;
    private System.Windows.Forms.Label CcoLBL;
    private System.Windows.Forms.GroupBox EmailsGBX;
    private System.Windows.Forms.TextBox MensagemTXT;
    private System.Windows.Forms.Label MensagemLBL;
    private System.Windows.Forms.Label TagsLBL;
    private System.Windows.Forms.ComboBox TagsCBX;
    public System.Windows.Forms.DataGridView EmailsDGV;
    public System.Windows.Forms.ToolStripLabel FeedbackLBL;
}