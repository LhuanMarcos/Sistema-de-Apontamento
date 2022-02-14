using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_MODERNISTA.Entities;
using System.Windows.Forms;
using GUI_PONTO.Models;
using GUI_MODERNISTA.Models;
using GUI_PONTO.Views;

namespace GUI_MODERNISTA.Views
{
    public partial class frmFeriado : Form
    {

        Holiday dado = new();
        HolidayModel holidayModel = new();
        private int btnSearchChekED = 1;
        HeadOfficeModel headOfficeModel = new HeadOfficeModel();
        private int lastHolidayIdSave;
        private int state = 0;
        private int fix = 0;
        private string dateString;

        private int branch_id;
        private int headOffice_id;
        private int branchHeadOffice_id;
        private int holiday_id;
        public frmFeriado()
        {
            InitializeComponent();
            HolidayListView(dado);
            HolidayHeadOfficeListView();



        }

        //listagem na tabela
        private void HolidayListView(Holiday dado)
        {
            try
            {
               

                dgView.DataSource = holidayModel.HolidayListModel(dado);
                dgView.Columns[0].HeaderText = "Nome";
                dgView.Columns[1].Visible = false;//id
                dgView.Columns[2].HeaderText = "Tipo";
                dgView.Columns[3].Visible = false;
                dgView.Columns[4].Visible = false;
                dgView.Columns[5].HeaderText = "Matriz";

                dgView.Columns[6].HeaderText = "Filial";
                dgView.Columns[7].Visible = false;

                dgView.Columns[8].HeaderText = "Fixo";
                dgView.Columns[9].HeaderText = "Data";

                dgView.AllowUserToAddRows = false;




            }
            catch (Exception)
            {
                throw;
            }
        }
        //radio button de mostrar busca municipal
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            HolidaytListMunibuscaView(dado);
        }
        //radio button de mostrar busca nacional
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HolidaytListNacibuscaView(dado);
        }

      
        //carregar formulario de "feriado" 
        private void frmCadastroFeriado_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        //grid view de feriado municipal
        private void HolidaytListMunibuscaView(Holiday dado)
        {
            try
            {
                dgView.DataSource = holidayModel.HolidayListMuniModel(dado);
                dgView.Columns[0].HeaderText = "Nome";
                dgView.Columns[1].Visible = false;//id
                dgView.Columns[2].HeaderText = "Tipo";
                dgView.Columns[3].Visible = false;
                dgView.Columns[4].HeaderText = "Matriz";
                dgView.Columns[5].HeaderText = "Filial";

                dgView.Columns[6].HeaderText = "Fixo";
                dgView.Columns[7].HeaderText = "Data";

                dgView.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                throw;
            }

        }
        //grid view de feriado municipal
        private void HolidaytListNacibuscaView(Holiday dado)
        {
            try
            {
                dgView.DataSource = holidayModel.HolidayListNaciModel(dado);
                dgView.Columns[0].HeaderText = "Nome";
                dgView.Columns[1].Visible = false;//id
                dgView.Columns[2].HeaderText = "Tipo";
                dgView.Columns[3].Visible = false;
                dgView.Columns[4].HeaderText = "Matriz";
                dgView.Columns[5].HeaderText = "Filial";

                dgView.Columns[6].HeaderText = "Fixo";
                dgView.Columns[7].HeaderText = "Data";

                dgView.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                throw;
            }

        }
        //função pra identificar qual radio button ta checado em "busca"
        private int ConvertRadioButtonSearchCheked()
        {

            if (radioButton1.Checked == true)
            {
                btnSearchChekED = 1;
            }
            else
            {
                btnSearchChekED = 0;
            }
            return btnSearchChekED;
        }

        //comboBox de "busca" reativa 
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dado.HolidayName = comboBox1.Text;
                ConvertRadioButtonSearchCheked();
                dado.Type = btnSearchChekED;
                dgView.DataSource = holidayModel.HolidayListModelReact(dado);
                dgView.Columns[0].Visible = false;
                dgView.Columns[1].HeaderText = "Name";
                dgView.Columns[2].HeaderText = "Tipo";
                dgView.Columns[3].HeaderText = "Data de Cadastro";

            }
            catch (Exception)
            {

                throw;
            }
        }
        //preencher 2 clicks
        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Visible = true;
            buttonSave.Visible = false;
            btnDelete.Visible = true;

            string checkedStatus = dgView.Rows[e.RowIndex].Cells[2].Value.ToString();

            string checkedStatusFix = dgView.Rows[e.RowIndex].Cells[8].Value.ToString();

            _ = "Nacional".Equals(checkedStatus) ? rbState.Checked = true : radioButton6.Checked = true;

            _ = "Sim".Equals(checkedStatusFix) ? rbFix.Checked = true : radioButton4.Checked = true;

            txtHolidayName.Text = dgView.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbHeadOffice.Text = dgView.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtHoliday.Text = dgView.Rows[e.RowIndex].Cells[9].Value.ToString();
            dado.Holiday_id = Convert.ToInt32(dgView.Rows[e.RowIndex].Cells[1].Value.ToString());

        }
        //função presente no comboBox de "empresa" para buscar empresa cadastradas
        private void HolidayHeadOfficeListView()
        {

            try
            {
                DataTable dt = null;

                dt = holidayModel.HolidayHeadOfficeListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cbHeadOffice.DataSource = dt;
                cbHeadOffice.DisplayMember = "headOffice";
                cbHeadOffice.ValueMember = "headOffice_id";
                cbHeadOffice.SelectedValue = 0;

                //radioButtonSituationAct.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

        }

        //buscar filial de acordo com empresa selecionada no comboBox de "empresa"
        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbBranch.DataSource = null;
                string erroSelectedValue = cbHeadOffice.SelectedValue.ToString();
                if (erroSelectedValue.Length != 23)
                {
                    cbBranch.Enabled = true;
                    cbBranch.DataSource = headOfficeModel.BranchHeadOfficeListModel(Convert.ToInt32(cbHeadOffice.SelectedValue));
                    cbBranch.DisplayMember = "branchName";
                    cbBranch.ValueMember = "branchHeadOffice_id";

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
            catch (Exception)
            {
                throw;
            }
        }
        
        string created = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        //botao "salvar"
        private void buttonSave_Click(object sender, EventArgs e)
        {           
               try
                {
                    if (EmpityField() == true)
                    {
                    dado.HolidayName = txtHolidayName.Text;                   
                    dado.Created_at = Convert.ToDateTime(created);
                    dado.Updated_at = Convert.ToDateTime(created);
                    HolidaySaveView(dado);
                    insertInToPivotLinkCompany();
                        
                    }
                }
                catch (Exception)
                {
                    throw;
               }
            HolidayListView(dado);
        }
        //mensagem de sucesso
        private void OpenSuccessMessage()
        {
            frmMensagenDeSucesso msn = new frmMensagenDeSucesso();

            msn.Show();
        }
        //setar valor ao radio button "tipo"
        private int TypeOfState()
        {
            if (rbState.Checked == true)
            {
                state = 1;
            }
            return state;
        }
        //setar valor ao radio button "fixo"
        private int TypeOfFix()
        {
            if (rbFix.Checked == true)
            {
                fix = 1;
            }
            return fix;
        }
        //função para salvar dados preenchidos
        private void HolidaySaveView(Holiday dado)
        {
            try
            {
                TypeOfState();
                TypeOfFix();
                dado.HolidayName = txtHolidayName.Text;
                dado.Type = state;
                dado.StatusFixed = fix;
                dado.Date = Convert.ToDateTime(dtHoliday.Text);              
                lastHolidayIdSave = holidayModel.HolidaySaveModel(dado);
                OpenSuccessMessage();

            }
            catch (Exception)
            {
                throw; ;
            }
        }
        //inserir dados na tabela pivot
        private void insertInToPivotLinkCompany()
        {
            try
            {
                branch_id = Convert.ToInt32(cbBranch.SelectedValue);

                headOffice_id = Convert.ToInt32(cbHeadOffice.SelectedValue);
                branchHeadOffice_id = branch_id;
                holiday_id = lastHolidayIdSave;

                holidayModel.HolidaytSaveInPivotTable(headOffice_id, branchHeadOffice_id, holiday_id);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }
        //validar se tem campos nao preenchidos
        private bool EmpityField()
        {
            if (
                txtHolidayName.Text == "" 

                )
            {

                const string message = "Todos os campos obrígatórios devem ser preenchidos!";
                const string caption = "Atenção!";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);

                return false;

            }
            return true;
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
                
                dado.HolidayName = txtHolidayName.Text;
                dado.Holiday_id = dado.Holiday_id;
                dado.Type = rbState.Checked == true ? 1 : 0;
                dado.StatusFixed = rbFix.Checked == true ? 1 : 0;
                dado.Date = Convert.ToDateTime(dtHoliday.Text);

                holidayModel.HolidayListEdit(dado);
                HolidayListView(dado);
                btnEdit.Enabled = false;
                buttonSave.Enabled = true;

                msn.labelChanged("  Alterado com sucesso!");
                msn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar " + ex.Message);
            }
            HolidayListView(dado);
        }
        //botao "excluir"
        private void btnDelete_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show("Tem certeza que deseja excluir este feriado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                holidayModel.PivotDelete(dado);
                holidayModel.HolidayDelete(dado);
            }
            else
            {
                MessageBox.Show("Cancelado a exlusão");
            }

            HolidayListView(dado);
        }

        //botao "calcelar"
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
