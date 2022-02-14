using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using GUI_MODERNISTA.Entities;
using System.Data;
using System.Windows.Forms;
using GUI_MODERNISTA;


namespace GUI_PONTO.Controller
{
    class HolidayController
    {

        MySqlCommand sql;
        Connection con = new Connection();

        //listagem de produto
        public DataTable HolidayListController(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT holiday.holidayName, holiday.holiday_id, IF(holidayType > 0, 'Nacional', 'Municipal') " +
                    "AS statusType, holiday.created_at, link_user_company_pivot.headOffice_id, headOffice, branchName,link_user_company_pivot.branchHeadOffice_id, IF(statusFixed > 0, 'Sim', 'Não') " +
                    "AS statusFixed, holidayDate " +
                    "FROM holiday " +
                    "INNER JOIN link_user_company_pivot " +
                    "ON link_user_company_pivot.holiday_id = holiday.holiday_id " +
                    "LEFT JOIN head_office " +
                    "ON head_office.headOffice_id = link_user_company_pivot.headOffice_id " +
                    "LEFT JOIN branch_head_office " +
                    "ON branch_head_office.branchHeadOffice_id = link_user_company_pivot.branchHeadOffice_id", con.con);
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
        //radio button busca municipal
        public DataTable HolidayListMuniController(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT holiday.holidayName, holiday.holiday_id, IF(holidayType > 0, 'Nacional', 'Municipal')AS status, created_at, headOffice_id, branchHeadOffice_id, IF(statusFixed > 0, 'Sim', 'Não')AS status, holidayDate " +
                    "FROM holiday INNER JOIN link_user_company_pivot " +
                    "ON link_user_company_pivot.holiday_id = holiday.holiday_id  WHERE holidayType = '0'", con.con);                                        
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

        //radio button busca nacional
        public DataTable HolidayListNaciController(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT holiday.holidayName, holiday.holiday_id, IF(holidayType > 0, 'Nacional', 'Municipal')AS status, created_at, headOffice_id, branchHeadOffice_id, IF(statusFixed > 0, 'Sim', 'Não')AS status, holidayDate " +
                    "FROM holiday INNER JOIN link_user_company_pivot " +
                    "ON link_user_company_pivot.holiday_id = holiday.holiday_id  WHERE holidayType = '1'", con.con);
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

        //busca reativa
        public DataTable HolidaySearchListFromController(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT holiday_id, holidayName, IF(holiday.holidayType > 0, 'Nacinal', 'Municipal') AS status," +
                    " created_at FROM holiday WHERE holidayName LIKE '%" + dado.HolidayName + "%'  AND holidayType = '" + dado.Type + "' ", con.con);
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
        //buscar headOffice
        public DataTable HolidayheadOfficeListController()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT headOffice_id, headOffice FROM head_office", con.con);
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
        //salvar no banco
        public int Save(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO holiday (holidayName, statusFixed, holidayType , holidayDate ,created_at, updated_at) values (@holidayName, @statusFixed, @holidayType, @holidayDate,@created_at, @updated_at)", con.con);
                sql.Parameters.AddWithValue("@holidayName", dado.HolidayName);
                sql.Parameters.AddWithValue("@statusFixed", dado.StatusFixed);
                sql.Parameters.AddWithValue("@holidayType", dado.Type);
                sql.Parameters.AddWithValue("@holidayDate", dado.Date);
                sql.Parameters.AddWithValue("@created_at", dado.Created_at);
                sql.Parameters.AddWithValue("@updated_at", dado.Updated_at);

                sql.ExecuteNonQuery();
                // Verifica se existe um ultimo id inserido e adiciona um
                // parametro para tratá-lo
                if (sql.LastInsertedId != 0)
                    sql.Parameters.Add(new MySqlParameter("holiday_id", sql.LastInsertedId));
                // Retorna o id do novo rgistro e convert de Int64 para Int32 (int).
                return Convert.ToInt32(sql.Parameters["@holiday_id"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }

        //salvar na pivot
        public void holidaySaveInPivotTable(int headOffice_id, int branchHeadOffice_id, int holiday_id)
        {


            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO link_user_company_pivot (headOffice_id, branchHeadOffice_id, holiday_id) values (@headOffice_id, @branchHeadOffice_id, @holiday_id)", con.con);


                sql.Parameters.AddWithValue("@headOffice_id", headOffice_id == 0 ? (object)DBNull.Value : headOffice_id);
                sql.Parameters.AddWithValue("@branchHeadOffice_id", branchHeadOffice_id == 0 ? (object)DBNull.Value : branchHeadOffice_id);
                sql.Parameters.AddWithValue("@holiday_id", holiday_id == 0 ? (object)DBNull.Value : holiday_id);


                sql.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.CloseConnection();
            }
        }
        //edição de dados
        public DataTable InsertEditHolidayInToDatabaseController(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE holiday SET holidayName=@holidayName, holidayType=@holidayType, statusFixed=@statusFixed, holidayDate=@holidayDate where holiday_id = @holiday_id ", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;

                sql.Parameters.AddWithValue("@holidayName", dado.HolidayName);
                sql.Parameters.AddWithValue("@holidayType", dado.Type);
                sql.Parameters.AddWithValue("@statusFixed", dado.StatusFixed);
                sql.Parameters.AddWithValue("@holidayDate", dado.Date);
                sql.Parameters.AddWithValue("@holiday_id", dado.Holiday_id);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //deletar da tabela pivot
        public DataTable DeleteIdInPivot(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM link_user_company_pivot WHERE holiday_id = @holiday_id ", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;

                sql.Parameters.AddWithValue("@holiday_id", dado.Holiday_id);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //deletar da tabela Holiday
        public DataTable DeleteIdInHoliday(Holiday dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM holiday WHERE holiday_id = @holiday_id ", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;

                sql.Parameters.AddWithValue("@holiday_id", dado.Holiday_id);

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
