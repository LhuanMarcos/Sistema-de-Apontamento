using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_MODERNISTA.Views;
using GUI_PONTO.Views;

namespace GUI_PONTO
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            SubmenuReportes.Visible = true;
        }
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
       
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null ,e);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new frmCargo());
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new frmMatriz());

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja fechar o programa", "Stenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            this.Close();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {

            SubmenuReportes.Visible = true;
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmInicio());

        }

        private void SubmenuReportes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmUsuario());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmFeriado());
        }

      

        private void btnDepartment_click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDepartamento());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCorrecoRegistroPonto());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmJustificativa());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCategoriaJustificativa());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmInserirJstificativa());
        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            AbrirFormEnPanel(new frmUsuario());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmRelatorioPonto());
        }
    }
}
