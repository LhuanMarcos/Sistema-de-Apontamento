using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POINT.Models;
using GUI_PONTO;
using GUI_MODERNISTA.Models;
using GUI_MODERNISTA.Entities;
using GUI_PONTO.Views;

namespace GUI_MODERNISTA.Views
{
    public partial class frmCargo : Form
    {
        RoleModel roleModel = new RoleModel();
        Role role = new();

        //ointModel pointModel = new PointModel();

        public frmCargo()
        {
            InitializeComponent();
            RoleList();
        }

        private void OpenSuccessMessage()
        {
            frmMensagenDeSucesso msn = new frmMensagenDeSucesso();
            msn.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void RoleList()
        {
            try
            {
                dbRole.DataSource = roleModel.RoleListGridModel(1);
                dbRole.Columns[0].Visible = false;//ID
                dbRole.Columns[1].HeaderText = "Cargo";
                dbRole.Columns[2].HeaderText = "Status";
                dbRole.Columns[3].HeaderText = "Data de Cadastro";

                dbRole.AllowUserToAddRows = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void dbRole_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dbRole.Columns[e.ColumnIndex].Name == "status")
            {
                dbRole.Columns["status"].SortMode = DataGridViewColumnSortMode.NotSortable;

                if ((string)e.Value == "Ativo")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime date;
                date = DateTime.Now;
                role.RoleName = txtRoleName.Text;
                role.RoleStatus = 1;
                role.Created_at = Convert.ToDateTime(date);
                role.Updated_at = Convert.ToDateTime(date);

                roleModel.InsertRoleInToDataBaseFromModel(role);
                RoleList();
                OpenSuccessMessage();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Preenchendo o textBox para edição
        private void dbRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            buttonSave.Enabled = false;
            sdStatus.Enabled = true;
            rbStatus2.Enabled = true;
            role.Role_id = (int)dbRole.Rows[e.RowIndex].Cells[0].Value;
            txtRoleName.Text = dbRole.Rows[e.RowIndex].Cells[1].Value.ToString();
          
        }
        //Editar Cargo
        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                DateTime date;
                date = DateTime.Now;
                role.Role_id = role.Role_id;
                role.RoleName = txtRoleName.Text;
                role.RoleStatus = sdStatus.Checked == true ? 1 : 0;
                role.Updated_at = Convert.ToDateTime(date);
                roleModel.RoleUpdateFromModel(role);
                RoleList();
                OpenSuccessMessage();
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Campo Pesquisa Office
        private void textBoxSearchOffice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbRole.DataSource = roleModel.RoleListGridByRoleAndNameFromModel(textBoxSearchOffice.Text, rsSearch.Checked == true ? 1 : 0);
                dbRole.Columns[0].Visible = false;//ID
                dbRole.Columns[1].HeaderText = "Cargo";
                dbRole.Columns[2].HeaderText = "Status";
                dbRole.Columns[3].HeaderText = "Data de Cadastro";
            }
            catch (Exception)
            {

                throw;
            }
    
        }

        //listar cargos inativos radio button
        private void RoleListSearchIn()
        {
            try
            {
                dbRole.DataSource = roleModel.SearchBtnIn();
                dbRole.Columns[0].Visible = false;//ID
                dbRole.Columns[1].HeaderText = "Cargo";
                dbRole.Columns[2].HeaderText = "Status";
                dbRole.Columns[3].HeaderText = "Data de Cadastro";

                dbRole.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void rbSearchInativ_CheckedChanged(object sender, EventArgs e)
        {
            RoleListSearchIn();
        }

        private void rsSearch_CheckedChanged(object sender, EventArgs e)
        {
            RoleList();
        }
    }
}
