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
    class RoleModel
    {
        RoleController roleController = new RoleController();

        #region GET
        //Preencher gridview role
        public DataTable RoleListGridModel(int status)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = roleController.RoleListGridController(status);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //busca reativa radio button inativo
        public DataTable SearchBtnIn()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = roleController.SearchButtonIn();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //busca reativa radio button ativo
        public DataTable SearchBtnAct(int status)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = roleController.RoleListGridController(status);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Listagem de cargo pos status e nome
        public DataTable RoleListGridByRoleAndNameFromModel(string roleName, int status)
        {
            DataTable dt = new();
            dt = roleController.RoleListGridByRoleAndNameController(roleName, status);

            return dt;
        }

        //listagem de role
        public DataTable RoleListModel()
        {

            try
            {
                DataTable dt = new DataTable();
                dt = roleController.RoleListController();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Listagem de Gerente de acordo com a empresa
        public DataTable GetCompanyManagerModel(int headOficce_id)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = roleController.GetCompanyManagerController(headOficce_id);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region POST
        //Inserir dados na tabela pivot de ROLE
        public DataTable InsertoInToPivotRoleModel(int user_id, int role_id)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = roleController.InsertoInToPivotRoleController(user_id, role_id);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Inserir dados na tabela de Role
        public void InsertRoleInToDataBaseFromModel(Role role)
        {
            try
            {
                roleController.InsertRoleInToDataBase(role);       
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Inserir dados na tabela pivor linkUserCompany
        public DataTable InsertoInToPivotlinkUserCompanyModel(int headOffice_id, int branchHeadOffice_id, int department_id, int user_id)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = roleController.InsertoInToPivotlinkUserCompanyPivotController(headOffice_id, branchHeadOffice_id, department_id, user_id);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //update de role
        public DataTable RoleUpdateFromModel(Role role)
        {
            try
            {
                DataTable dt = new();
                dt = roleController.RoleUpdateFromController(role);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        #endregion

    }
}
