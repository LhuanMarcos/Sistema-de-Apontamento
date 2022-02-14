using GUI_MODERNISTA.Entities;
using GUI_PONTO.Models;
using GUI_PONTO.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA.Views
{
    public partial class frmJustificativa : Form
    {
        JustificationModel justificatiionModel = new JustificationModel();
        JustificationCategoryModel dgCategoryJus = new();
        Justification justification = new Justification();
        private int jusActive = 1;
        private int jusInactive = 0;
        public frmJustificativa()
        {
            InitializeComponent();
            JustificationList(jusActive);
            CategoryListGridView(1);
        }
        //listagem de justificativas
        private void JustificationList(int jusActive)
        {
            dgJustification.DataSource = justificatiionModel.JustificationListGridModel(jusActive);
            dgJustification.Columns[0].Visible = false;//ID
            dgJustification.Columns[1].HeaderText = "Justificativa";
            dgJustification.Columns[2].HeaderText = "Status";
            dgJustification.Columns[3].HeaderText = "Data de Cadastro";


            dgJustification.AllowUserToAddRows = false;

        }

        //Busca de Listagem de 
        public void CategoryListGridView(int status)
        {
            try
            {
                
                DataTable dt = null;
                dt = dgCategoryJus.CategoryListGridModel(status);
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });
                dtCategoria.DataSource = dt;
                dtCategoria.DisplayMember = "category";
                dtCategoria.ValueMember = "category_id";
                dtCategoria.SelectedValue = 0;

            }
            catch (Exception)
            {

                throw;
            }
        }


        //Formatacao da coluna status
        private void dgJustification_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgJustification.Columns[e.ColumnIndex].Name == "status")
            {
                dgJustification.Columns["status"].SortMode = DataGridViewColumnSortMode.NotSortable;

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
        //Mensagem sucesso para cadastro
        private void OpenSuccessMessage()
        {
            frmMensagenDeSucesso msn = new frmMensagenDeSucesso();
            msn.Show();
        }

        //Cadastrar Justificativa
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtCategoria.SelectedValue) > 0 && txtJustification.Text !="") 
            {
                justification.JustificationP = txtJustification.Text;
                justification.Statu = sdStatusActive.Checked == true ? 1 : 0;
                justification.Created_at = DateTime.Now;
                justification.Updated_at = DateTime.Now;
                int id = justificatiionModel.InsertJustificationToDataBaseFromModel(justification);
                justificatiionModel.LinkJustificationInToDatabaseModel(Convert.ToInt32(dtCategoria.SelectedValue), id);
                txtJustification.Clear();
                JustificationList(jusActive);
                dtCategoria.SelectedValue = 0;
                OpenSuccessMessage();
            }
            else
            {
                MessageBox.Show("Os campos de categoria e justificativas devem estar preenchidos!", "Atenção", MessageBoxButtons.OK);
            }


        }
        //Editar Justificativa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dtCategoria.Enabled = true;
                justification.JustificationP = txtJustification.Text;
                justification.Statu = sdStatusActive.Checked == true ? 1 : 0;
                justification.Updated_at = DateTime.Now;
                justificatiionModel.JustificationUpdateFromModel(justification);
                EnableAnDisableButtonUpdateEnd();
                JustificationList(jusActive);
            

                MessageBox.Show("Alterado com sucesso!", "Atenção",MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Preencher os campos para edição
        private void dgJustification_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtCategoria.SelectedValue = 0;
                dtCategoria.Enabled = false;
                EnableAnDisableButtonUpdateStart();
                justification.Jugistification_id = (int)dgJustification.Rows[e.RowIndex].Cells[0].Value;
                txtJustification.Text = dgJustification.Rows[e.RowIndex].Cells[1].Value.ToString();
                _ = dgJustification.Rows[e.RowIndex].Cells[2].Value.ToString() == "Ativo" ? sdStatusActive.Checked = true : rbStatusInctive.Checked = true;
                JustificationList(jusActive);
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void EnableAnDisableButtonUpdateStart()
        {
            btnEdit.Enabled = true;
            buttonSave.Enabled = false;
            sdStatusActive.Enabled = true;
            rbStatusInctive.Enabled = true;
        }
        private void EnableAnDisableButtonUpdateEnd()
        {
            btnEdit.Enabled = false;
            buttonSave.Enabled = true;
            sdStatusActive.Enabled = false;
            rbStatusInctive.Enabled = false;
            sdStatusActive.Checked = true;
            txtJustification.Clear();
        }
        //Busca de Justificação por status e nome
        private void textBoxSearchJustification_TextChanged(object sender, EventArgs e)
        {
            try
            {
                justification.JustificationP = textBoxSearchJustification.Text;
                justification.Statu = rsSearch.Checked == true ? 1 : 0;
                dgJustification.DataSource = justificatiionModel.JustificationListGridModel(justification);
                dgJustification.Columns[0].Visible = false;//ID
                dgJustification.Columns[1].HeaderText = "Cargo";
                dgJustification.Columns[2].HeaderText = "Status";
                dgJustification.Columns[3].HeaderText = "Data de Cadastro";
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Busca por staus
        private void rsSearch_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSearchJustification.Clear();
            JustificationList(jusActive);
        }
        //Busca por staus
        private void rbSearchInativ_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSearchJustification.Clear();
            JustificationList(jusInactive);
        }

  
    }
}
