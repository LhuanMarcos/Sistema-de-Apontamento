using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_MODERNISTA.Controller;
using GUI_MODERNISTA.Entities;
using GUI_MODERNISTA.Models;
using GUI_PONTO.Controller;
using GUI_PONTO.Entities;
using GUI_PONTO.Views;

namespace GUI_MODERNISTA.Views
{
    public partial class frmMatriz : Form
    {
        
        HeadOfficeModel headoficceModel = new HeadOfficeModel();
        DepartmentModel departmentModel = new();
        UserModel userModel = new UserModel();
        HeadOffice headOffice = new();
        Addres addres = new();
        private int LastInsertedId;
        private string HEADOFFICE_ID = "0";
        public frmMatriz()
        {
            InitializeComponent();
            HeadOfficeList(1, "");
            disableRadioB();

        }
        private void disableRadioB()
        {
            rdStatusAt.Enabled = false;
            rdStatusAt.Enabled = false;
        }

        //mensagem de sucesso
        private void OpenSuccessMessage()
        {
            frmMensagenDeSucesso msn = new frmMensagenDeSucesso();
            msn.Show();
        }

        private void HeadOfficeList(int status, string headOffice)
        {
            dgHeadOffice.DataSource = headoficceModel.HeadOfficeList(status, headOffice);
            dgHeadOffice.Columns[0].Visible = false;//ID
            dgHeadOffice.Columns[1].HeaderText = "Nome";
            dgHeadOffice.Columns[2].HeaderText = "CNPJ";
            dgHeadOffice.Columns[3].HeaderText = "Status";
            dgHeadOffice.Columns[4].HeaderText = "Data de Cadastro";
            dgHeadOffice.Columns[5].Visible = false;//id headOffice da tabela "addres"
            dgHeadOffice.Columns[6].Visible = false;//cep
            dgHeadOffice.Columns[7].Visible = false;//numero
            dgHeadOffice.Columns[8].Visible = false;//rua
            dgHeadOffice.Columns[9].Visible = false;//complemento
            dgHeadOffice.Columns[10].Visible = false;//bairro
            dgHeadOffice.Columns[11].Visible = false;//cidade
            dgHeadOffice.Columns[12].Visible = false;//uf

            dgHeadOffice.AllowUserToAddRows = false;
        }

       
        //butao salvar
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                headOffice.Headoffice = textMatriz.Text;
                headOffice.SituationStatus = 1;
                headOffice.Cnpj = txtCnpj.Text;
                headOffice.Created_at = DateTime.Today;
                headOffice.Updated_at = DateTime.Today;

                
                int company_id = headoficceModel.InsertHeadOfficeInToDatabaseFromModel(headOffice);
                addres.HeadOffice_id = company_id;
                HeadOfficeList(1, "");
                textMatriz.Text = "";
                txtCnpj.Text = "";

                frmMensagenDeSucesso msnSuccess = new();
                msnSuccess.Show();
            }
            catch (Exception)
            {
                throw;
            }

            AddresSaveView();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            frmFilial filial = new();
            filial.Show();
        }
        //salvar endereço
        private void AddresSaveView()
        {
            try
            {

                addres.Number = txttNumber.Text;
                addres.Street = txtStreet.Text;
                addres.District = txtDistrict.Text;
                addres.Location = txtLocation.Text;
                addres.Uf = txtUf.Text;
                addres.Complement = txtComplement.Text;
                addres.Cep = txtCep.Text;
                addres.Addres_id = addres.Addres_id;

                headoficceModel.addresHeadOfficeSaveModel(addres);
                OpenSuccessMessage();

            }
            catch (Exception)
            {
                throw; 
            }
        }
        //editar endereço
        private void AddresHeadOfficeEditView(Addres addres)
        {
            try
            {

                addres.Number = txttNumber.Text;
                addres.Street = txtStreet.Text;
                addres.District = txtDistrict.Text;
                addres.Location = txtLocation.Text;
                addres.Uf = txtUf.Text;
                addres.Complement = txtComplement.Text;
                addres.Cep = txtCep.Text;

                addres.HeadOffice_id = Convert.ToInt32(HEADOFFICE_ID);

                headoficceModel.addresUserEditModel(addres);

                OpenSuccessMessage();

            }
            catch (Exception)
            {
                throw; ;
            }
        }


        // editar de empresa
        private void button1_Click(object sender, EventArgs e)
        {
            AddresHeadOfficeEditView(addres);

            try
            {          
                headOffice.Headoffice = textMatriz.Text;
                headOffice.Cnpj = txtCnpj.Text;
                headOffice.SituationStatus = rdStatusAt.Checked == true ? 1 : 0;
                headOffice.Updated_at = DateTime.Today;
                headoficceModel.UpdateHeadOfficeFrommModel(headOffice);
                HeadOfficeList(1, "");
            }
            catch (Exception)
            {

                throw;
            }
    
        }

        //Preenche combobox para edição
        private void dgHeadOffice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonSave.Enabled = false;
            rdStatusIn.Enabled = true;
            rdStatusAt.Enabled = true;
            btnEdit.Enabled = true;
            buttonVincular.Enabled = false;

            string checkedStatus = dgHeadOffice.Rows[e.RowIndex].Cells[3].Value.ToString();
   
            _= "Ativo".Equals(checkedStatus) ? rdStatusAt.Checked = true : rdStatusIn.Checked = true;

            headOffice.HeadOffice_id = Convert.ToInt32(dgHeadOffice.Rows[e.RowIndex].Cells[0].Value.ToString());
            textMatriz.Text = dgHeadOffice.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCnpj.Text = dgHeadOffice.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCep.Text = dgHeadOffice.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtCep.Text = dgHeadOffice.Rows[e.RowIndex].Cells[6].Value.ToString();
            txttNumber.Text = dgHeadOffice.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtStreet.Text = dgHeadOffice.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtComplement.Text = dgHeadOffice.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtDistrict.Text = dgHeadOffice.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtLocation.Text = dgHeadOffice.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtUf.Text = dgHeadOffice.Rows[e.RowIndex].Cells[12].Value.ToString();
            
            
            
            HEADOFFICE_ID = dgHeadOffice.Rows[e.RowIndex].Cells[5].Value.ToString();


        }


        //Listagem de Empresas
        private void textBoxSerach_TextChanged(object sender, EventArgs e)
        {
            int status = 0;
            if (radioButtonSituationAct.Checked == true)
            {
                status = 1;
            }
     
            dgHeadOffice.DataSource = headoficceModel.HeadOfficeList(status, textBoxSerach.Text);
            dgHeadOffice.Columns[0].Visible = false;//id headOffice da tabela "headOffice"
            dgHeadOffice.Columns[1].HeaderText = "Nome";
            dgHeadOffice.Columns[2].HeaderText = "CNPJ";
            dgHeadOffice.Columns[3].HeaderText = "Status";
            dgHeadOffice.Columns[4].HeaderText = "Data de Cadastro";
            dgHeadOffice.Columns[5].Visible = false;//id headOffice da tabela "addres"
        }
        //Busca pelo Radio Button
        private void radioButtonSituationAct_CheckedChanged(object sender, EventArgs e)
        {
            HeadOfficeList(1, "");
        }
        //Busca pelo Radio Button
        private void radioButtonSituationInt_CheckedChanged(object sender, EventArgs e)
        {
            HeadOfficeList(0, "");
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();

                ds = AddressController.Addres(txtCep.Text);
                txtStreet.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtDistrict.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtLocation.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtUf.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Foi detectado um erro");
            }
        }
    }
    
}
