using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using GUI_MODERNISTA.Entities;
using GUI_MODERNISTA;

namespace GUI_PONTO.Controller
{
    public class WorkShiftController
    {
        MySqlCommand sql;
        Connection con = new Connection();

        //Listagem de Turnos da Empresa
        public DataTable WorkShiftListController()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT shift_id, shift FROM   work_shift;", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region POST
        //Inserid Dados na Tabela Pivot
        public DataTable InsertWorkshiftPivotController(int user_id, int workShift_id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO work_shift_pivot (user_id,workShift_id) values ('" + user_id + "','" + workShift_id + "')", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
