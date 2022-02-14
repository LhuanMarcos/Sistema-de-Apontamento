using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_MODERNISTA.Controller;
using System.Data;
using GUI_MODERNISTA.Entities;
using GUI_PONTO.Entities;

namespace GUI_MODERNISTA.Models
{
    public class HeadOfficeModel
    {
        HeadOfficeControloller headOfficeControloller = new HeadOfficeControloller();

        //Listagem de Empresas
        public DataTable HeadOfficeList(int status, string headOffice)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = headOfficeControloller.HeadOfficeList(status, headOffice);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        //endereço e matriz salvar
        public void addresHeadOfficeSaveModel(Addres addres)
        {
            
            try
            {
                headOfficeControloller.addresHeadOfficeSaveController(addres);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //alterar dados de endereço
        public void addresUserEditModel(Addres addres)
        {
            
            try
            {
                headOfficeControloller.AddresUpdateHeadOffice(addres);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Retorna o id da empresa pelo nome
        public DataTable GetHeadOfficeIdRetourn(string headOffice)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = headOfficeControloller.GetHeadOfficeIdRetourn(headOffice);
                return dt;
            }
            catch (Exception)
            {
                throw;
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

        //inserir matriz no banco
        public int InsertHeadOfficeInToDatabaseFromModel(HeadOffice headOffice)
        {
            return headOfficeControloller.InsertHeadOfficeFromController(headOffice);
        }

        //Inserir Dados na tabela Pivot de Empresas   UpdateHeadOfficeFromController
        public void InsertWorkshiftPivotfromModel(int headOffice_id, int branchHeadOffice_id)
        {
            try
            {
                headOfficeControloller.InsertWorkshiftPivotController(headOffice_id, branchHeadOffice_id);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //uPDATE Dados na tabela Pivot de Empresas   UpdateHeadOfficeFromController
        public void UpdateHeadOfficeFrommModel(HeadOffice headOffice)
        {
            try
            {
                headOfficeControloller.UpdateHeadOfficeFromController(headOffice);
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
