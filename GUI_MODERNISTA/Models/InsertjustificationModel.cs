using GUI_PONTO.Controller;
using GUI_PONTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PONTO.Models
{
    public class InsertjustificationModel
    {
        InsertJustificationController InJusController = new();
        //Listagem de inserção de justificativa
        public DataTable CategoryListGridModel(InsertJustification insertJustification)
        {
            try
            {
                DataTable dt = new();
                dt = InJusController.ListJustificationCreated(insertJustification);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //inserir correcao no banco
        public void  InsertCorrectionInTheTable(InsertJustification InJust)
        {

            try
            {
                InJusController.InsertCorrectionInTheTable(InJust);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
