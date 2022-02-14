using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using GUI_MODERNISTA.Entities;
using System.Windows.Forms;
using GUI_MODERNISTA;

namespace GUI_PONTO.Controller
{
    public class JustificationController
    {
        MySqlCommand sql;
        Connection con = new Connection();
        //Listagem de Justificativas
        public DataTable JustificationListGridController(int status)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT justification_id,justification, " +
                                               "IF(justificationStatus > 0, 'Ativo', 'Inativo') AS status, " +
                                                "created_at " +
                                        "FROM justification WHERE justificationStatus ='" + status + "' ", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Listagem de Justificativas PARA Combobox
        public DataTable JustificationListGridCombobox()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT justification_id, justification FROM justification WHERE justificationStatus = '1' ", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Listagem de justificativas por status e nome
        public DataTable RoleListGridByJustificationAndNameController(Justification jus)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT justification_id,justification, " +
                                               "IF(justificationStatus > 0, 'Ativo', 'Inativo') AS status, " +
                                                "created_at " +
                                        "FROM justification WHERE justification  LIKE '%" + jus.JustificationP + "%' AND justificationStatus ='" + jus.Statu + "' ", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Cdastro de justificativa
        public int InsertjustificationInToDataBase(Justification justification)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO justification (justification, justificationStatus, created_at, updated_at) " +
                "values (@justification, " +
                "@justificationStatus, " +
                "@created_at, " +
                "@updated_at) ", con.con);

                sql.Parameters.AddWithValue("@justification", justification.JustificationP);
                sql.Parameters.AddWithValue("@justificationStatus", justification.Statu);
                sql.Parameters.AddWithValue("@created_at", justification.Created_at);
                sql.Parameters.AddWithValue("@updated_at", justification.Updated_at);

                sql.ExecuteNonQuery();
                con.CloseConnection();


                if (sql.LastInsertedId != 0)
                    sql.Parameters.Add(new MySqlParameter("justification_id", sql.LastInsertedId));
                // Retorna o id do novo rgistro e convert de Int64 para Int32 (int).
                return Convert.ToInt32(sql.Parameters["@justification_id"].Value);

            }
            catch (Exception )
            {
                throw;
            }
        }
        public void LinkJustificationInToDatabase(int category_id, int justification_id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO justification_pivot (category_id, justification_id) " +
                "values (@category_id, @justification_id ) ", con.con);
                sql.Parameters.AddWithValue("@category_id", category_id);
                sql.Parameters.AddWithValue("@justification_id", justification_id);
                sql.ExecuteNonQuery();
                con.CloseConnection();

            }
            catch (Exception)
            {

                throw;
            }
        }
        //Update de justificativa
        public DataTable JustificationUpdateFromController(Justification just)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE justification SET justification=@justification, justificationStatus=@justificationStatus, updated_at=@updated_at WHERE justification_id = @justification_id", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                sql.Parameters.AddWithValue("@justification", just.JustificationP);
                sql.Parameters.AddWithValue("@justificationStatus", just.Statu);
                sql.Parameters.AddWithValue("@updated_at", just.Updated_at);
                sql.Parameters.AddWithValue("@justification_id", just.Jugistification_id);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
