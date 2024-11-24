using System;
using System.IO;
using System.Windows.Forms;

namespace E_Docs.Views.Views;
public partial class ExcecoesView : Form
{
    string diretorioImagens = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

    public ExcecoesView()
    {
        InitializeComponent();
    }

    private void FecharBTN_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ExcecoesView_Load(object sender, EventArgs e)
    {

    }
}
