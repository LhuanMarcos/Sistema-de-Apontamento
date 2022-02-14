using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_PONTO;

namespace GUI_PONTO.Views
{
    public partial class frmMensagenDeSucesso : Form
    {
        frmUsuario frmUsuario = new();
        public frmMensagenDeSucesso()
        {
            InitializeComponent();
        }

        

        public void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        public void labelChanged(string label)
        {

            label1.Text = label;
            
        }
    }
}
