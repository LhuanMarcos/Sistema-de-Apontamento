using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_MODERNISTA.Models;
using GUI_MODERNISTA.Controller;
using GUI_MODERNISTA.Entities;
using GUI_PONTO.Views;


namespace GUI_MODERNISTA.Views
{
    public partial class frmDepartamento : Form
    {
        DepartmentModel departamentModel = new DepartmentModel();
        HeadOfficeModel headOfficeModel = new HeadOfficeModel();
        DepartmentController departmentController = new DepartmentController();
        Department dado = new Department();
        int departmentStatus = 1;
        private int lastDepartment_id;
        private int branch_id;
        private int btnSearchChekED = 1;



        private int headOffice_id;
        private int branchHeadOffice_id;
        private int department_id;
        private int activeSearch;




        string created = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        public frmDepartamento()
        {
            InitializeComponent();
            DisableGroupBoxStatus();
            DepartamentListView();
            HeadOfficeListView();
            departamentModel.DepartmentList();
            btnSearchChecked.Checked = true;
            


        }

        //Desabilita o GroupBox de Status quando o Método for POST
        private void DisableGroupBoxStatus()
        {
            groupBoxSituation.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //mensagem de sucesso
        private void OpenSuccessMessage()
        {
            frmMensagenDeSucesso msn = new frmMensagenDeSucesso();
            
            msn.Show();
        }



        //Preenchendo combobox com Empresas
        private void HeadOfficeListView()
        {

            try
            {
                DataTable dt = null;

                dt = departamentModel.HeadOfficeListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                comboBoxHeadOffice.DataSource = dt;
                comboBoxHeadOffice.DisplayMember = "headOffice";
                comboBoxHeadOffice.ValueMember = "headOffice_id";
                comboBoxHeadOffice.SelectedValue = 0;

                radioButtonSituationAct.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

        }

        private void RadioButtonStatusConversion()
        {

            if (radioButtonSituationAct.Checked != true)
            {
                departmentStatus = 0;
            }

        }

        private int ConvertRadioButtonSearchCheked()
        {

            if (btnSearchChecked.Checked == true)
            {
                btnSearchChekED = 1;
            }
            else
            {
                btnSearchChekED = 0;
            }
            return btnSearchChekED;
        }




        // Salvacategiria no Banco de Dados
        public void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                dado.Departamentt = txtDepartamentt.Text;
                dado.DepartmentStatus = departmentStatus;
                dado.Created_at = Convert.ToDateTime(created);
                dado.Updated_at = Convert.ToDateTime(created);
                lastDepartment_id = departamentModel.SaveDepartmentModel(dado);

                DepartmentSaveInPivotTable();
                DepartamentListView();
                OpenSuccessMessage();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }
        //salvar dados na pivot
        private void DepartmentSaveInPivotTable()
        {
            try
            {
                branch_id = Convert.ToInt32(cbBranchOffice.SelectedValue);

                headOffice_id = Convert.ToInt32(comboBoxHeadOffice.SelectedValue);
                branchHeadOffice_id = branch_id;
                department_id = lastDepartment_id;

                departamentModel.DepartmentSaveInPivotTable(headOffice_id, branchHeadOffice_id, department_id);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }

        private void dgDepartament_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Preenche o combobox de Filial de acordo com o id da empresa
        private void comboBoxHeadOffice_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cbBranchOffice.DataSource = null;
                string erroSelectedValue = comboBoxHeadOffice.SelectedValue.ToString();
                if (erroSelectedValue.Length != 23)
                {
                    cbBranchOffice.Enabled = true;
                    cbBranchOffice.DataSource = headOfficeModel.BranchHeadOfficeListModel(Convert.ToInt32(comboBoxHeadOffice.SelectedValue));
                    cbBranchOffice.DisplayMember = "branchName";
                    cbBranchOffice.ValueMember = "branchHeadOffice_id";

                    _ = cbBranchOffice.Items.Count > 0 ? cbBranchOffice.Enabled = true : cbBranchOffice.Enabled = false;

                }
                else
                {

                    cbBranchOffice.Enabled = true;
                    cbBranchOffice.DataSource = headOfficeModel.BranchHeadOfficeListModel(0);
                    cbBranchOffice.DisplayMember = "branchName";
                    cbBranchOffice.ValueMember = "branchHeadOffice_id";
                    _ = cbBranchOffice.Items.Count > 0 ? cbBranchOffice.Enabled = true : cbBranchOffice.Enabled = false;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        //formatação de cor "Ativo" e "inativo" para verde e vermelho
        private void dgDepartment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgDepartment.Columns[e.ColumnIndex].Name == "status")
            {
                dgDepartment.Columns["status"].SortMode = DataGridViewColumnSortMode.NotSortable;

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

        //Busca reativa

        private void DepartamentListView()
        {
            try
            {
                dgDepartment.DataSource = departamentModel.DepartmentList();
                dgDepartment.Columns[0].Visible = false;//ID
                dgDepartment.Columns[1].HeaderText = "Departamento";
                dgDepartment.Columns[2].HeaderText = "Status";
                dgDepartment.Columns[3].HeaderText = "Data de Cadastro";


                dgDepartment.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                throw;
            }

        }

        //pesquisa
        private void DepartamentListbuscaView(Department dado)
        {
            try
            {
                dgDepartment.DataSource = departamentModel.DepartmentListSearch(dado);
                dgDepartment.Columns[0].Visible = false;//ID
                dgDepartment.Columns[1].HeaderText = "Departamento";
                dgDepartment.Columns[2].HeaderText = "Status";
                dgDepartment.Columns[3].HeaderText = "Data de Cadastro";

                dgDepartment.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                throw;
            }

        }
        //textbox de busca de departamento (reativa)
        private void TextBoxSearchOffice_TextChanged(object sender, EventArgs e)
        {
            
            try
            {

                dado.Departamentt = textBoxSearchOffice.Text;
                ConvertRadioButtonSearchCheked();
                dado.DepartmentStatus = btnSearchChekED;
                int status = ConverteRadioActive();
                dgDepartment.DataSource = departamentModel.DepartamentListModel(dado);
                dgDepartment.Columns[0].Visible = false;//ID
                dgDepartment.Columns[1].HeaderText = "Departamento";              
                
                dgDepartment.Columns[2].HeaderText = "Status";
                dgDepartment.Columns[3].HeaderText = "Data de Cadastro";

            }
            catch (Exception)
            {

                throw;
            }
        }

       
        private int ConverteRadioActive()
        {
            if (btnSearchChecked.Checked == false)
            {
                activeSearch = 0;
            }
            else
            {
                activeSearch = 1;
            }

            return activeSearch;
        }

        //double click para subir informações para editar
        private void dgDepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            buttonSave.Enabled = false;
            comboBoxHeadOffice.Enabled = false;
            HeadOfficeListView();
            radioButtonSituationAct.Enabled = true;
            radioButtonSituationInc.Enabled = true;
            groupBoxSituation.Enabled = true;
            
            string checkedStatus = dgDepartment.Rows[e.RowIndex].Cells[2].Value.ToString();

            _ = "Ativo".Equals(checkedStatus) ? radioButtonSituationAct.Checked = true : radioButtonSituationInc.Checked = true;

            txtDepartamentt.Text = dgDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
            dado.Departament_id = Convert.ToInt32(dgDepartment.Rows[e.RowIndex].Cells[0].Value.ToString());

        }
        //botao "editar"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMensagenDeSucesso msn = new();
            try
            {          
            DateTime dateTime;
            dateTime = DateTime.Now;
            dado.Updated_at = dateTime;
            dado.Departamentt = txtDepartamentt.Text;
            dado.Departament_id = dado.Departament_id;
            dado.DepartmentStatus = radioButtonSituationAct.Checked == true ? 1 : 0;
            departamentModel.DepartmentListEdit(dado);
            DepartamentListView();
            btnEdit.Enabled = false;
            buttonSave.Enabled = true;
            comboBoxHeadOffice.Enabled = true;
            radioButtonSituationAct.Checked = true;
            
            groupBoxSituation.Enabled = false;            
            msn.labelChanged("  Alterado com sucesso!");
            msn.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao listar " + ex.Message);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dado.Departamentt = txtDepartamentt.Text;
        }

        
        //radio button "inativo" para buscar departamento inativos 
        private void radioButtonSearchInc_CheckedChanged(object sender, EventArgs e)
        {
            DepartamentListbuscaView(dado);
        }
        //radio button "ativo" para buscar departamento ativos 
        private void btnSearchChecked_CheckedChanged(object sender, EventArgs e)
        {
            DepartamentListView();
        }

        
    }
}
