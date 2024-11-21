using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Docs.Views.Views;
public partial class ExcecoesView : Form
{
    string diretorioImagens = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

    public ExcecoesView()
    {
        InitializeComponent();
        //Estilização da tela
        ImagemExcecaoIMG.Image = Image.FromFile(Path.Combine(diretorioImagens, "Erro.png"));
        ImagemExcecaoIMG.SizeMode = PictureBoxSizeMode.Zoom;
        FecharBTN.Image = Image.FromFile(Path.Combine(diretorioImagens, "Pendente.png"));
    }

    private void FecharBTN_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ExcecoesView_Load(object sender, EventArgs e)
    {

    }
}
