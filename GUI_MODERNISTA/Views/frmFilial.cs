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

namespace GUI_PONTO.Views
{
    public partial class frmFilial : Form
    {

        HeadOfficeModel headoficceModel = new HeadOfficeModel();
        DepartmentModel departmentModel = new();
        HeadOffice headOffice = new();
        public frmFilial()
        {
            InitializeComponent();
            HeadOfficeListView();
            ComboBoxHeadOffice();
        }


        //Preenchendo combobox com Empresas
        private void HeadOfficeListView()
        {

            try
            {
                DataTable dt = null;

                dt = departmentModel.HeadOfficeListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });
                cbHeadOffice.DisplayMember = "headOffice";
                cbHeadOffice.ValueMember = "headOffice_id";
                cbHeadOffice.DataSource = dt;
                cbHeadOffice.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

        }

        private void ComboBoxHeadOffice()
        {

            try
            {
                DataTable dt = null;

                dt = departmentModel.HeadOfficeListModel();
                dt.Rows.Add(new Object[] { 0, "- Selecione -" });
                cbBoFilial.DisplayMember = "headOffice";
                cbBoFilial.ValueMember = "headOffice_id";
                cbBoFilial.DataSource = dt;
                cbBoFilial.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }

        }

         //Vincular matriz a filial.
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                int matriz = Convert.ToInt32(cbHeadOffice.SelectedValue);
                int branch = Convert.ToInt32(cbBoFilial.SelectedValue);
                if (matriz == 0 || branch == 0) { MessageBox.Show("Cadastre uma Empresa!", "Atenção! ", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if (matriz == branch) { MessageBox.Show("A Matriz não pode ser uma filial dela mesma !", "Atenção! ", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                headoficceModel.InsertWorkshiftPivotfromModel(matriz, branch);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
