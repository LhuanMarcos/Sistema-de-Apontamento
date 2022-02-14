using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using GUI_MODERNISTA.Entities;
using System.Windows.Forms;
using GUI_PONTO.Entities;

namespace GUI_MODERNISTA.Controller
{
    public class UserController
    {
        MySqlCommand sql;
        Connection con = new Connection();
        

        #region Busca na tabela de Users

        //Listagem de Usuários

        public DataTable UserListCombo()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT user_id, userName FROM users;", con.con);
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



        //Listagem de usuarios
       public DataTable UserListController(User user)
       {
            
            try
            {
                con.AbrirConexao();

                string mysql = "SELECT users.user_id, " +
                    "userName, " +
                    "IF(userStatus > 0, 'Ativo', 'Inativo')AS status, " +
                    "re, " +
                    "head_office.headOffice, " +
                    "admission, " +
                    "head_office.headOffice_id, " +
                    "link_user_company_pivot.branchHeadOffice_id, " +
                    "link_user_company_pivot.department_id, " +
                    "role_pivot.role_id, " +
                    "work_shift_pivot.workShift_id, " +
                    "compensatoryTimeOff, " +
                    "usePassword, " +
                    "verifyInput, " +
                    "appointmentEveryDay, " +
                    "registPoint, " +
                    "userPassword, " +
                    "pis, " +
                    "serieWorkCard, " +
                    "numberWorkCard, " +
                    "appointmentEveryDay, " +
                    "department.departmentt,  " +
                    "address.zipCode,  " +
                    "address.number,  " +
                    "address.street,  " +
                    "address.complement,  " +
                    "address.district,  " +
                    "address.location,  " +
                    "address.uf,  " +
                    "address.address_id, " +
                    "JustTime " +


                    "FROM users  " +
                    "LEFT JOIN link_user_company_pivot  " +
                    "ON link_user_company_pivot.user_id = users.user_id  " +
                    "LEFT JOIN head_office  " +
                    "ON head_office.headOffice_id = link_user_company_pivot.headOffice_id  " +
                    "LEFT JOIN role_pivot  " +
                    "ON  role_pivot.user_id = users.user_id  " +
                    "LEFT JOIN work_shift_pivot  " +
                    "ON work_shift_pivot.user_id = users.user_id " +
                      "LEFT JOIN address  " +
                      "ON address.user_id = users.user_id " +
                    "LEFT JOIN department " +
                    "ON department.department_id = link_user_company_pivot.department_id WHERE "; 


                if (user.HeadOffice_id == 1 || user.HeadOffice_id == 2 || user.HeadOffice_id == 3)
                    mysql += "userStatus = " + user.UserStatus;

                if (user.HeadOffice_id > 0)
                    mysql += " AND link_user_company_pivot.headOffice_id = " + user.HeadOffice_id;

                if (!String.IsNullOrEmpty(user.Re))
                    mysql += " AND re LIKE '%" + user.Re + "%'";

                if (!String.IsNullOrEmpty(user.UserName))
                    mysql += " AND userName LIKE '%" + user.UserName + "%'";
        

                sql = new MySqlCommand(mysql, con.con);
                sql.ExecuteNonQuery();
                con.CloseConnection();
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


        #endregion


        //inserir dados do usuario na tabela users
        public int userSaveController(User dado)
        {


            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO users " +
                    "(" +
                    "userName, " +
                    "numberWorkCard, " +
                    "serieWorkCard, " +
                    "pis, " +
                    "re, " +
                    "userStatus, " +
                    "admission, " +
                    "resignation, " +
                    "registPoint, " +
                    "usePassword, " +
                    "compensatoryTimeOff, " +
                    "verifyInput, " +
                    "userPassword, " +
                    "appointmentEveryDay, " +
                    "created_at, " +
                    "update_at, " +
                    "JustTime " +
                    ") " +
                    "values " +
                    "( " +
                    "@userName, " +
                    "@numberWorkCard, " +
                    "@serieWorkCard, " +
                    "@pis, " +
                    "@re, " +
                    "@userStatus, " +
                    "@admission, " +
                    "@resignation, " +
                    "@registPoint, " +
                    "@usePassword, " +
                    "@compensatoryTimeOff, " +
                    "@verifyInput, " +
                    "@userPassword, " +
                    "@appointmentEveryDay, " +
                    "@created_at, " +
                    "@update_at, " +
                    "TIME(@JustTime) " +
                    ")", con.con);

                sql.Parameters.AddWithValue("@userName", dado.UserName);
                sql.Parameters.AddWithValue("@numberWorkCard", dado.NumberWorkCard);
                sql.Parameters.AddWithValue("@serieWorkCard", dado.SerieWorkCard);
                sql.Parameters.AddWithValue("@pis ", dado.Pis);
                sql.Parameters.AddWithValue("@re", dado.Re);
                sql.Parameters.AddWithValue("@userStatus", dado.UserStatus);
                sql.Parameters.AddWithValue("@admission ", dado.Admission);
                sql.Parameters.AddWithValue("@resignation", null);
                sql.Parameters.AddWithValue("@registPoint", dado.RegistPoint);
                sql.Parameters.AddWithValue("@usePassword", dado.UsePassword);
                sql.Parameters.AddWithValue("@compensatoryTimeOff", dado.CompensatoryTimeOff);
                sql.Parameters.AddWithValue("@verifyInput ", dado.VerifyInput);
                sql.Parameters.AddWithValue("@userPassword", dado.Password);
                sql.Parameters.AddWithValue("@appointmentEveryDay", dado.AppointmentEveryDay);
                sql.Parameters.AddWithValue("@created_at", dado.DataCadastro);
                sql.Parameters.AddWithValue("@update_at", dado.UpdateCadastro);
                sql.Parameters.AddWithValue("@JustTime", dado.JustTime);

                sql.ExecuteNonQuery();
                con.CloseConnection();

                if (sql.LastInsertedId != 0)
                    sql.Parameters.Add(new MySqlParameter("user_id", sql.LastInsertedId));

                return Convert.ToInt32(sql.Parameters["@user_id"].Value);
            }
            catch (Exception)
            {

                throw;

            }
        }
        //Alterar dado na tabela
        public int UserUpdateController(User user)
        {
            
            
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(" UPDATE users AS users " +
                    "INNER JOIN link_user_company_pivot " +
                    "ON link_user_company_pivot.user_id = users.user_id " +
                    "INNER JOIN head_office" +
                    " ON head_office.headOffice_id = link_user_company_pivot.headOffice_id " +
                    "INNER JOIN role_pivot " +
                    "ON  role_pivot.user_id = users.user_id " +
                    "INNER JOIN work_shift_pivot " +
                    "ON work_shift_pivot.user_id = users.user_id " +
                    "SET userName=@userName, " +
                    "numberWorkCard=@numberWorkCard, " +
                    "link_user_company_pivot.headOffice_id=@headOffice_id, " +
                    "serieWorkCard=@serieWorkCard, " +
                    "pis=@pis, " +
                    "re=@re, " +
                    "userStatus=@userStatus, " +
                    "admission=@admission, " +
                    "resignation=@resignation, " +
                    "registPoint=@registPoint, " +
                    "usePassword=@usePassword, " +
                    "compensatoryTimeOff=@compensatoryTimeOff, " +
                    "verifyInput=@verifyInput, " +
                    "userPassword=@userPassword, " +
                    "appointmentEveryDay=@appointmentEveryDay,  " +
                    "link_user_company_pivot.department_id=@department_id,  " +
                    "update_at=@update_at, " +
                    "JustTime=@justTime " +
                    "WHERE users.user_id =@user_id  " +
                    "AND link_user_company_pivot.user_id =@user_id"

                    , con.con);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;

                sql.Parameters.AddWithValue("@user_id", user.User_id);
                sql.Parameters.AddWithValue("@userName", user.UserName);
                sql.Parameters.AddWithValue("@numberWorkCard", user.NumberWorkCard);
                sql.Parameters.AddWithValue("@serieWorkCard", user.SerieWorkCard);
                sql.Parameters.AddWithValue("@pis ", user.Pis);
                sql.Parameters.AddWithValue("@re", user.Re);
                sql.Parameters.AddWithValue("@userStatus", user.UserStatus);
                sql.Parameters.AddWithValue("@admission ", user.Admission);
                sql.Parameters.AddWithValue("@resignation", null);
                sql.Parameters.AddWithValue("@registPoint", user.RegistPoint);
                sql.Parameters.AddWithValue("@usePassword", user.UsePassword);
                sql.Parameters.AddWithValue("@compensatoryTimeOff", user.CompensatoryTimeOff);
                sql.Parameters.AddWithValue("@verifyInput ", user.VerifyInput);
                sql.Parameters.AddWithValue("@userPassword", user.Password);
                sql.Parameters.AddWithValue("@appointmentEveryDay", user.AppointmentEveryDay);
                sql.Parameters.AddWithValue("@created_at", user.DataCadastro);
                sql.Parameters.AddWithValue("@update_at", user.UpdateCadastro);
                sql.Parameters.AddWithValue("@headOffice_id", user.HeadOffice_id);
                sql.Parameters.AddWithValue("@department_id", user.Department_id);
                sql.Parameters.AddWithValue("@workshift_id", user.WorkShift_id);
                sql.Parameters.AddWithValue("@justTime", user.JustTime);
               

                sql.ExecuteNonQuery();
                con.CloseConnection();

                if (sql.LastInsertedId != 0)
                    sql.Parameters.Add(new MySqlParameter("user_id", sql.LastInsertedId));
              
                return Convert.ToInt32(sql.Parameters["@user_id"].Value);

            }
            catch (Exception)
            {

                throw;

            }
        }       
        //
        //alterar dados na tabela Addres
        //
        public void AddresUpdateController(Addres addres)
        {


            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE address AS address " +               
                    "SET zipCode=@zipCode, " +
                    "number=@number, " +
                    "street=@street, " +
                    "complement=@complement, " +
                    "district=@district, " +
                    "location=@location, " +
                    "uf=@uf " +                                  
                    "WHERE address.address_id = @addres_id " 
                     
                    

                    , con.con);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;


                sql.Parameters.AddWithValue("@addres_id", addres.Addres_id);
                sql.Parameters.AddWithValue("@zipCode", addres.Cep);
                sql.Parameters.AddWithValue("@number", addres.Number);
                sql.Parameters.AddWithValue("@user_id", addres.User_id);
                sql.Parameters.AddWithValue("@street", addres.Street);
                sql.Parameters.AddWithValue("@complement", addres.Complement);
                sql.Parameters.AddWithValue("@district", addres.District);
                sql.Parameters.AddWithValue("@location", addres.Location);
                sql.Parameters.AddWithValue("@uf", addres.Uf);


                sql.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception)
            {

                throw;

            }
        }



        //insert na tabela Addres
        public void addresSaveController(Addres addres)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO address " +
                    "(" +
                    "zipCode, " +
                    "number, " +
                    "user_id, " +
                    "headOffice_id, " +
                    "street, " +
                    "complement, " +
                    "district, " +
                    "location, " +
                    "uf " +
                    ") " +
                    "values " +
                    "( " +
                    "@zipCode, " +
                    "@number, " +
                    "@user_id, " +
                    "@headOffice_id, " +
                    "@street, " +
                    "@complement, " +
                    "@district, " +
                    "@location, " +
                    "@uf  " +
                    ")", con.con);

                    sql.Parameters.AddWithValue("@addres_id", addres.Addres_id);
                    sql.Parameters.AddWithValue("@headOffice_id", addres.HeadOffice_id);
                    sql.Parameters.AddWithValue("@zipCode", addres.Cep);
                    sql.Parameters.AddWithValue("@number", addres.Number);
                    sql.Parameters.AddWithValue("@user_id", addres.User_id);
                    sql.Parameters.AddWithValue("@street", addres.Street);
                    sql.Parameters.AddWithValue("@complement", addres.Complement);
                    sql.Parameters.AddWithValue("@district", addres.District);
                    sql.Parameters.AddWithValue("@location", addres.Location);
                    sql.Parameters.AddWithValue("@uf", addres.Uf);

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
