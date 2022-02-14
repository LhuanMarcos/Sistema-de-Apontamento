using GUI_PONTO.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PONTO.Models
{
    public class WorkShiftModel
    {
        WorkShiftController workShiftController = new WorkShiftController();

        //Listagem de Empresas
        public DataTable WorkShiftListModel()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = workShiftController.WorkShiftListController();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region POST

        //Inserir Dados na Tabela de Pivot WorlShift
        public DataTable InsertWorkshiftPivotModel(int user_id, int workShift_id)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = workShiftController.InsertWorkshiftPivotController(user_id, workShift_id);
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
