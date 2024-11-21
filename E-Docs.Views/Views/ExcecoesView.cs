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
    public ExcecoesView()
    {
        InitializeComponent();
    }

    private void FecharBTN_Click(object sender, EventArgs e)
    {
        Close();
    }
}
