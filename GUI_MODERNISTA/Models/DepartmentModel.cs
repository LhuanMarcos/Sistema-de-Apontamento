using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_MODERNISTA.Controller;
using System.Data;
using GUI_MODERNISTA.Entities;

namespace GUI_MODERNISTA.Models
{
    public class DepartmentModel
    {
        DepartmentController department = new DepartmentController();
        DepartmentController departmentController = new DepartmentController();


        //Listagem de Departamento Model
        public DataTable DepartmentList()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = department.DepartmentList();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Listagem de Edição
        public DataTable DepartmentListEdit(Department dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = department.InsertDepartmentInToDatabaseController(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Listagem para busca reativa
        public DataTable DepartmentListSearch(Department dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = department.InsertDepartmentSearchInToDatabaseController(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Listagem para busca reativa text changed
        public DataTable DepartamentListModel(Department dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = department.DepartmentSearchListFromController(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Listagem de Empresas Model
        public DataTable HeadOfficeListModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = department.HeadOfficeListController();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int SaveDepartmentModel(Department dado)
        {
            try
            {

                return department.Save(dado);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Criar categoria e vincular matriz, filial e departamento
        public void DepartmentSaveInPivotTable(int headOffice_id, int branchHeadOffice_id, int department_id)
        {
            try
            {
                department.DepartmentSaveInPivotTable(headOffice_id, branchHeadOffice_id, department_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetLastDepartmentId()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = department.GetLastDepartmentId();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
