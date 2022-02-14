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
    public partial class frmCategoriaJustificativa : Form
    {
        JustificationCategoryModel categoryModel = new();
        JustificationCategory jusCategory = new();
        public frmCategoriaJustificativa()
        {
            InitializeComponent();
            CategoryListGridView(1);
        }

        //Busca de Listagem de 
        public void CategoryListGridView(int status)
        {
            try
            {
        
                dgCategoryJus.DataSource = categoryModel.CategoryListGridModel(status);
                dgCategoryJus.Columns[0].Visible = false;//ID
                dgCategoryJus.Columns[1].HeaderText = "Categoria";
                dgCategoryJus.Columns[2].HeaderText = "Status";
                dgCategoryJus.Columns[3].HeaderText = "Data de Cadastro";


                dgCategoryJus.AllowUserToAddRows = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgCategoryJus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgCategoryJus.Columns[e.ColumnIndex].Name == "status")
            {
                dgCategoryJus.Columns["status"].SortMode = DataGridViewColumnSortMode.NotSortable;

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

        private void textCategory_TextChanged(object sender, EventArgs e)
        {
            jusCategory.Category = textCategory.Text;
            jusCategory.Statu = rsSearch.Checked == true ? 1 : 0;
            dgCategoryJus.DataSource = categoryModel.CategoryListGridByJustificationAndNameModel(jusCategory);
            dgCategoryJus.Columns[0].Visible = false;//ID
            dgCategoryJus.Columns[1].HeaderText = "Cargo";
            dgCategoryJus.Columns[2].HeaderText = "Status";
            dgCategoryJus.Columns[3].HeaderText = "Data de Cadastro";
        }
        //Listagem de Categoria por status
        private void rsSearch_CheckedChanged(object sender, EventArgs e)
        {
            textCategory.Clear();
            CategoryListGridView(1);
        }
        //Listagem de Categoria por status
        private void rbSearchInativ_CheckedChanged(object sender, EventArgs e)
        {
            textCategory.Clear();
            CategoryListGridView(0);
        }
        //inserir dados no Banco de Categoroa
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValidation()== true )
                {
                    jusCategory.Category = txtCategoria.Text;
                    jusCategory.Statu = sdStatusActive.Checked == true ? 1 : 0;
                    jusCategory.User_create = 1;
                    jusCategory.Created_at = DateTime.Now;
                    jusCategory.Updated_at = DateTime.Now;
                    categoryModel.InsertCategoryInToDataBase(jusCategory);
                    txtCategoria.Clear();
                    CategoryListGridView(1);
                    OpenSuccessMessage();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        //Mensagem sucesso para cadastro
        private void OpenSuccessMessage()
        {
            frmMensagenDeSucesso msn = new frmMensagenDeSucesso();
            msn.Show();
        }
        //Validation de campo vazio
        private bool txtValidation()
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Inserir o nome da Categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
       
            }
            return true;
        }






        //inserir dados no Banco de Categoroa
        private void btnEdit_Click(object sender, EventArgs e)
        {
   
           try
            {
                if (txtValidation() == true)
                {
                    jusCategory.Category = txtCategoria.Text;
                    jusCategory.Statu = sdStatusActive.Checked == true ? 1 : 0;
                    jusCategory.User_update = 2;
                    jusCategory.Updated_at = DateTime.Now;
                    categoryModel.CategoryUpdateFromModel(jusCategory);
                    txtCategoria.Clear();
                    EnableAnDisableButtonUpdateEnd();
                    CategoryListGridView(1);
                    OpenSuccessMessage();
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void dgCategoryJus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableAnDisableButtonUpdateStart();
            jusCategory.Category_id = (int)dgCategoryJus.Rows[e.RowIndex].Cells[0].Value;
            txtCategoria.Text = dgCategoryJus.Rows[e.RowIndex].Cells[1].Value.ToString();
            _ = dgCategoryJus.Rows[e.RowIndex].Cells[2].Value.ToString() == "Ativo" ? sdStatusActive.Checked = true : rbStatusInctive.Checked = true;
            CategoryListGridView(1);
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
            txtCategoria.Clear();
        }
    }
}
