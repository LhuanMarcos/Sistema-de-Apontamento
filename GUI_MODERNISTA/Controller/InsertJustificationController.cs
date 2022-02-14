using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_MODERNISTA.Entities;
using System.Windows.Forms;
using GUI_MODERNISTA;
using GUI_PONTO.Entities;
using MySqlConnector;
using System.Data;

namespace GUI_PONTO.Controller
{
    public class InsertJustificationController
    {
        MySqlCommand sql;
        Connection con = new Connection();

        public DataTable ListJustificationCreated(InsertJustification inJustification)
        {
            try
            {
                con.AbrirConexao();

                string mysql = "  SELECT users.user_id as user_id, " +
                                 "users.userName as userName, " +
                                 "link_user_company_pivot.headOffice_id as company_id, " +
                                 "head_office.headOffice as company, " +
                                 "link_user_company_pivot.branchHeadOffice_id as filial, " +
                                 "branch_head_office.branchName as nomeFilial, " +
                                 "insert_justification.user_id, " +
                                 "justification.justification, " +
                                 "insert_justification.category_id, " +
                                 "justification_category.category, " +
                                 "insert_justification.JustTime " +
                           "FROM users " +
                               "LEFT JOIN insert_justification " +
                                  "ON insert_justification.user_id = users.user_id " +
                         "LEFT JOIN justification " +
                                   "ON insert_justification.justification_id = justification.justification_id " +
                         "LEFT JOIN justification_category " +
                                   "ON justification_category.category_id = insert_justification.category_id " +
                         "LEFT JOIN link_user_company_pivot " +
                                   "ON link_user_company_pivot.user_id = users.user_id " +
                         "LEFT JOIN head_office " +
                                   "ON head_office.headOffice_id = link_user_company_pivot.headOffice_id " +
                         "LEFT JOIN branch_head_office " +
                                   "ON branch_head_office.branchHeadOffice_id = link_user_company_pivot.branchHeadOffice_id " +
                         "WHERE users.userStatus = '1' ";

                if (!String.IsNullOrEmpty(inJustification.User_re))
                    mysql += "AND users.re LIKE '%" + inJustification.User_re + "%' ";
                if (!String.IsNullOrEmpty(inJustification.UserName))
                    mysql += "AND users.userName LIKE '%" + inJustification.UserName + "%' ";
                if (inJustification.HeadOffice_id > 0 && inJustification.BranchHeadOffice_id == 0)
                    mysql += "AND head_office.headOffice_id = '" + inJustification.HeadOffice_id + "' ";
                if (inJustification.HeadOffice_id > 0 && inJustification.BranchHeadOffice_id > 0)

                   mysql += "AND branch_head_office.branchHeadOffice_id = '" + inJustification.BranchHeadOffice_id + "'";             

                sql = new MySqlCommand(mysql, con.con);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.CloseConnection();
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void InsertCorrectionInTheTable(InsertJustification InJust)
        {
            try
            {
                

                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO insert_justification(" +
                    "user_id, " +
                    "category_id, " +
                    "justification_id, " +
                    "userCreated_id, " +
                    "JustTime, " +
                    "JustDate, " +
                    "DateStart, " +
                    "DateEnd , " +
                    "justDateOccurrence, " +
                    "observation, " +
                    "compensatoryDay, " +
                    "created_at, " +
                    "updated_at" +
                    ") values (" +
                    "@user_id, " +
                    "@category_id, " +
                    "@justification_id, " +
                    "@userCreated_id, " +
                    "TIME(@JustTime), " +
                    "@JustDate, " +
                    "@DateStart, " +
                    "@DateEnd , " +
                    "@justDateOccurrence, " +
                    "@observation, " +
                    "@compensatoryDay, " +
                    "@created_at, " +
                    "@updated_at" +
                    ");", con.con);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;

                sql.Parameters.AddWithValue("@user_id", InJust.User_id == 0 ? (object)DBNull.Value : InJust.User_id);
                sql.Parameters.AddWithValue("@category_id", InJust.Category_id == 0 ? (object)DBNull.Value : InJust.Category_id);
                sql.Parameters.AddWithValue("@justification_id", InJust.Justification_id == 0 ? (object)DBNull.Value : InJust.Justification_id);
                sql.Parameters.AddWithValue("@userCreated_id", InJust.UserCreation_id1 == 0 ? (object)DBNull.Value : InJust.UserCreation_id1);
                sql.Parameters.AddWithValue("@JustTime", InJust.Hours == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.Hours);
                sql.Parameters.AddWithValue("@JustDate", InJust.DateTimeJus == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.DateTimeJus);


                sql.Parameters.AddWithValue("@DateStart", InJust.BeginDate == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.BeginDate);
                sql.Parameters.AddWithValue("@DateEnd", InJust.EndDate2 == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.EndDate2);

                sql.Parameters.AddWithValue("@justDateOccurrence", InJust.DateTimeJus == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.DateTimeJus);

                sql.Parameters.AddWithValue("@observation", InJust.Observation);
                sql.Parameters.AddWithValue("@compensatoryDay", InJust.CompensatedDay == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.CompensatedDay);
                sql.Parameters.AddWithValue("@created_at", InJust.Created_at == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.Created_at);
                sql.Parameters.AddWithValue("@updated_at", InJust.Updated_at == Convert.ToDateTime("01/01/0001 00:00:00 ") ? (object)DBNull.Value : InJust.Updated_at);

                sql.ExecuteNonQuery();
                con.CloseConnection();

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
