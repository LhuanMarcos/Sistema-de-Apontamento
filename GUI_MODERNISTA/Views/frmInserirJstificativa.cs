using GUI_MODERNISTA.Models;
using GUI_PONTO.Entities;
using GUI_PONTO.Models;
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
    public partial class frmInserirJstificativa : Form
    {
        HeadOfficeModel headOfficeModel = new HeadOfficeModel();
        UserModel userModel = new();
        DepartmentModel departmentModel = new();
        InsertjustificationModel inJusModel = new();
        InsertJustification insertJussClass = new();
        JustificationModel jusModel = new();
        JustificationCategoryModel jusCategoryModel = new();

        public frmInserirJstificativa()
        {
            InitializeComponent();
            HeadOfficeListView(1, null);
            HeadOfficeListView2(1, null);
            ListInsertJustification();
            dateTimePickerClear();
            UserComboboxList();
            JustificationCategoryCombobox();
            Data.Value = DateTime.Now;
            Data.Enabled = false;
            TotalHoras.Enabled = false;
        }
        private void dateTimePickerClear()
        {
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = " ";
            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = " ";
        }



        //Preenchendo combobox com Empresas
        private void UserComboboxList()
        {

            try
            {
                DataTable dt = null;

                dt = userModel.UserListCombo();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cbNome.DataSource = dt;
                cbNome.DisplayMember = "userName";
                cbNome.ValueMember = "user_id";
                cbNome.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

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

        //Preenchendo combobox com Empresas
        private void HeadOfficeListView2(int status, string headOffice)
        {

            try
            {
                DataTable dt = null;

                dt = departmentModel.HeadOfficeListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cbEmpresa2.DataSource = dt;
                cbEmpresa2.DisplayMember = "headOffice";
                cbEmpresa2.ValueMember = "headOffice_id";
                cbEmpresa2.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

        }


        //Preenchendo combobox de justificativas
        private void JustificationListGridCombobox()
        {

            try
            {
                DataTable dt = null;

                dt = jusModel.JustificationListGridCombobox();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cbJustificativas.DataSource = dt;
                cbJustificativas.DisplayMember = "justification";
                cbJustificativas.ValueMember = "justification_id";
                cbJustificativas.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar Justificativas " + ex.Message);
            }

        }

        //Preenchendo combobox de Categoria de justificativas
        private void JustificationCategoryCombobox()
        {

            try
            {
                DataTable dt = null;

                dt = jusCategoryModel.JustificationCategoryCombobox();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cdCategoJus.DataSource = dt;
                cdCategoJus.DisplayMember = "category";
                cdCategoJus.ValueMember = "category_id";
                cdCategoJus.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar Categoria de Justificativas " + ex.Message);
            }

        }

        
        private void cdInserirJust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cdCategoJus.SelectedIndex) < 3 )
            {
                cbJustificativas.Enabled = true;
                JustificationListGridCombobox();
            }
            else
            {
                cbJustificativas.SelectedValue = 0;
                cbJustificativas.Enabled = false;
            }

            if (cdCategoJus.SelectedIndex == 0)
            {

                SelectIndexCondiction();
            }

            if (cdCategoJus.SelectedIndex == 1)
            {
                             
                btnTotalH.Visible = false;
                gBTipo2.Enabled = true;
                gBTipo2.Visible = true;
                DTDiaComp.Visible = false;
                groupBox4.Visible = false;

                rDia_CheckedChanged(null,null);
                this.groupBox2.Size = new System.Drawing.Size(1115, 272);
                this.groupBox1.Location = new System.Drawing.Point(77, 291);
                this.groupBox3.Location = new System.Drawing.Point(77, 386);
            }

            if (cdCategoJus.SelectedIndex == 2)
            {
                rPeriodo.Checked = true;
                gBTipo2.Enabled = false;
                btnTotalH.Visible = false;
                gBTipo2.Visible = true;
                rDia_CheckedChanged(null, null);
                this.groupBox2.Size = new System.Drawing.Size(1115, 272);
                this.groupBox1.Location = new System.Drawing.Point(77, 291);
                this.groupBox3.Location = new System.Drawing.Point(77, 386);
            }
            if (cdCategoJus.SelectedIndex == 3)
            {
                DTDiaComp.Visible = false;
                rDia.Checked = true;
                rDia.Enabled = true;
                gBTipo2.Enabled = false;
                btnTotalH.Visible = false;
                gBTipo2.Visible = true;
                rDia_CheckedChanged(null, null);
                this.groupBox2.Size = new System.Drawing.Size(1115, 272);
                this.groupBox1.Location = new System.Drawing.Point(77, 291);
                this.groupBox3.Location = new System.Drawing.Point(77, 386);
            }
            if (cdCategoJus.SelectedIndex == 4)
            {
                rbDia.Checked = true;

                rbHora_CheckedChanged(null, null);

            }


        }

        private void SelectIndexCondiction()
        {
            lbDataIn.Visible = false;
            lbFinal.Visible = false;
            gBTipo2.Visible = false;
            groupBox4.Visible = false;
            DataInicial.Visible = false;
            DataFinal.Visible = false;
            DataComp1.Visible = false;

            btnTotalH.Visible = true;
            TotalHoras.Visible = true;
            TotalHoras.Enabled = true;
            label13.Visible = true;
            Data.Enabled = true;
            Data.Enabled = true;
            TotalHoras.Enabled = true;
            this.groupBox2.Size = new System.Drawing.Size(1115, 211);
            this.groupBox1.Location = new System.Drawing.Point(77, 230);
            this.groupBox3.Location = new System.Drawing.Point(77, 325);
        }

        private void rbHora_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDia.Checked == true)
            {
                lbTotalHoras.Visible = false;
                DTDiaComp.Visible = false;
                groupBox4.Visible = true;
                lbDataIn.Visible = false;
                lbFinal.Visible = false;
                gBTipo2.Visible = false;
                DataComp1.Visible = true;
                DataInicial.Visible = false;
                DataFinal.Visible = false;
                btnTotalH.Visible = true;
                TotalHoras.Visible = true;
                label13.Visible = true;
                Data.Enabled = true;

                this.groupBox2.Size = new System.Drawing.Size(1115, 211);
                this.groupBox1.Location = new System.Drawing.Point(77, 230);
                this.groupBox3.Location = new System.Drawing.Point(77, 325);

            }
            else
            {
                rbHora.Checked = true;

                lbTotalHoras.Visible = true;
                DTDiaComp.Visible = true;
                groupBox4.Visible = true;
                lbDataIn.Visible = false;
                lbFinal.Visible = false;
                gBTipo2.Visible = false;
                DataComp1.Visible = false;
                DataInicial.Visible = false;
                DataFinal.Visible = false;
                btnTotalH.Visible = true;
                TotalHoras.Visible = true;
                label13.Visible = true;
                Data.Enabled = true;
                lbDatas.Visible = false;
                this.groupBox2.Size = new System.Drawing.Size(1115, 247);
                this.groupBox1.Location = new System.Drawing.Point(77, 255);
                this.groupBox3.Location = new System.Drawing.Point(77, 356);

            
            }
        }

        /*
         *========================================================================================================
         Nesse forme existem vários elementos sobrepostos
        *=========================================================================================================
        */

        private void FieldValidation()
        {
            if (String.IsNullOrEmpty(TotalHoras.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = cdCategoJus.SelectedIndex;
                switch (index)
                {
                    case 0:
                        groupBox4.Visible = false;
                        insertJussClass.User_id = Convert.ToInt32(cbNome.SelectedValue);
                        insertJussClass.HeadOffice_id = Convert.ToInt32(cbEmpresa2.SelectedValue);
                        insertJussClass.BranchHeadOffice_id = Convert.ToInt32(cbBranch2.SelectedValue);
                        insertJussClass.Category_id = Convert.ToInt32(cdCategoJus.SelectedValue);
                        insertJussClass.Justification_id = Convert.ToInt32(cbJustificativas.SelectedValue);
                        if (TotalHoras.Text == "") { insertJussClass.Hours = Convert.ToDateTime("01/01/0001 00:00:00 "); } else { insertJussClass.Hours = Convert.ToDateTime(TotalHoras.Text); };
                        insertJussClass.DateTimeJus = Convert.ToDateTime(Data.Text);
                        insertJussClass.Observation = txtjus.Text;
                        insertJussClass.UserCreation_id1 = UserCache.DBUserID;
                        insertJussClass.BeginDate = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.EndDate2 = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Created_at = DateTime.Now;
                        insertJussClass.Updated_at = DateTime.Now;

                        inJusModel.InsertCorrectionInTheTable(insertJussClass);

                        break;

                    case 1:

                        insertJussClass.User_id = Convert.ToInt32(cbNome.SelectedValue);
                        insertJussClass.HeadOffice_id = Convert.ToInt32(cbEmpresa2.SelectedValue);
                        insertJussClass.BranchHeadOffice_id = Convert.ToInt32(cbBranch2.SelectedValue);
                        insertJussClass.Category_id = Convert.ToInt32(cdCategoJus.SelectedValue);
                        insertJussClass.Justification_id = Convert.ToInt32(cbJustificativas.SelectedValue);
                        insertJussClass.Hours = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.DateTimeJus = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Observation = txtjus.Text;
                        insertJussClass.UserCreation_id1 = UserCache.DBUserID;
                        insertJussClass.BeginDate = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.EndDate2 = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Created_at = DateTime.Now;
                        insertJussClass.Updated_at = DateTime.Now;

                        if (rDia.Checked == true)
                        {
                            insertJussClass.DateTimeJus = Convert.ToDateTime(Data.Text);
                        }
                        else if(rPeriodo.Checked == true)
                        {
                            insertJussClass.BeginDate = Convert.ToDateTime(DataInicial.Text);
                            insertJussClass.EndDate2 = Convert.ToDateTime(DataFinal.Text);
                        }
                        inJusModel.InsertCorrectionInTheTable(insertJussClass);
                        break;

                    case 2:
                        insertJussClass.User_id = Convert.ToInt32(cbNome.SelectedValue);
                        insertJussClass.HeadOffice_id = Convert.ToInt32(cbEmpresa2.SelectedValue);
                        insertJussClass.BranchHeadOffice_id = Convert.ToInt32(cbBranch2.SelectedValue);
                        insertJussClass.Category_id = Convert.ToInt32(cdCategoJus.SelectedValue);
                        insertJussClass.Justification_id = Convert.ToInt32(cbJustificativas.SelectedValue);
                        insertJussClass.Hours = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.DateTimeJus = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Observation = txtjus.Text;
                        insertJussClass.UserCreation_id1 = UserCache.DBUserID;
                        insertJussClass.BeginDate = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.EndDate2 = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Created_at = DateTime.Now;
                        insertJussClass.Updated_at = DateTime.Now;               
                        insertJussClass.BeginDate = Convert.ToDateTime(DataInicial.Text);
                        insertJussClass.EndDate2 = Convert.ToDateTime(DataFinal.Text);
                        
                        inJusModel.InsertCorrectionInTheTable(insertJussClass);

                        break;
                    case 3:
                        insertJussClass = new();
                        insertJussClass.User_id = Convert.ToInt32(cbNome.SelectedValue);
                        insertJussClass.HeadOffice_id = Convert.ToInt32(cbEmpresa2.SelectedValue);
                        insertJussClass.BranchHeadOffice_id = Convert.ToInt32(cbBranch2.SelectedValue);
                        insertJussClass.Category_id = Convert.ToInt32(cdCategoJus.SelectedValue);
                        insertJussClass.Justification_id = Convert.ToInt32(cbJustificativas.SelectedValue);
                        insertJussClass.Hours = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.DateTimeJus = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.JustDateCorrence = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Observation = txtjus.Text;
                        insertJussClass.UserCreation_id1 = UserCache.DBUserID;
                        insertJussClass.BeginDate = Convert.ToDateTime(Data.Text);
                        insertJussClass.EndDate2 = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Created_at = DateTime.Now;
                        insertJussClass.Updated_at = DateTime.Now;

                        inJusModel.InsertCorrectionInTheTable(insertJussClass);
                        break;
                    case 4:
                        insertJussClass.User_id = Convert.ToInt32(cbNome.SelectedValue);
                        insertJussClass.HeadOffice_id = Convert.ToInt32(cbEmpresa2.SelectedValue);
                        insertJussClass.BranchHeadOffice_id = Convert.ToInt32(cbBranch2.SelectedValue);
                        insertJussClass.Category_id = Convert.ToInt32(cdCategoJus.SelectedValue);
                        insertJussClass.Justification_id = Convert.ToInt32(cbJustificativas.SelectedValue);                
                        insertJussClass.Observation = txtjus.Text;
                        insertJussClass.UserCreation_id1 = UserCache.DBUserID;
                 
                        if (rbHora.Checked == true)
                        {
                            DataComp1.Visible = false;
                            if (TotalHoras.Text == "") { insertJussClass.Hours = Convert.ToDateTime("01/01/0001 00:00:00 "); } else { insertJussClass.Hours = Convert.ToDateTime(TotalHoras.Text); };
                            insertJussClass.DateTimeJus = Convert.ToDateTime(Data.Text);
                            insertJussClass.CompensatedDay = Convert.ToDateTime(DTDiaComp.Text);
                        }
                        else if (rbDia.Checked == true)
                        {
                            DataComp1.Visible = true;
                            insertJussClass.CompensatedDay = Convert.ToDateTime(DataComp1.Text);
                            insertJussClass.DateTimeJus = Convert.ToDateTime(Data.Text);
                        }

                        insertJussClass.BeginDate = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.EndDate2 = Convert.ToDateTime("01/01/0001 00:00:00 ");
                        insertJussClass.Created_at = DateTime.Now;
                        insertJussClass.Updated_at = DateTime.Now;

                        inJusModel.InsertCorrectionInTheTable(insertJussClass);                   
                        break;
            
                }
                CleareFields();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CleareFields()
        {
            BtnSalvar.Enabled = false;
            cdCategoJus.Enabled = false;
            cbNome.SelectedValue = 0;
            cbEmpresa2.SelectedValue = 0;
            cbBranch2.SelectedValue = 0;
            cdCategoJus.SelectedValue = 0;
            cbJustificativas.SelectedValue = 0;
            TotalHoras.Clear();
            txtjus.Clear();
            Data.ResetText();
            SelectIndexCondiction();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbBranch2.DataSource = null;
                string erroSelectedValue = cbEmpresa2.SelectedValue.ToString();


                if (erroSelectedValue.Length != 23)
                {

                    cbBranch2.DataSource = headOfficeModel.BranchHeadOfficeListModel(Convert.ToInt32(cbEmpresa2.SelectedValue));
                    cbBranch2.DisplayMember = "branchName";
                    cbBranch2.ValueMember = "branchHeadOffice_id";
                    cbBranch2.SelectedValue = 1;


                }
                else
                {

                    
                    cbBranch2.DataSource = headOfficeModel.BranchHeadOfficeListModel(0);
                    cbBranch2.DisplayMember = "branchName";
                    cbBranch2.ValueMember = "branchHeadOffice_id";

                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abrir formulario para inserção
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

        private void ListInsertJustification()
        {
            DateFormatUS();
            dgInsJust.DataSource = inJusModel.CategoryListGridModel(insertJussClass);
            dgInsJust.Columns[0].Visible = false;
            dgInsJust.Columns[1].HeaderText = "Nome";
            dgInsJust.Columns[2].Visible = false;
            dgInsJust.Columns[3].HeaderText = "Empresa";
            dgInsJust.Columns[4].Visible = false;
            dgInsJust.Columns[5].HeaderText = "Filial";
            dgInsJust.Columns[6].Visible = false;
            dgInsJust.Columns[7].HeaderText = "Justificativa";
            dgInsJust.Columns[8].Visible = false;
            dgInsJust.Columns[9].HeaderText = "Categoria";
            dgInsJust.Columns[10].HeaderText = "Data";

    

            DateFormatBR();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            if (dtEnd.Value.Date < dtStart.Value.Date)
            {
                MessageBox.Show("A data final não pode ser menor que a data inicial!", "Atenção! ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSearch.Text = "";
                dtStart.Focus();
                return;
            }

            DateValidaton();
            DateFormatUS();
            headOfficeSelectedValueValidation();
            insertJussClass.UserName = txtSearch.Text;
            insertJussClass.HeadOffice_id = Convert.ToInt32(cbEmpresa.SelectedValue);
            insertJussClass.BranchHeadOffice_id = Convert.ToInt32(cbBranch.SelectedValue);
            insertJussClass.StartDate = dtStart.Text;
            insertJussClass.EndDate = dtEnd.Text;
            ListInsertJustification();
            DateFormatBR();
        }

        //Validação de data
        private void DateValidaton()
        {
            DateFormatUS();
        }
        //Habilitação da data no dropCalendar
        private void dtStart_DropDown(object sender, EventArgs e)
        {
            txtRe.Enabled = true;
            txtSearch.Enabled = true;
            DateFormatUS();
        }
        //Validação de combobox de empresas
        private void headOfficeSelectedValueValidation()
        {
            if (Convert.ToInt32(cbEmpresa.SelectedValue) < 1)
            {

                MessageBox.Show("Selecione uma Empresa apara continuar!", "Atenção! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Text = "";
                txtRe.Text = "";
                dtStart.Focus();

            }
        }

        private void txtRe_TextChanged(object sender, EventArgs e)
        {
            if (dtEnd.Value.Date < dtStart.Value.Date)
            {
                MessageBox.Show("A data final não pode ser menor que a data inicial!", "Atenção! ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSearch.Text = "";
                txtRe.Text = "";
                dtStart.Focus();
                return;
            }

            DateValidaton();
            DateFormatUS();
            headOfficeSelectedValueValidation();
            insertJussClass.User_re = txtRe.Text;
            insertJussClass.HeadOffice_id = Convert.ToInt32(cbEmpresa.SelectedValue);
            insertJussClass.BranchHeadOffice_id = Convert.ToInt32(cbBranch.SelectedValue);
            insertJussClass.StartDate = dtStart.Text;
            insertJussClass.EndDate = dtEnd.Text;
            ListInsertJustification();
            DateFormatBR();
        }

        private void dgInsJust_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnSalvar.Enabled = true;
            cdCategoJus.Enabled = true;
            txtjus.Enabled = true;
            cbNome.SelectedValue = Convert.ToInt32(dgInsJust.Rows[e.RowIndex].Cells[0].Value.ToString());
            cbEmpresa2.SelectedValue = Convert.ToInt32(dgInsJust.Rows[e.RowIndex].Cells[2].Value.ToString());

            
            if (dgInsJust.Rows[e.RowIndex].Cells[4].Value.ToString() == "")
            {
                cbBranch2.SelectedValue = 0;
            }
            else
            {
                dgInsJust.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
         

        }


        private void rDia_CheckedChanged(object sender, EventArgs e)
        {
            //Radio da class afastamento

            if (rDia.Checked)
            {
                DataInicial.Visible = true;
                DataFinal.Visible = false;
                lbDatas.Visible = true;
                lbDataIn.Visible = false;
                lbFinal.Visible = false;
            }
            else if (rPeriodo.Checked)
            {
                lbDataIn.Visible = true;
                lbFinal.Visible = true;
                lbDatas.Visible = false;
                DataInicial.Visible = true;
                DataFinal.Visible = true;
            }
        }

    
    }
}
