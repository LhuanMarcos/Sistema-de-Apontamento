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
using System.IO;
using GUI_MODERNISTA.Entities;
using System.Collections;
using static NITGEN.SDK.NBioBSP.NBioAPI.IndexSearch;
using GUI_PONTO.Views;
using System.Threading;
using System.Collections.ObjectModel;
using GUI_PONTO.Controller;
using System.Net.Cache;
using System.Text.RegularExpressions;

namespace GUI_PONTO
{
    public partial class frmPonto : Form
    {

        NBioAPI m_NBioAPI;
        NBioAPI.IndexSearch m_IndexSearch;
        NBioAPI.Type.HFIR hCapturedFIR;

        PointModel pointModel = new();
        PointC point = new PointC();
        public byte FingerRE = 0;
        private int radioCheckedPont = 0;
        uint ret3;
        private int cont = 0;
        uint userID;

        public void inicialization()
        {
            InitializeComponent();
            pointModel.GetuserTemplateModel();
    

        }

        #region INTEGRAÇÃO COM LEITOR BIOMÉTRICO NITGEN

        public frmPonto()
        {
            InitializeComponent();
            disableInputBox();
       
        }

        //Use este método para liberar recursos não gerenciados, como identificadores e memórias mantidos por uma instância do objeto NBioBSP.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void frmPontoDiario_Load(object sender, EventArgs e)
        {
           

        }
        //Caso de erro na inicialização do Ingine
        private void DisplayErrorMsg(uint ret)
        {
            MessageBox.Show(NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SavePoint()
        {
          
            uint ID;
    
            //declara objeto que ira receber o template e que será passado por parametro para alocar na memoria.
            NBioAPI.Type.FIR_TEXTENCODE templatefromDB = new NBioAPI.Type.FIR_TEXTENCODE();
          
            NBioAPI.IndexSearch.FP_INFO[] fpInfo;

            //declara objeto do tipo FIR que ira receber o template coletado em tempo real e que será passado por parametro para alocar na memoria.
      
            NBioAPI.Type.HFIR retorno_para_exportar = new NBioAPI.Type.HFIR();

            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            uint ret1 = m_NBioAPI.Capture(NBioAPI.Type.FIR_PURPOSE.VERIFY, out hCapturedFIR, 5000, retorno_para_exportar, null);
            
      
            /*Busca no Banco de Dados ID, Template */
            PointModel pointModel = new();
            DataTable dt = pointModel.GetuserTemplateModel();
            List<String> lista = new List<String>();
            foreach (DataRow dtrow in dt.Rows)
            {
           
                lista.Add(dtrow.ItemArray[0].ToString());
                lista.Add(dtrow.ItemArray[1].ToString());


                ID = uint.Parse(dtrow.ItemArray[0].ToString());

                templatefromDB.TextFIR = dtrow.ItemArray[1].ToString();

                //adiciona os templates do banco para a memória
                m_IndexSearch.AddFIR(templatefromDB, ID, out fpInfo);

                //Cria um objeto de retorno para Callback
                NBioAPI.IndexSearch.CALLBACK_INFO_0 cbInfo0 = new NBioAPI.IndexSearch.CALLBACK_INFO_0();
                cbInfo0.CallBackFunction = new NBioAPI.IndexSearch.INDEXSEARCH_CALLBACK(myCallback);

                //Fecha o dispositivo
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);

                // Identify FIR to IndexSearch DB - Retorno com inf. cliente 
                NBioAPI.IndexSearch.FP_INFO fpInfo2;

                //Compara os dados da digital capturada em tempo real com a digital vinda do banco de dados e alocada em memória
                ret3 = m_IndexSearch.IdentifyData(hCapturedFIR, NBioAPI.Type.FIR_SECURITY_LEVEL.NORMAL, out fpInfo2, cbInfo0);
                userID = fpInfo2.ID;

            }
            if (ret3 == 1286)
            {
                MessageBox.Show("Digital não reconhecida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (userID != 0)
            {
            

                point.User_re = pointModel.ReturnUserReFromModel((int)userID);
                DataTable table = pointModel.TimestampSearchByReFromModel(point.User_re);


                if (table.Rows.Count > 0)
                {
                    txtName.Text = table.Rows[0][1].ToString();
                    string po1 = table.Rows[0][2].ToString();
                    string po2 = table.Rows[0][3].ToString();
                    string po3 = table.Rows[0][4].ToString();
                    string po4 = table.Rows[0][5].ToString();

                    int index2 = table.Columns.IndexOf("pointOne");
                    int index3 = table.Columns.IndexOf("pointTwo");
                    int index4 = table.Columns.IndexOf("pointTree");
                    int index5 = table.Columns.IndexOf("pointFour");

                    if (po1 != "" && po2 != "" && po3 != "" && po4 != "" )
                    {
                        MessageBox.Show("Todos os registros já foram inseridos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillInputPoint();
                        InsertPointValidation2();
                        return;
                    }
          


                        if (rd1.Checked == true)
                        {

                            if (po2 == "" && po3 == "" && po4 == "")
                            {
                                if (po1 == "")
                                {
                                    cont += 1;
                                    InsertPointInToTable();
                                }
                                else
                                {
                                    MessageBox.Show("Já existe marcação nesse horário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    FillInputPoint();
                                        cont += 1;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não é possível inserir marcação nesse campo !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FillInputPoint();
                                    cont += 1;
                            }
                        }

                        if (rd2.Checked == true)
                        {
                            if (po3 == "" && po4 == "")
                            {
                                if (po2 == "")
                                {
                                    cont += 1;
                                    InsertPointInToTable();
                                }
                                else
                                {
                                MessageBox.Show("Já existe marcação nesse horário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                FillInputPoint();
                                FillInputPoint();
                                        cont += 1;
                                }
                            }
                            else
                            {
                            MessageBox.Show("Não é possível inserir marcação nesse campo !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillInputPoint();
                                cont += 1;
                            }
                           
                        
                 
                    }
                    
                        if (rd3.Checked == true)
                        {
                            if (po4 == "")
                            {
                                if (po3 == "")
                                {
                                    cont += 1;
                                    InsertPointInToTable();
                                }
                                else
                                {
                                MessageBox.Show("Já existe marcação nesse horário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                FillInputPoint();
                                FillInputPoint();
                                    cont += 1;
                                }
                            }
                        else
                        {
                            MessageBox.Show("Não é possível inserir marcação nesse campo !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillInputPoint();
                            cont += 1;
                        }
                    }
                    
                    if (rd4.Checked == true)
                    {
                        
                            if (po4 == "")
                            {
                                cont += 1;
                                InsertPointInToTable();
                            }
                            else
                            {
                                MessageBox.Show("Já existe marcação nesse horário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                FillInputPoint();
                                FillInputPoint();
                                cont += 1;
                            }
        
                    }

                    if(cont == 0)
                    {
                        MessageBox.Show("Já existe marcação nesse horário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        FillInputPoint();
                        InsertPointValidation();
                    }
                }
                else
                {
                    InsertPointValidation();
                    InsertPointInToTable();
                }
          
                m_IndexSearch.ClearDB();

            }

            ButonChecked();
        }
 
        //Funções de retorno de chamada que deve ser invocado durante Operação IndexSearch.Se NULL, nenhuma função de retorno de chamada será usada.
        public uint myCallback(ref NBioAPI.IndexSearch.CALLBACK_PARAM_0 cbParam0, IntPtr userParam)
        {
          
            return NBioAPI.IndexSearch.CALLBACK_RETURN.OK;
        }
        private void ButonChecked()
        {
            rd1.Checked = false;
            rd2.Checked = false;
            rd3.Checked = false;
            rd4.Checked = false;
        }
        private void ClearButton()
        {
       
            rd1.Checked = false;
            rd2.Checked = false;
            rd3.Checked = false;
            rd4.Checked = false;
            txtName.Text = "";
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
            txtBox4.Text = "";
            rd1.Enabled = true;
            rd2.Enabled = true;
            rd3.Enabled = true;
            rd4.Enabled = true;
        }


        #endregion

        private void disableInputBox()
        {
            txtName.Enabled = false;
            txtBox1.Enabled = false;
            txtBox2.Enabled = false;
            txtBox3.Enabled = false;
            txtBox4.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmPrincipal frmInicio = new frmPrincipal(); // Declara o form2
            frmPonto pDiario = new frmPonto();
            pDiario.Visible = false;
            pDiario.pTopoPontoDario.Visible = false;
            pDiario.btnCerrar.Visible = false;
            frmInicio.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
             
        }

   
        private int GetButtonChecked()
        {

            if (rd1.Checked)
            {
                radioCheckedPont = 1;
            }
            if (rd2.Checked)
            {
                radioCheckedPont = 2;
            }
            if (rd3.Checked)
            {
                radioCheckedPont = 3;
            }
            if (rd4.Checked)
            {
                radioCheckedPont = 4;
            }

            return radioCheckedPont;
        }

        //Inserir dados dentro da tabela de ponto
         private void InsertPointInToTable()
        {

            InsertPointValidation();
      
            DateTime date = new DateTime();
            DateTime date2 = new DateTime();

            //date = Convert.ToDateTime(DT.Rows[0][0].ToString());

            date = DateTime.Now;
            int check = GetButtonChecked();
            switch (check)
            {
                case 1:
                    point.User_id = (int)userID;
                    point.PointOne = date;
                    point.PointTwo = date2;
                    point.PointTree = date2;
                    point.PointFour = date2;
                    break;
                case 2:
                    point.User_id = (int)userID;
                    point.PointOne = date2;
                    point.PointTwo = date;
                    point.PointTree = date2;
                    point.PointFour = date2;
                    break;
                case 3:
                    point.User_id = (int)userID;
                    point.PointOne = date2;
                    point.PointTwo = date2;
                    point.PointTree = date;
                    point.PointFour = date2;
                    break;
                case 4:
                    point.User_id = (int)userID;
                    point.PointOne = date2;
                    point.PointTwo = date2;
                    point.PointTree = date2;
                    point.PointFour = date;
                    break;
            }
            string re = pointModel.InsertInToPointsFrmModel(point);

            FillInputPoint();
            InsertPointValidation();
            InsertPointValidation2();

        }

        //Preencher imputs com marcação de ponto do usuario
        private void FillInputPoint()
        {

            DataTable table = pointModel.TimestampSearchByReFromModel(point.User_re);

            txtName.Text = table.Rows[0][1].ToString();
            string po1 = table.Rows[0][2].ToString();
            string po2 = table.Rows[0][3].ToString();
            string po3 = table.Rows[0][4].ToString();
            string po4 = table.Rows[0][5].ToString();

            if (po1 != "")
            {
                DateTime pointOne = (DateTime)table.Rows[0][2];
                txtBox1.Text = pointOne.ToString("HH:mm:ss");
            }
            if (po2 != "")
            {
                DateTime pointTwo = (DateTime)table.Rows[0][3];
                txtBox2.Text = pointTwo.ToString("HH:mm:ss");
            }
            if (po3 != "")
            {
                DateTime pointTree = (DateTime)table.Rows[0][4];
                txtBox3.Text = pointTree.ToString("HH:mm:ss");
            }
            if (po4 != "")
            {
                DateTime pointFour = (DateTime)table.Rows[0][5];
                txtBox4.Text = pointFour.ToString("HH:mm:ss");
            }

        }

        //Validaçao dos campos de preenchidos da marcação de ponto
        private void InsertPointValidation()
        {
            if (txtBox1.Text == "" && txtBox2.Text == "" && txtBox3.Text == "" && txtBox4.Text == "")
            {
                rd1.Enabled = true;
                rd2.Enabled = true;
                rd3.Enabled = true;
                rd4.Enabled = true;

            }
            if (txtBox1.Text != "" && txtBox2.Text == "" && txtBox3.Text == "" && txtBox4.Text == "")
            {
                rd1.Enabled = false;
                rd2.Enabled = true;
                rd3.Enabled = false;
                rd4.Enabled = false;
            }
            if (txtBox1.Text != "" && txtBox2.Text != "" && txtBox3.Text == "" && txtBox4.Text == "")
            {
                rd1.Enabled = false;
                rd2.Enabled = false;
                rd3.Enabled = true;
                rd4.Enabled = false;
            }
            if (txtBox1.Text != "" && txtBox2.Text != "" && txtBox3.Text != "" && txtBox4.Text == "")
            {
                rd1.Enabled = false;
                rd2.Enabled = false;
                rd3.Enabled = false;
                rd4.Enabled = true;
            }
            if (txtBox1.Text == "" && txtBox2.Text == "" && txtBox3.Text != "" && txtBox4.Text == "")
            {
                rd1.Enabled = false;
                rd2.Enabled = false;
                rd3.Enabled = true;
                rd4.Enabled = false;
            }
 
        }

        private void InsertPointValidation2()
        {
            if (txtBox2.Text != "" )
            {
                rd1.Enabled = false;
                rd2.Enabled = false;
                txtBox1.Enabled = false;
                txtBox2.Enabled = false;

            }
            if (txtBox3.Text != "")
            {
                rd1.Enabled = false;
                rd2.Enabled = false;
                rd3.Enabled = false; 
                txtBox1.Enabled = false;
                txtBox2.Enabled = false;
                txtBox3.Enabled = false;

            }
            if (txtBox4.Text != "")
            {
                rd1.Enabled = false;
                rd2.Enabled = false;
                rd3.Enabled = false;
                rd4.Enabled = false;
                txtBox1.Enabled = false;
                txtBox2.Enabled = false;
                txtBox3.Enabled = false;
                txtBox4.Enabled = false;
            }


        }
        //Hora e dia da tela de ponto
        private void horaFecha_Tick_2(object sender, EventArgs e)
        {
            DateTime timeUtc = DateTime.UtcNow;
            DateTime horaBrasilia = GetNistTime();



            lbHora.Text = horaBrasilia.ToString("HH:mm:ss");
            lbFecha.Text = timeUtc.ToLongDateString();
        }

        public static DateTime GetNistTime()
        {
            DateTime dateTime = DateTime.MinValue;

            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("https://www.horariodebrasilia.org/");
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
            request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore); //No caching
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                StreamReader stream = new StreamReader(response.GetResponseStream());
                string html = stream.ReadToEnd().ToUpper();
                string time = Regex.Match(html, @">\d+:\d+:\d+<").Value; //HH:mm:ss format
                string date = Regex.Match(html, @">\w+,\s\w+\s\d+,\s\d+<").Value; //dddd, MMMM dd, yyyy
                dateTime = DateTime.Parse((date + " " + time).Replace(">", "").Replace("<", ""));
            }

            return dateTime;
        }





        private void TextBoxClear()
        {
            txtName.Clear();
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
            txtBox4.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frmInicio = new frmLogin(); // Declara o form2
            frmInicio.Show();
        }

        private void rd1_MouseClick(object sender, MouseEventArgs e)
        {

            PointC point = new PointC();
            TextBoxClear();
            SavePoint();    
       
        }

        private void rd2_MouseClick(object sender, MouseEventArgs e)
        {

            point = new PointC();
            TextBoxClear();
            SavePoint();
        }

        private void rd3_MouseClick(object sender, MouseEventArgs e)
        {

            point = new PointC();
            TextBoxClear();
            SavePoint();
        }

        private void rd4_MouseClick(object sender, MouseEventArgs e)
        {

            point = new PointC();
            TextBoxClear();
            SavePoint();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmLogin frmInicio = new frmLogin(); // Declara o form2
            frmInicio.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearButton();
            this.Refresh();
        }
    }
}

                                                                                                                                                                                                                                                                                                                                                             