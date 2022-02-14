using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_MODERNISTA.Entities;
using GUI_PONTO.Controller;
using System.Data;
using GUI_MODERNISTA.Controller;




namespace GUI_PONTO.Models
{
    class HolidayModel
    {
        HolidayController holidayController = new();
        HeadOfficeControloller headOfficeControloller = new();

        //listar feriado
        public DataTable HolidayListModel(Holiday dado)
        {
            
            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.HolidayListController(dado);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //busca radio button municipal
        public DataTable HolidayListMuniModel(Holiday dado)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.HolidayListMuniController(dado);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //busca radio button NACIONAL

        public DataTable HolidayListNaciModel(Holiday dado)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.HolidayListNaciController(dado);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //busca reativa
        public DataTable HolidayListModelReact(Holiday dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.HolidaySearchListFromController(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Listagem de Empresas Model
        public DataTable HolidayHeadOfficeListModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.HolidayheadOfficeListController();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Listagem de Filiais pertencente a empresa
        public DataTable BranchHeadOfficeListModel(int headOffice_id)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = headOfficeControloller.BranchHeadOfficeList(headOffice_id);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //salvar dados
        public int HolidaySaveModel(Holiday dado)
        {
            UserController userController = new UserController();
            try
            {
                return holidayController.Save(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //salvar na pivot
        public void HolidaytSaveInPivotTable(int headOffice_id, int branchHeadOffice_id, int holiday_id)
        {
            try
            {
                holidayController.holidaySaveInPivotTable(headOffice_id, branchHeadOffice_id, holiday_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //editar dados
        public DataTable HolidayListEdit(Holiday dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.InsertEditHolidayInToDatabaseController(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //excluir da tabela pivot
        public DataTable PivotDelete(Holiday dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.DeleteIdInPivot(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //excluir da tabela Holiday
        public DataTable HolidayDelete(Holiday dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = holidayController.DeleteIdInHoliday(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
