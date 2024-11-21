namespace E_Docs.Views.Views;

partial class ExcecoesView
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcecoesView));
        InformacoesTecnicasTXT = new TextBox();
        ExcecaoGBX = new GroupBox();
        MensagemErroLBL = new Label();
        ImagemExcecaoIMG = new PictureBox();
        ResumoExcecaoGBX = new GroupBox();
        DetalhesErroTAB = new TabControl();
        InformacoesBasicasPAG = new TabPage();
        InformacoesBasicasTXT = new TextBox();
        InformacoesTecnicasPAG = new TabPage();
        BarraFerramentasTST = new ToolStrip();
        FecharBTN = new ToolStripButton();
        FeedbackLBL = new ToolStripLabel();
        ExcecaoGBX.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ImagemExcecaoIMG).BeginInit();
        ResumoExcecaoGBX.SuspendLayout();
        DetalhesErroTAB.SuspendLayout();
        InformacoesBasicasPAG.SuspendLayout();
        InformacoesTecnicasPAG.SuspendLayout();
        BarraFerramentasTST.SuspendLayout();
        SuspendLayout();
        // 
        // InformacoesTecnicasTXT
        // 
        InformacoesTecnicasTXT.Dock = DockStyle.Fill;
        InformacoesTecnicasTXT.Location = new Point(3, 3);
        InformacoesTecnicasTXT.Margin = new Padding(5);
        InformacoesTecnicasTXT.Multiline = true;
        InformacoesTecnicasTXT.Name = "InformacoesTecnicasTXT";
        InformacoesTecnicasTXT.ScrollBars = ScrollBars.Both;
        InformacoesTecnicasTXT.Size = new Size(561, 397);
        InformacoesTecnicasTXT.TabIndex = 0;
        InformacoesTecnicasTXT.WordWrap = false;
        // 
        // ExcecaoGBX
        // 
        ExcecaoGBX.BackColor = SystemColors.ControlLight;
        ExcecaoGBX.Controls.Add(MensagemErroLBL);
        ExcecaoGBX.Controls.Add(ImagemExcecaoIMG);
        ExcecaoGBX.Dock = DockStyle.Top;
        ExcecaoGBX.Location = new Point(0, 0);
        ExcecaoGBX.Name = "ExcecaoGBX";
        ExcecaoGBX.Padding = new Padding(5);
        ExcecaoGBX.Size = new Size(485, 122);
        ExcecaoGBX.TabIndex = 3;
        ExcecaoGBX.TabStop = false;
        ExcecaoGBX.Text = "Exceção";
        // 
        // MensagemErroLBL
        // 
        MensagemErroLBL.Dock = DockStyle.Fill;
        MensagemErroLBL.Location = new Point(105, 21);
        MensagemErroLBL.Name = "MensagemErroLBL";
        MensagemErroLBL.Padding = new Padding(10);
        MensagemErroLBL.Size = new Size(375, 96);
        MensagemErroLBL.TabIndex = 0;
        MensagemErroLBL.Text = "Processo executado com erros.";
        MensagemErroLBL.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ImagemExcecaoIMG
        // 
        ImagemExcecaoIMG.BackColor = SystemColors.ControlDarkDark;
        ImagemExcecaoIMG.Dock = DockStyle.Left;
        ImagemExcecaoIMG.Location = new Point(5, 21);
        ImagemExcecaoIMG.Name = "ImagemExcecaoIMG";
        ImagemExcecaoIMG.Size = new Size(100, 96);
        ImagemExcecaoIMG.TabIndex = 1;
        ImagemExcecaoIMG.TabStop = false;
        // 
        // ResumoExcecaoGBX
        // 
        ResumoExcecaoGBX.Controls.Add(DetalhesErroTAB);
        ResumoExcecaoGBX.Controls.Add(BarraFerramentasTST);
        ResumoExcecaoGBX.Dock = DockStyle.Fill;
        ResumoExcecaoGBX.Location = new Point(0, 122);
        ResumoExcecaoGBX.Name = "ResumoExcecaoGBX";
        ResumoExcecaoGBX.Size = new Size(485, 347);
        ResumoExcecaoGBX.TabIndex = 4;
        ResumoExcecaoGBX.TabStop = false;
        ResumoExcecaoGBX.Text = "Detalhes do Erro";
        // 
        // DetalhesErroTAB
        // 
        DetalhesErroTAB.Controls.Add(InformacoesBasicasPAG);
        DetalhesErroTAB.Controls.Add(InformacoesTecnicasPAG);
        DetalhesErroTAB.Dock = DockStyle.Fill;
        DetalhesErroTAB.Location = new Point(3, 19);
        DetalhesErroTAB.Name = "DetalhesErroTAB";
        DetalhesErroTAB.SelectedIndex = 0;
        DetalhesErroTAB.Size = new Size(479, 300);
        DetalhesErroTAB.TabIndex = 6;
        // 
        // InformacoesBasicasPAG
        // 
        InformacoesBasicasPAG.Controls.Add(InformacoesBasicasTXT);
        InformacoesBasicasPAG.Location = new Point(4, 24);
        InformacoesBasicasPAG.Name = "InformacoesBasicasPAG";
        InformacoesBasicasPAG.Padding = new Padding(3);
        InformacoesBasicasPAG.Size = new Size(471, 272);
        InformacoesBasicasPAG.TabIndex = 0;
        InformacoesBasicasPAG.Text = "Informações Básicas";
        InformacoesBasicasPAG.UseVisualStyleBackColor = true;
        // 
        // InformacoesBasicasTXT
        // 
        InformacoesBasicasTXT.Dock = DockStyle.Fill;
        InformacoesBasicasTXT.Location = new Point(3, 3);
        InformacoesBasicasTXT.Margin = new Padding(5);
        InformacoesBasicasTXT.Multiline = true;
        InformacoesBasicasTXT.Name = "InformacoesBasicasTXT";
        InformacoesBasicasTXT.ScrollBars = ScrollBars.Both;
        InformacoesBasicasTXT.Size = new Size(465, 266);
        InformacoesBasicasTXT.TabIndex = 1;
        // 
        // InformacoesTecnicasPAG
        // 
        InformacoesTecnicasPAG.Controls.Add(InformacoesTecnicasTXT);
        InformacoesTecnicasPAG.Location = new Point(4, 24);
        InformacoesTecnicasPAG.Name = "InformacoesTecnicasPAG";
        InformacoesTecnicasPAG.Padding = new Padding(3);
        InformacoesTecnicasPAG.Size = new Size(567, 403);
        InformacoesTecnicasPAG.TabIndex = 1;
        InformacoesTecnicasPAG.Text = "Informações Técnicas";
        InformacoesTecnicasPAG.UseVisualStyleBackColor = true;
        // 
        // BarraFerramentasTST
        // 
        BarraFerramentasTST.Dock = DockStyle.Bottom;
        BarraFerramentasTST.Items.AddRange(new ToolStripItem[] { FecharBTN, FeedbackLBL });
        BarraFerramentasTST.Location = new Point(3, 319);
        BarraFerramentasTST.Name = "BarraFerramentasTST";
        BarraFerramentasTST.Size = new Size(479, 25);
        BarraFerramentasTST.TabIndex = 5;
        BarraFerramentasTST.Text = "toolStrip1";
        // 
        // FecharBTN
        // 
        FecharBTN.Alignment = ToolStripItemAlignment.Right;
        FecharBTN.Image = (Image)resources.GetObject("FecharBTN.Image");
        FecharBTN.ImageTransparentColor = Color.Magenta;
        FecharBTN.Name = "FecharBTN";
        FecharBTN.Size = new Size(62, 22);
        FecharBTN.Text = "Fechar";
        FecharBTN.Click += FecharBTN_Click;
        // 
        // FeedbackLBL
        // 
        FeedbackLBL.Name = "FeedbackLBL";
        FeedbackLBL.Size = new Size(111, 22);
        FeedbackLBL.Text = "Total de Registros: 0";
        // 
        // ExcecoesView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(485, 469);
        Controls.Add(ResumoExcecaoGBX);
        Controls.Add(ExcecaoGBX);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "ExcecoesView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Erro ao executar o processo";
        ExcecaoGBX.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)ImagemExcecaoIMG).EndInit();
        ResumoExcecaoGBX.ResumeLayout(false);
        ResumoExcecaoGBX.PerformLayout();
        DetalhesErroTAB.ResumeLayout(false);
        InformacoesBasicasPAG.ResumeLayout(false);
        InformacoesBasicasPAG.PerformLayout();
        InformacoesTecnicasPAG.ResumeLayout(false);
        InformacoesTecnicasPAG.PerformLayout();
        BarraFerramentasTST.ResumeLayout(false);
        BarraFerramentasTST.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private GroupBox ExcecaoGBX;
    private PictureBox ImagemExcecaoIMG;
    private GroupBox ResumoExcecaoGBX;
    private ToolStrip BarraFerramentasTST;
    private ToolStripButton CancelarBTN;
    private ToolStripButton FecharBTN;
    private ToolStripLabel FeedbackLBL;
    public TextBox InformacoesTecnicasTXT;
    public Label MensagemErroLBL;
    private TabControl DetalhesErroTAB;
    private TabPage InformacoesBasicasPAG;
    private TabPage InformacoesTecnicasPAG;
    public TextBox InformacoesBasicasTXT;
}