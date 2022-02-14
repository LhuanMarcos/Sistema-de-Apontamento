using GUI_MODERNISTA;
using GUI_PONTO.Entities;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PONTO.Controller
{
    public class UserDao : Connection
    {
         MySqlCommand sql;
        private new Connection con = new Connection();

        public bool Login(string user, string pass)
        {


            using (var command = new MySqlCommand())
            {
       

                con.AbrirConexao();


                sql = new MySqlCommand("SELECT users.user_id, " +
                                               "userName, " +
                                               "re, " +
                                               "userPassword, " +
                                               "users.created_at, " +
                                               "rp.role_id, " +
                                               "role.nameRole " +
                                        "FROM users " +
                                            "INNER JOIN role_pivot rp ON rp.user_id = users.user_id " +
                                            "INNER JOIN role ON rp.role_id = role.role_id " +
                                        "WHERE users.userName=@user " +
                                          "AND users.userStatus='1' " +
                                          "AND users.userPassword=@pass", con.con);

                sql.Parameters.AddWithValue("@user", user);
                sql.Parameters.AddWithValue("@pass", pass);
                sql.CommandType = CommandType.Text;
                MySqlDataReader reader = sql.ExecuteReader();
                con.CloseConnection();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserCache.DBUserID = reader.GetInt32(0);
                        UserCache.DBName = reader.GetString(1);
                        UserCache.DBRe = reader.GetString(2);
                        UserCache.DBPassword = reader.GetString(3);
                        UserCache.DBCreated = reader.GetDateTime(4);
                        UserCache.DBRoleID = reader.GetInt32(5);
                        UserCache.DBroleName = reader.GetString(6);

                    }
                    return true;
                }
                else
                    return false;
            }
      
        }
    }
}
