using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_MODERNISTA.Entities;
using GUI_MODERNISTA.Models;
using GUI_PONTO;
using GUI_PONTO.Controller;
using GUI_PONTO.Entities;
using GUI_PONTO.Views;
using POINT.Models;

namespace GUI_MODERNISTA.Views
{
    public partial class frmCorrecoRegistroPonto : Form
    {
        UserModel userModel = new UserModel();
        HeadOfficeModel headOfficeModel = new HeadOfficeModel();
        DepartmentModel departmentModel = new();
        PointC point = new PointC();

        PointModel pointModel = new PointModel();
        public frmCorrecoRegistroPonto()
        {
            InitializeComponent();
            SearchByUserReFormView();
            UserList();
            HeadOfficeListView(1, null);

        }

        private void frmCadastroRegistroPonto_Load(object sender, EventArgs e)
        {
            
        }

        private void UserList()
        {

            //dgUser.DataSource = userModel.Userlist();
        }

        private void SearchByUserReFormView()
        {
            point.User_re = "";
            dgUserpoins.DataSource = pointModel.SearchByUserReFormModel(point);
            dgUserpoins.Columns[0].HeaderText = "RE";
            dgUserpoins.Columns[1].HeaderText = "Nome";
            dgUserpoins.Columns[2].HeaderText = "Entrada 1";
            dgUserpoins.Columns[3].HeaderText = "Saída 1";
            dgUserpoins.Columns[4].HeaderText = "Entrada 2";
            dgUserpoins.Columns[5].HeaderText = "Saída 2";
            dgUserpoins.Columns[6].HeaderText = "Justificação";
            dgUserpoins.Columns[7].HeaderText = "Data da Marcação";
   
        }

        private void DateFormatUS()
        { 

            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "yyyy-MM-dd";
            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "yyyy-MM-dd";
        }
        private void DateFormatBR()
        {
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "dd-MM-yyyy";
            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "dd-MM-yyyy";
        }

        //Preenchendo combobox com Empresas
        private void HeadOfficeListView(int status, string headOffice)
        {

            try
            {
                DataTable dt = null;

                dt = departmentModel.HeadOfficeListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cbEmpresa.DataSource = dt;
                cbEmpresa.DisplayMember = "headOffice";
                cbEmpresa.ValueMember = "headOffice_id";
                cbEmpresa.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

        }



        private void SearchPoints()
       {
  
            DateFormatUS();
            point.UserName = txtSearch.Text;
            point.StarSearch = dtStart.Text;

            point.EndSearch = dtEnd.Text;
            point.User_re = txtRe.Text;

            point.HeadOffice = Convert.ToInt32(cbEmpresa.SelectedValue);
            point.BrantHeadOffice1 = Convert.ToInt32(cbBranch.SelectedValue);

            dgUserpoins.DataSource = pointModel.SearchByUserReFormModel(point);

            dgUserpoins.Columns[0].HeaderText = "RE";
            dgUserpoins.Columns[1].HeaderText = "Nome";
            dgUserpoins.Columns[2].HeaderText = "Entrada 1";
            dgUserpoins.Columns[3].HeaderText = "Saída 1";
            dgUserpoins.Columns[4].HeaderText = "Entrada 2";
            dgUserpoins.Columns[5].HeaderText = "Saída 2";
            dgUserpoins.Columns[6].HeaderText = "Justificação";
            dgUserpoins.Columns[7].HeaderText = "Data da Marcação";
            DateFormatBR();
        }
        private void DtStartSearchValidation()
        {
            if ("".Equals(dtStart.Text) && "".Equals(dtEnd.Text))
            {
                MessageBox.Show("Escolha um intervalo de data para iniciar a pesquisa! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtRe.Clear();
            DtStartSearchValidation();
            SearchPoints();
        }

        private void txtRe_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            DtStartSearchValidation();
            SearchPoints();
        }

        //Alterar marcação de ponto no Banco de Dados
        private void UpdatePointInToDataBaseView()
        {
            try
            {

                string originalDate = dgUserpoins.CurrentRow.Cells[7].Value.ToString();
                string convertedDate = originalDate.Substring(6, 4) + "-" +
                                   originalDate.Substring(3, 2) + "-" +
                                   originalDate.Substring(0, 2);
                point.User_re = dgUserpoins.CurrentRow.Cells[0].Value.ToString();
                point.CreatedDate = convertedDate;
                point.POne = maskB1.Text;
                point.PTwo = maskB2.Text;
                point.PTree = maskB3.Text;
                point.PFour = maskB4.Text;
                point.UpdateUser_id = UserCache.DBRoleID;
                pointModel.UpdatePointInToDataBaseFromModel(point);
                SearchPoints();

                MessageBox.Show("Cadastrado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                maskB1.Enabled = false;
                maskB2.Enabled = false;
                maskB3.Enabled = false;
                maskB4.Enabled = false;
                buttonSave.Enabled = false;
                textname.Enabled = false;

            }
            catch (Exception)
            {
                throw;
                
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePointInToDataBaseView();
            }
            catch (Exception)
            {

                MessageBox.Show("Horario no formato incorreto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbBranch.DataSource = null;
            string erroSelectedValue = cbEmpresa.SelectedValue.ToString();


            if (erroSelectedValue.Length != 23)
            {

                cbBranch.Enabled = true;
                cbBranch.DataSource = headOfficeModel.BranchHeadOfficeListModel(Convert.ToInt32(cbEmpresa.SelectedValue));
                cbBranch.DisplayMember = "branchName";
                cbBranch.ValueMember = "branchHeadOffice_id";
                cbBranch.SelectedValue = 1;
                _ = cbBranch.Items.Count > 0 ? cbBranch.Enabled = true : cbBranch.Enabled = false;

            }
            else
            {

                cbBranch.Enabled = true;
                cbBranch.DataSource = headOfficeModel.BranchHeadOfficeListModel(0);
                cbBranch.DisplayMember = "branchName";
                cbBranch.ValueMember = "branchHeadOffice_id";
                _ = cbBranch.Items.Count > 0 ? cbBranch.Enabled = true : cbBranch.Enabled = false;
            }
        }

        private void dgUserpoins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            maskB1.Enabled = true;
            maskB2.Enabled = true;
            maskB3.Enabled = true;
            maskB4.Enabled = true;
            buttonSave.Enabled = true;
            textname.Enabled = true;

            textname.Text = dgUserpoins.CurrentRow.Cells[1].Value.ToString();
            maskB1.Text = dgUserpoins.CurrentRow.Cells[2].Value.ToString();
            maskB2.Text = dgUserpoins.CurrentRow.Cells[3].Value.ToString();
            maskB3.Text = dgUserpoins.CurrentRow.Cells[4].Value.ToString();
            maskB4.Text = dgUserpoins.CurrentRow.Cells[5].Value.ToString();
         

        }

        private void cbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ = Convert.ToInt32(cbEmpresa.SelectedValue) > 0 ? txtSearch.Enabled = true : txtSearch.Enabled = false;
            _ = Convert.ToInt32(cbEmpresa.SelectedValue) > 0 ? txtRe.Enabled = true : txtRe.Enabled = false;
        }
    }
}
