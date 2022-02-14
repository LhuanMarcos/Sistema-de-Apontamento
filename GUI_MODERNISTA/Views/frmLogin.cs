using GUI_PONTO.Controller;
using GUI_PONTO.Entities;
using POINT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI_PONTO.Views
{
    public partial class frmLogin : Form
    {
        PointModel pointModel = new PointModel();
        public frmLogin()
        {
            InitializeComponent();
            BtnPassword.PasswordChar = '*';
        }


        #region LOGIN DE USUÁRIO
        Controller.UserDao userDao = new Controller.UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        #endregion

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
    

            var validLogin = pointModel.LoginUser(BtnUsuario.Text, BtnPassword.Text);
            if (validLogin == true)
            {

                if (UserCache.DBRoleID == 1)
                {
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.Show();
         
                    frmPrincipal.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Autorizado somente para Administrador","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    BtnUsuario.Clear();
                    BtnPassword.Clear();
                    lbError.Text = "";
                }
                    
            }
            else
            {
                msgError("Nome ou senha inválido");
                BtnUsuario.UseSystemPasswordChar = false;
                BtnUsuario.Clear();
                BtnPassword.Clear();
                BtnUsuario.Focus();
            }
        }

        private void msgError(string msg)
        {
            lbError.Text = "    " + msg;
            lbError.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            BtnPassword.Clear();       
           
            BtnUsuario.Clear();
            lbError.Visible = false;
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
