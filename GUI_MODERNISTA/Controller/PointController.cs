using GUI_MODERNISTA;
using GUI_MODERNISTA.Entities;
using MySqlConnector;
using System;
using System.Data;

namespace GUI_PONTO.Controller
{

    public class PointController
    {
        MySqlCommand sql;
        Connection con = new Connection();

        // Inserir dados na tabela pivot de User e Role
        public DataTable InsertTemplateInToDatabaseController(string textFir, string user_RE)
        {

            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE users SET template='" + textFir + "'  WHERE re = '" + user_RE + "'", con.con);
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


        // Inserir dados na tabela pivot de User e Role
        public DataTable GetuserTemplateController()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT user_id, template FROM users WHERE template IS NOT NULL;", con.con);
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

        //busca a marcação de ponto do dia por re
        public DataTable TimestampSearchByRe(string user_re)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT user_re, username , pointOne, pointTwo, pointTree, pointFour " +
                    "FROM points " +
                    "INNER JOIN users on re = user_re " +
                    "WHERE DATE(points.created_at) = CURDATE() " +
                    "AND user_re ='" + user_re + "'", con.con);

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

        //Busca de Re
        public string ReturnUserRe(int user_id)
        {
            con.AbrirConexao();
            sql = new MySqlCommand("SELECT re FROM users WHERE user_id =  '" + user_id + "'", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = sql;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0]["re"].ToString();
        }


        #region CADASTRO DE MARCAÇÃO DE PONTO
        // Inserir marcação de ponto no banco de dados

        public bool IfTheUserWasBeenRegisteredOnTheDay(string user_re)
        {
            con.AbrirConexao();
            sql = new MySqlCommand("SELECT user_re FROM points WHERE created_at = CURDATE() AND user_re = '" + user_re + "'", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = sql;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        //inserir ponto no banco 
        public string InsertoPointInToDataBaseFromController(PointC p)
        {
            try
            {
                DateTime dateToday;
                dateToday = DateTime.Today;
                con.AbrirConexao();
                string local = "Local";
                string mysql = null;
                if (IfTheUserWasBeenRegisteredOnTheDay(p.User_re) == false)
                {

                    if (p.PointOne.Kind.ToString() == local)
                    {
                        mysql = "INSERT INTO points (user_re, pointOne,  created_at, updated_at,user_id) values ( @user_re, CURRENT_TIMESTAMP(), @created_at, @updated_at,@user_id);";
                    }
                    if (p.PointTwo.Kind.ToString() == local)
                    {
                        mysql = "INSERT INTO points (user_re, pointTwo,  created_at, updated_at, user_id) values ( @user_re, CURRENT_TIMESTAMP(), @created_at, @updated_at,@user_id);";
                    }

                    if (p.PointTree.Kind.ToString() == local)
                    {
                        mysql = "INSERT INTO points (user_re, pointTree,  created_at, updated_at,user_id) values ( @user_re, CURRENT_TIMESTAMP(), @created_at, @updated_at,@user_id);";
                    }

                    if (p.PointFour.Kind.ToString() == local)
                    {
                        mysql = "INSERT INTO points (user_re, pointFour,  created_at, updated_at,user_id) values ( @user_re, CURRENT_TIMESTAMP(), @created_at, @updated_at,@user_id);";
                    }


                }
                else
                {


                    if (p.PointOne.Kind.ToString() == local)
                    {
                        mysql = "UPDATE points SET " +
                                "user_re=@user_re, " +
                                "pointOne=CURRENT_TIMESTAMP(), " +
                                "created_at=@created_at, " +
                                "user_id=@user_id, " +
                                "updated_at=@updated_at WHERE user_re=@user_re AND created_at = CURDATE() ";

                    }
                    if (p.PointTwo.Kind.ToString() == local)
                    {

                        mysql = "UPDATE points SET " +
                                "user_re=@user_re, " +
                                "pointTwo=CURRENT_TIMESTAMP(), " +
                                "created_at=@created_at, " +
                                "user_id=@user_id, " +
                                "updated_at=@updated_at WHERE user_re=@user_re AND created_at = CURDATE() ";

                    }
                    if (p.PointTree.Kind.ToString() == local)
                    {
                        mysql = "UPDATE points SET " +
                                  "user_re=@user_re, " +
                                  "pointTree=CURRENT_TIMESTAMP(), " +
                                  "created_at=@created_at, " +
                                  "updated_at=@updated_at WHERE user_re=@user_re AND created_at = CURDATE() ";
                    }
                    if (p.PointFour.Kind.ToString() == local)
                    {

                        mysql = "UPDATE points SET " +
                            "user_re=@user_re, " +
                            "pointFour=CURRENT_TIMESTAMP(), " +
                            "created_at=@created_at, " +
                            "user_id=@user_id, " +
                            "updated_at=@updated_at WHERE user_re=@user_re AND created_at = CURDATE() ";
                    }


                }

                sql = new MySqlCommand(mysql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                sql.Parameters.AddWithValue("@user_re", p.User_re == "" ? (object)DBNull.Value : p.User_re);

                if (p.PointOne.Kind.ToString() == local)
                {
                    sql.Parameters.AddWithValue("@pointOne", p.PointOne.Kind.ToString() != "Local" ? (object)DBNull.Value : p.PointOne);
                }
                if (p.PointTwo.Kind.ToString() == local)
                {
                    sql.Parameters.AddWithValue("@pointTwo", p.PointTwo.Kind.ToString() != "Local" ? (object)DBNull.Value : p.PointTwo);
                }
                if (p.PointTree.Kind.ToString() == local)
                {
                    sql.Parameters.AddWithValue("@pointTree", p.PointTree.Kind.ToString() != "Local" ? (object)DBNull.Value : p.PointTree);
                }
                if (p.PointFour.Kind.ToString() == local)
                {
                    sql.Parameters.AddWithValue("@pointFour", p.PointFour.Kind.ToString() != "Local" ? (object)DBNull.Value : p.PointFour);
                }


                sql.Parameters.AddWithValue("@user_id", p.User_id);
                sql.Parameters.AddWithValue("@created_at", dateToday);
                sql.Parameters.AddWithValue("@updated_at", dateToday);

                sql.ExecuteNonQuery();
                con.CloseConnection();

                return (string)sql.Parameters["@user_re"].Value;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion


        //busca de pontode acordo com o re
        public DataTable SearchByUserReFormController(PointC point)
        {
            try
            {
                con.AbrirConexao();

                string mysql = "SELECT user_re, userName, " +
                                       "TIME(pointOne) AS Entrada_1, " +
                                       "TIME(pointTwo) AS Saida_1, " +
                                       "TIME(pointTree) AS Entrada_2, " +
                                       "TIME(pointFour) AS Saida_2, " +
                                       "justification.justification, " +
                                       "DATE(points.created_at) as created_at " +
                                "FROM points " +
                                    "LEFT JOIN justification_pivot " +
                                        "ON justification_pivot.Jpivot_id = points.justifPivot_id " +
                                    "LEFT JOIN justification " +
                                        "ON justification.justification_id = justification_pivot.justification_id " +
                                    "INNER JOIN users " +
                                        "ON users.user_id = points.user_id " +
                                    "INNER JOIN link_user_company_pivot " +
                                        "ON link_user_company_pivot.user_id = users.user_id " +
                                "WHERE users.userStatus = '1' ";

                sql = new MySqlCommand(mysql, con.con);
                if (point.User_re.Length > 0)

                    mysql += "AND re LIKE  '%" + point.User_re + "%' AND DATE(points.created_at) BETWEEN '" + point.StarSearch + "' AND '" + point.EndSearch + "' " + "AND link_user_company_pivot.headOffice_id = '" + point.HeadOffice + "' ";

                if (!string.IsNullOrEmpty(point.UserName))

                    mysql += "AND userName LIKE  '%" + point.UserName + "%' AND DATE(points.created_at) BETWEEN '" + point.StarSearch + "' AND '" + point.EndSearch + "' " + " AND link_user_company_pivot.headOffice_id = '" + point.HeadOffice + "' ";

                if (point.BrantHeadOffice1 > 0)
                {
                    mysql += "AND link_user_company_pivot.branchHeadOffice_id = '" + point.BrantHeadOffice1 + "' ";
                }

                mysql += " ORDER BY created_at DESC";

                sql = new MySqlCommand(mysql, con.con);
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

        public DataTable UpdatePointInToDataBaseFromController(PointC p)
        {
            try
            {
                DateTime dateToday;
                dateToday = DateTime.Today;
                con.AbrirConexao();
                string mysql = null;

                mysql = "UPDATE points SET  " +
                    "updateUser_id = '"+ p.UpdateUser_id +"', " +
                    "pointOne = '" + p.CreatedDate + " " + p.POne + "', " +
                    "pointTwo = '" + p.CreatedDate + " " + p.PTwo + "', " +
                    "pointTree = '" + p.CreatedDate + " " + p.PTree + "', " +
                    "pointFour = '" + p.CreatedDate + " " + p.PFour + "' " +
                    "WHERE user_re = '" + p.User_re + "' " +
                    "AND DATE(created_at) = '" + p.CreatedDate + "';";

                sql = new MySqlCommand(mysql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;

                con.CloseConnection();

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable HoursBD()
        {

            try
            {

                con.AbrirConexao();
                sql = new MySqlCommand("SELECT CURRENT_TIMESTAMP();", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                con.CloseConnection();
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
