using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NITGEN.SDK.NBioBSP;
using GUI_PONTO.BSPTypeDef;
using GUI_PONTO;
using POINT.Models;
using GUI_MODERNISTA.Entities;
using GUI_MODERNISTA.Models;
using GUI_MODERNISTA.Controller;
using GUI_PONTO.Models;
using GUI_PONTO.Views;
using GUI_PONTO.Entities;
using ServiceStack;
using Refit;
using GUI_PONTO.Controller;

namespace GUI_PONTO
{
    public partial class frmUsuario : Form
    {
        HeadOfficeControloller headOfficeControloller = new HeadOfficeControloller();
        WorkShiftModel workShiftModel = new WorkShiftModel();
        DepartmentModel departmentModel = new DepartmentModel();
        PointModel pointModel = new PointModel();
        UserModel userModel = new UserModel();
        HeadOfficeModel headOfficeModel = new HeadOfficeModel();
        RoleModel roleModel = new RoleModel();
        User user = new User();
        Addres addres = new();

        private int status;


        private int situation = 1;
        private int pointRegister = 1;
        private int compTime = 1;
        private int verifyImput = 1;
        private int password = 1;
        private int markAllDay1 = 1;
        private int lastUserIdSave;
        private int activeSearch;
        private int headOffice_id = 1;
        private int userStatus = 1;
        private bool clickCep = false;

        private string USER_REID = "0";
        private string ADDRES_ID = "0";
        public string user_RE = null;

        private static string logradouro;



        string created = DateTime.Now.ToString();

        NBioAPI m_NBioAPI;
        NBioAPI.IndexSearch m_IndexSearch;


        public frmUsuario()
        {
            InitializeComponent();
            HeadOfficeListView();
            DepartmentListView();
            WorkShiftListView();
            roleListView();
            UserListView(user);
            departmentModel.DepartmentList();
            checkFingertech.Checked = true;



            m_NBioAPI = new NBioAPI();
            m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
        }
        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            uint ret = m_IndexSearch.InitEngine();
            if (ret != NBioAPI.Error.NONE)
            {
                DisplayErrorMsg(ret);
            }

        }


        #region Method GET
        //mensagem de sucesso
        private void OpenSuccessMessage()
        {
            frmMensagenDeSucesso msn = new frmMensagenDeSucesso();
            msn.Show();
        }

        //Preenchendo combobox com Empresas
        private void DepartmentListView()
        {
            try
            {
                DataTable dt = null;

                dt = departmentModel.DepartmentList();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                comboBoxDepartament.DataSource = dt;
                comboBoxDepartament.DisplayMember = "departmentt";
                comboBoxDepartament.ValueMember = "department_id";
                comboBoxDepartament.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar " + ex.Message);
            }

        }

        #region Busca Reativa
        //mostrar empresa de acordo com o radio button selecionado
        private int RadioButtonChecked()
        {

            if (checkFingertech.Checked == true)
            {
                headOffice_id = 1;
            }
            else if (checkT2M.Checked == true)
            {
                headOffice_id = 2;
            }
            else if (checkLDNTech.Checked == true)
            {
                headOffice_id = 3;
            }

            return headOffice_id;

        }
        //mostrar ativos ou inativos de acordo com o radio button selecionado
        private int RadioButtonActIntChecked()
        {

            if (RdActive.Checked == true)
            {
                userStatus = 1;
            }
            else if (radioButtonSearchInc.Checked == true)
            {
                userStatus = 0;
            }

            return userStatus;

        }

        //Carregar usuários cadastrados
        private void UserListView(User user)
        {
            try
            {
                RadioButtonActIntChecked();
                RadioButtonChecked();
                user.UserName = TbUserSearch.Text;
                user.UserStatus = userStatus;
                user.HeadOffice_id = headOffice_id;
                user.Re = TbRe.Text;






                dbUsers.DataSource = userModel.UserListModel(user);
                dbUsers.Columns[0].Visible = false;
                dbUsers.Columns[1].HeaderText = "Nome";
                dbUsers.Columns[2].HeaderText = "Status";
                dbUsers.Columns[3].HeaderText = "RE";
                dbUsers.Columns[4].HeaderText = "Empresa";
                dbUsers.Columns[5].HeaderText = "Data de Admissão";


                dbUsers.Columns[6].Visible = false;//headOffice_id
                dbUsers.Columns[7].Visible = false;//branchHeadOffice_id
                dbUsers.Columns[8].Visible = false;//department_id
                dbUsers.Columns[9].Visible = false;//role_id
                dbUsers.Columns[10].Visible = false;//workShift
                dbUsers.Columns[11].Visible = false;//compensatoryTimeOff
                dbUsers.Columns[12].Visible = false;//usePassword
                dbUsers.Columns[13].Visible = false;//verifyInput
                dbUsers.Columns[14].Visible = false;//appointmentEveryDay
                dbUsers.Columns[15].Visible = false;//registPoint
                dbUsers.Columns[16].Visible = false;//userPassword
                dbUsers.Columns[17].Visible = false;//pis
                dbUsers.Columns[18].Visible = false;//serieWorkCard
                dbUsers.Columns[19].Visible = false;//numberWorkCard
                dbUsers.Columns[20].Visible = false;//appointmentEveryDay
                dbUsers.Columns[21].HeaderText = "CATEGORIA";
                dbUsers.Columns[30].Visible = false;//intervalo
                //
                //endereço
                //
                dbUsers.Columns[22].Visible = false;//cep
                dbUsers.Columns[23].Visible = false;//number
                dbUsers.Columns[24].Visible = false;//street
                dbUsers.Columns[25].Visible = false;//complement
                dbUsers.Columns[26].Visible = false;//district
                dbUsers.Columns[27].Visible = false;//location
                dbUsers.Columns[28].Visible = false;//uf
                dbUsers.Columns[29].Visible = false;//addres id
                

                dbUsers.AllowUserToAddRows = false;

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Busca changed search text
        private void TbUserSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {




                EmpityFildSeach();
                RadioButtonChecked();
                status = ConverteRadioActive();
                UserListView(user);
            }
            catch (Exception)
            {

                throw;
            }
        }
        // Busca changed re
        private void TbRe_TextChanged(object sender, EventArgs e)
        {
            EmpityFildSeach();
            int status = ConverteRadioActive();
            UserListView(user);
        }
        #endregion

        //Limpar imput de Re e Search
        private void EmpityFildSeach()
        {
            if (!String.IsNullOrEmpty(TbUserSearch.Text))
            {
                TbRe.Text = "";
            }
            else if (!String.IsNullOrEmpty(TbRe.Text))
            {
                TbUserSearch.Text = "";
            }

        }

        //Preenchendo combobox com Empresas
        private void WorkShiftListView()
        {

            try
            {
                DataTable dt = null;

                dt = workShiftModel.WorkShiftListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cbWorkShift.DataSource = dt;
                cbWorkShift.DisplayMember = "shift";
                cbWorkShift.ValueMember = "shift_id";
                cbWorkShift.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar " + ex.Message);
            }

        }


        //Preenchendo combobox com Empresas
        private void roleListView()
        {

            try
            {
                DataTable dt = null;

                dt = roleModel.RoleListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                cbRole.DataSource = dt;
                cbRole.DisplayMember = "nameRole";
                cbRole.ValueMember = "role_id";
                cbRole.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar " + ex.Message);
            }

        }

        //Preenchendo combobox com Empresas
        private void HeadOfficeListView()
        {

            try
            {
                DataTable dt = null;

                dt = departmentModel.HeadOfficeListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });

                comboBoxCompany.DataSource = dt;
                comboBoxCompany.DisplayMember = "headOffice";
                comboBoxCompany.ValueMember = "headOffice_id";
                comboBoxCompany.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

        }
        //Exibir filial de acordo com matriz selecionada
        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxBranch.DataSource = null;
                string erroSelectedValue = comboBoxCompany.SelectedValue.ToString();


                if (erroSelectedValue.Length != 23)
                {

                    comboBoxBranch.Enabled = true;
                    comboBoxBranch.DataSource = headOfficeModel.BranchHeadOfficeListModel(Convert.ToInt32(comboBoxCompany.SelectedValue));
                    comboBoxBranch.DisplayMember = "branchName";
                    comboBoxBranch.ValueMember = "branchHeadOffice_id";
                    comboBoxBranch.SelectedValue = 1;
                    _ = comboBoxBranch.Items.Count > 0 ? comboBoxBranch.Enabled = true : comboBoxBranch.Enabled = false;

                }
                else
                {

                    comboBoxBranch.Enabled = true;
                    comboBoxBranch.DataSource = headOfficeModel.BranchHeadOfficeListModel(0);
                    comboBoxBranch.DisplayMember = "branchName";
                    comboBoxBranch.ValueMember = "branchHeadOffice_id";
                    _ = comboBoxBranch.Items.Count > 0 ? comboBoxBranch.Enabled = true : comboBoxBranch.Enabled = false;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion
        #region Group Box
        private int ConverteGroupBoxSituacao()
        {
            if (rbSituacaoAtivo.Checked == false)
            {
                situation = 0;
            }

            return situation;
        }

        private int ConverteRadioActive()
        {
            if (RdActive.Checked == false)
            {
                activeSearch = 0;
            }
            else
            {
                activeSearch = 1;
            }

            return activeSearch;
        }


        private int ConverteGroupBoxRegistraPonto()
        {
            if (rbRegistraPontoAtivo.Checked == false)
            {
                pointRegister = 0;
            }

            return pointRegister;
        }

        private int ConverteGroupBoxCompTime()
        {
            if (rnBancoHorasAtivo.Checked == false)
            {
                compTime = 0;
            }

            return compTime;
        }

        private int ConverteGroupBoxradioButtonVerifyInputY()
        {
            if (radioButtonVerifyInputY.Checked == false)
            {
                verifyImput = 0;
            }

            return verifyImput;
        }

        private int ConverteGroupPassword()
        {
            if (rbPasswordYes.Checked == false)
            {
                password = 0;
            }

            return password;
        }

        private int ConverteGroupMarkAllDay()
        {
            if (chMarkAllDay.Checked == false)
            {
                markAllDay1 = 0;
            }

            return markAllDay1;
        }

        private void rbSituacaoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            ConverteGroupBoxSituacao();
        }

        private void rbRegistraPontoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            ConverteGroupBoxRegistraPonto();
        }

        private void rbPassword_CheckedChanged(object sender, EventArgs e)
        {
            ConverteGroupPassword();
        }

        private void rnBancoHorasAtivo_CheckedChanged(object sender, EventArgs e)
        {
            ConverteGroupBoxCompTime();
        }

        private void radioButtonVerifyInputY_CheckedChanged(object sender, EventArgs e)
        {
            ConverteGroupBoxradioButtonVerifyInputY();
        }

        private void chMarkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            ConverteGroupMarkAllDay();
        }


        #endregion
        #region Method POST
        // Insert dados na tabela de Usuário
        private void UserSaveView()
        {
            try
            {

                user.UserName = textBoxName.Text; //nome
                user.NumberWorkCard = textBoxWalletNum.Text;//numero da carteira de trabalho
                user.SerieWorkCard = textBoxSerie.Text; //numero de serie da carteira de trabalho
                user.Pis = cbPis.Text; //numero pis da carteira de trabalho
                user.Re = textBoxRe.Text; //re
                user.UserStatus = situation;

                user.DataCadastro = Convert.ToDateTime(created); ;
                user.UpdateCadastro = Convert.ToDateTime(created);

                user.Admission = Convert.ToDateTime(cbDateTimeAdminssao.Text);//data de admissao
                user.Resignation = Convert.ToDateTime(cbDateTimeDemissao.Text);

                user.RegistPoint = pointRegister;//registra ponto
                user.UsePassword = password;//utilizar senha
                user.CompensatoryTimeOff = compTime;//banco de horas
                user.VerifyInput = verifyImput;//verificar entrada\\
                user.Password = textBoxPassword.Text;//senha
                user.AppointmentEveryDay = markAllDay1;//gerar marcação em qualquer dia
                user.JustTime = Convert.ToDateTime(totalHoras.Text);//
                lastUserIdSave = userModel.UserSaveModel(user);
                OpenSuccessMessage();

            }
            catch (Exception)
            {
                throw; ;
            }
        }

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
                addres.User_id = lastUserIdSave;
                addres.HeadOffice_id = Convert.ToInt32(comboBoxCompany.SelectedValue);

                userModel.addresUserSaveModel(addres);
                OpenSuccessMessage();

            }
            catch (Exception)
            {
                throw; ;
            }
        }

        //Addres edit view
        private void AddresEditView()
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
                
                //addres.Addres_id = Convert.ToInt32(ADDRES_ID);

                userModel.addresUserEditModel(addres);
                OpenSuccessMessage();

            }
            catch (Exception)
            {
                throw; ;
            }
        }
        //validar imput usuario 
        private void InputUserValidation()
        {
            if(string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxWalletNum.Text) || string.IsNullOrEmpty(textBoxSerie.Text) || string.IsNullOrEmpty(cbPis.Text) || string.IsNullOrEmpty(comboBoxCompany.Text) || string.IsNullOrEmpty(comboBoxBranch.Text) || string.IsNullOrEmpty(textBoxRe.Text) || string.IsNullOrEmpty(comboBoxDepartament.Text) || string.IsNullOrEmpty(cbRole.Text) || string.IsNullOrEmpty(cbWorkShift.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(txtCep.Text) || string.IsNullOrEmpty(txtStreet.Text) || string.IsNullOrEmpty(txttNumber.Text) || string.IsNullOrEmpty(txtDistrict.Text) || string.IsNullOrEmpty(txtLocation.Text) || string.IsNullOrEmpty(txtUf.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }

        }

        //Inserir dados dentor da tabela de Pivot Role
        private void insertInToPivotRoleView()
        {
            try
            {
                roleModel.InsertoInToPivotRoleModel(lastUserIdSave, Convert.ToInt32(cbRole.SelectedValue));
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Inserir dados dentro da tabela de PivotlinkUserCompany
        private void InsertoInToPivotlinkUserCompanyView()
        {
            try
            {

                int selectedItem = 0;

                if (Convert.ToInt32(comboBoxBranch.SelectedValue) > 0)
                {

                    selectedItem = Convert.ToInt32(comboBoxBranch.SelectedValue);
                }

                roleModel.InsertoInToPivotlinkUserCompanyModel
                (
                    Convert.ToInt32(comboBoxCompany.SelectedValue),
                           selectedItem,
                    Convert.ToInt32(comboBoxDepartament.SelectedValue),
                              lastUserIdSave
                );
            }
            catch (Exception)
            {
                throw;
            }

        }


        //Inserir dados dentor da tabela de Pivot Role
        private void InsertWorkshiftPivotView()
        {
            try
            {
                workShiftModel.InsertWorkshiftPivotModel(lastUserIdSave, Convert.ToInt32(cbWorkShift.SelectedValue));

            }
            catch (Exception)
            {
                throw;
            }
        }
        //Chama a função  Save
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpityField() == true)
                {
                    UserSaveView();
                    AddresSaveView();
                    insertInToPivotRoleView();
                    InsertoInToPivotlinkUserCompanyView();
                    InsertWorkshiftPivotView();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
        #region Validações
        //Validação para os campos vazios
        private bool EmpityField()
        {
            if (
                textBoxName.Text == "" ||
                textBoxWalletNum.Text == "" ||
                textBoxName.Text == "" ||
                textBoxSerie.Text == "" ||
                textBoxPassword.Text == "" ||
                cbPis.Text == "" ||
                textBoxRe.Text == "" ||
                Convert.ToInt32(comboBoxCompany.SelectedValue) == 0 ||
                Convert.ToInt32(comboBoxDepartament.SelectedValue) == 0 ||
                Convert.ToInt32(cbWorkShift.SelectedValue) == 0 ||
                Convert.ToInt32(cbRole.SelectedValue) == 0
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


        #endregion
        // Muda a formatação condicional da coluna de status
        private void dbUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dbUsers.Columns[e.ColumnIndex].Name == "status")
            {
                dbUsers.Columns["status"].SortMode = DataGridViewColumnSortMode.NotSortable;

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

        //Mensagem de Erro
        private void DisplayErrorMsg(uint ret)
        {
            MessageBox.Show(NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region CADASTRO DE BIOMETRIA
        //Cadastrar Biometria
        private void TBDigital_Click(object sender, EventArgs e)
        {


            NBioAPI.Type.HFIR hNewFIR;
            NBioAPI.Type.FIR_TEXTENCODE template;

            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            uint ret = m_NBioAPI.Enroll(out hNewFIR, null);

            if (ret != NBioAPI.Error.NONE)
            {
                DisplayErrorMsg(ret);
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                return;
            }

            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            //Devolve Template
            m_NBioAPI.GetTextFIRFromHandle(hNewFIR, out template, true);
            //Template
            string templateFir = template.TextFIR;

            //Insere template no banco de dados
            InsertTemplateInToDatabaseView(template.TextFIR, textBoxRe.Text);
        }

        private void InsertTemplateInToDatabaseView(string templateFIR, string user_RE)
        {
            pointModel.InsertTemplateInToDatabaseModel(templateFIR, user_RE);
        }
        #endregion


        //Retorna o id da empresa pelo nome
        public int GetHeadOfficeIdRetourn(string headOffice)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = headOfficeModel.GetHeadOfficeIdRetourn(headOffice);

                int id = Convert.ToInt32(dt.Rows[0][0].ToString());

                return id;

            }
            catch (Exception)
            {
                throw;
            }
        }
        //subir informações para edição de dados 
        private void dbUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            button3.Visible = true;
            btnEdit.Enabled = true;
            btnEdit.Visible = true;
            TBDigital.Enabled = true;
            textBoxSerie.Enabled = true;
            textBoxWalletNum.Enabled = true;
            cbPis.Enabled = true;
            

            USER_REID = dbUsers.Rows[e.RowIndex].Cells[2].Value.ToString();

            string checkedStatus = dbUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            _ = "Ativo".Equals(checkedStatus) ? rbSituacaoAtivo.Checked = true : radioButtonSituIn.Checked = true;

            string checkedcompensatoryTimeOff = dbUsers.Rows[e.RowIndex].Cells[11].Value.ToString();
            _ = "1".Equals(checkedcompensatoryTimeOff) ? rnBancoHorasAtivo.Checked = true : radioButtonBankHN.Checked = true;

            string checkedusePassword = dbUsers.Rows[e.RowIndex].Cells[12].Value.ToString();
            _ = "1".Equals(checkedusePassword) ? rbPasswordYes.Checked = true : radioButtonUsePassN.Checked = true;

            string checkedverifyInput = dbUsers.Rows[e.RowIndex].Cells[13].Value.ToString();
            _ = "1".Equals(checkedverifyInput) ? radioButtonVerifyInputY.Checked = true : radioButtonVerifyInputN.Checked = true;

            string checkedregistPoint = dbUsers.Rows[e.RowIndex].Cells[15].Value.ToString();
            _ = "1".Equals(checkedregistPoint) ? rbRegistraPontoAtivo.Checked = true : radioButtonRegistPN.Checked = true;

            string checkedAppointment = dbUsers.Rows[e.RowIndex].Cells[20].Value.ToString();
            _ = "1".Equals(checkedregistPoint) ? chMarkAllDay.Checked = true : chMarkAllDay.Checked = false;

            user.User_id = Convert.ToInt32(dbUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxName.Text = dbUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxRe.Text = dbUsers.Rows[e.RowIndex].Cells[3].Value.ToString();//re

            comboBoxCompany.SelectedValue = GetHeadOfficeIdRetourn(dbUsers.Rows[e.RowIndex].Cells[4].Value.ToString());//empresa
            comboBoxDepartament.SelectedValue = Convert.ToInt32(dbUsers.Rows[e.RowIndex].Cells[8].Value);//departamento


            cbRole.SelectedValue = Convert.ToInt32(dbUsers.Rows[e.RowIndex].Cells[9].Value.ToString());//role
            cbWorkShift.SelectedValue = Convert.ToInt32(dbUsers.Rows[e.RowIndex].Cells[10].Value.ToString());//workshift

            cbDateTimeAdminssao.Text = dbUsers.Rows[e.RowIndex].Cells[5].Value.ToString();//data de admissao


            textBoxPassword.Text = dbUsers.Rows[e.RowIndex].Cells[16].Value.ToString();//userPassword        
            cbPis.Text = dbUsers.Rows[e.RowIndex].Cells[17].Value.ToString();//pis
            textBoxSerie.Text = dbUsers.Rows[e.RowIndex].Cells[18].Value.ToString();//serieWorkCard
            textBoxWalletNum.Text = dbUsers.Rows[e.RowIndex].Cells[19].Value.ToString();//numberWorkCard
            //
            //endereço
            //
            txtCep.Text = dbUsers.Rows[e.RowIndex].Cells[22].Value.ToString();//cep
            txttNumber.Text = dbUsers.Rows[e.RowIndex].Cells[23].Value.ToString();//numero da casa
            txtStreet.Text = dbUsers.Rows[e.RowIndex].Cells[24].Value.ToString();//rua
            txtComplement.Text = dbUsers.Rows[e.RowIndex].Cells[25].Value.ToString();//complemento
            txtDistrict.Text = dbUsers.Rows[e.RowIndex].Cells[26].Value.ToString();//bairro
            txtLocation.Text = dbUsers.Rows[e.RowIndex].Cells[27].Value.ToString();//cidade
            txtUf.Text = dbUsers.Rows[e.RowIndex].Cells[28].Value.ToString();//estado

            ADDRES_ID = dbUsers.Rows[e.RowIndex].Cells[29].Value.ToString();//id do endereço
            totalHoras.Text = dbUsers.Rows[e.RowIndex].Cells[30].Value.ToString();//id do endereço


        }


        //ação do radio button Fingertech
        private void checkFingertech_Click(object sender, EventArgs e)
        {
            RadioButtonChecked();
            user.UserStatus = RdActive.Checked == true ? 1 : 0;
            user.Re = null;
            user.UserName = null;
            user.HeadOffice_id = 1;

            UserListView(user);

        }
        //ação do radio button T2M
        private void checkT2M_Click(object sender, EventArgs e)
        {
            RadioButtonChecked();
            user.UserStatus = RdActive.Checked == true ? 1 : 0;
            user.Re = null;
            user.UserName = null;
            user.HeadOffice_id = 2;

            UserListView(user);
        }
        //ação do radio button LDNTech
        private void checkLDNTech_Click(object sender, EventArgs e)
        {
            RadioButtonChecked();
            user.UserStatus = RdActive.Checked == true ? 1 : 0;
            user.Re = null;
            user.UserName = null;
            user.HeadOffice_id = 3;
            UserListView(user);
        }
        //ação radio button "Ativo" busca reativa
        private void RdActive_CheckedChanged(object sender, EventArgs e)
        {
            user.UserStatus = RdActive.Checked == true ? 1 : 0;
            user.Re = null;
            user.UserName = null;
            user.HeadOffice_id = headOffice_id;
            UserListView(user);
        }
        //ação radio button "Inativo" busca reativa
        private void radioButtonSearchInc_CheckedChanged(object sender, EventArgs e)
        {
            user.UserStatus = radioButtonSearchInc.Checked == true ? 0 : 1;
            user.Re = null;
            user.UserName = null;
            user.HeadOffice_id = headOffice_id;
            UserListView(user);
        }
        //limpar campos
        public void limpaCampos()
        {
            textBoxName.Text = "";
            textBoxWalletNum.Text = "";
            textBoxSerie.Text = "";
            cbPis.Text = "";
            comboBoxCompany.Text = "";
            comboBoxBranch.Text = "";

            textBoxRe.Text = "";
            comboBoxDepartament.Text = "";
            cbWorkShift.Text = "";
            cbRole.Text = "";
            
            textBoxPassword.Text = "";
            txtCep.Text = "";
            txtStreet.Text = "";
            txttNumber.Text = "";
            txtComplement.Text = "";
            txtDistrict.Text = "";
            txtLocation.Text = "";
            txtUf.Text = "";
            


            textBoxName.Text = string.Empty;
            textBoxWalletNum.Text = string.Empty;
            textBoxSerie.Text = string.Empty;
            cbPis.Text = string.Empty;
            comboBoxCompany.Text = string.Empty;
            comboBoxBranch.Text = string.Empty;
            textBoxRe.Text = string.Empty;
            comboBoxDepartament.Text = string.Empty;
            cbWorkShift.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            
            cbRole.Text = string.Empty;

            textBoxPassword.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txttNumber.Text = string.Empty;
            txtComplement.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtUf.Text = string.Empty;
            

        }

        //botão "editar"
        public void btnEdit_Click(object sender, EventArgs e)
        {
            AddresEditView();
            button3.Visible = true;
            btnEdit.Visible = false;


            checkFingertech.Checked = true;
            frmMensagenDeSucesso msn = new();
            try
            {


                DateTime dateTime;
                dateTime = DateTime.Now;
                user.UpdateCadastro = dateTime;
                user.UserName = textBoxName.Text;
                user.User_id = user.User_id;
                user.UserStatus = rbSituacaoAtivo.Checked == true ? 1 : 0;
                user.NumberWorkCard = textBoxWalletNum.Text;
                user.SerieWorkCard = textBoxSerie.Text;
                user.Pis = cbPis.Text;
                user.Re = textBoxRe.Text;
                user.UsePassword = rbPasswordYes.Checked == true ? 1 : 0;
                user.CompensatoryTimeOff = rnBancoHorasAtivo.Checked == true ? 1 : 0;
                user.VerifyInput = radioButtonVerifyInputY.Checked == true ? 1 : 0;
                user.Admission = Convert.ToDateTime(cbDateTimeAdminssao.Text);
                user.Resignation = Convert.ToDateTime(cbDateTimeDemissao.Text);
                user.AppointmentEveryDay = chMarkAllDay.Checked == true ? 1 : 0;
                user.HeadOffice_id = Convert.ToInt32(comboBoxCompany.SelectedValue);
                user.Department_id = Convert.ToInt32(comboBoxDepartament.SelectedValue);
                user.Department_id = Convert.ToInt32(comboBoxDepartament.SelectedValue);
                user.JustTime = Convert.ToDateTime(totalHoras.Text);

               

                user.DataCadastro = Convert.ToDateTime(created); ;


                user.Password = textBoxPassword.Text;

                userModel.UserUpdateModel(user);
                UserListView(user);


                msn.labelChanged("  Alterado com sucesso!");
                msn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Foi detectado um erro");
            }
        }




       
    }

}
