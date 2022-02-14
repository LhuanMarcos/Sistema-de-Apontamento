using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using GUI_MODERNISTA.Entities;
using System.Windows.Forms;

namespace GUI_MODERNISTA.Controller
{
    public class RoleController
    {
        MySqlCommand sql;
        Connection con = new Connection();


        //Listagem de perfil
        public DataTable RoleListGridController(int status)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT role.role_id,role.nameRole, " +
                                               "IF(roleStatus > 0, 'Ativo', 'Inativo') AS status, " +
                                                "created_at " +
                                        "FROM role WHERE roleStatus ='" + status + "' ", con.con);
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

        //Listagem de perfil por status e nome
        public DataTable RoleListGridByRoleAndNameController(string roleName, int status)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT role.role_id,role.nameRole, " +
                                               "IF(roleStatus > 0, 'Ativo', 'Inativo') AS status, " +
                                                "created_at " +
                                        "FROM role WHERE nameRole  LIKE '%" + roleName + "%' AND roleStatus ='" + status + "' ", con.con);
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


        //Listagem de perfil do usuário
        public DataTable RoleListController()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT role_id, nameRole FROM role WHERE roleStatus ='1' ", con.con);
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

        // Busca o Gerente de acordo com a empresa
        public DataTable GetCompanyManagerController(int headOficce_id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT role_pivot.user_id, users.userName " +
                    "FROM role_pivot " +
                        "INNER JOIN users " +
                        "ON users.user_id = role_pivot.user_id " +
                        "INNER JOIN link_user_company_pivot " +
                        "ON link_user_company_pivot.user_id = role_pivot.user_id " +
                    "WHERE headOffice_id = '" + headOficce_id + "' " +
                    "AND role_pivot.role_id = '1' ; ", con.con);
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

        //Cdastro de Role
        public void InsertRoleInToDataBase(Role role)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO role (nameRole, roleStatus, created_at, updated_at) " +
                "values (@nameRole, " +
                "@roleStatus, " +
                "@created_at, " +
                "@updated_at) ", con.con);


                sql.Parameters.AddWithValue("@nameRole", role.RoleName);
                sql.Parameters.AddWithValue("@roleStatus", role.RoleStatus);
                sql.Parameters.AddWithValue("@created_at", role.Created_at);
                sql.Parameters.AddWithValue("@updated_at", role.Updated_at);

                sql.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.CloseConnection();
            }
        }

        // Salvar dados na tabela pi
        public void DepartmentSaveInPivotTable(Role role)
        {

            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO role (nameRole, roleStatus, created_at, updated_at) " +
                "values (@nameRole, " +
                "@roleStatus, " +
                "@created_at, " +
                "@updated_at') ", con.con);


                sql.Parameters.AddWithValue("@nameRole", role.RoleName);
                sql.Parameters.AddWithValue("@roleStatus", role.RoleStatus);
                sql.Parameters.AddWithValue("@created_at", role.Created_at);
                sql.Parameters.AddWithValue("@updated_at", role.Updated_at);

                sql.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.CloseConnection();
            }
        }


        // Inserir dados na tabela pivot de User e Role
        public DataTable InsertoInToPivotRoleController(int user_id, int role_id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO role_pivot (role_id, user_id) values ('" + role_id + "','" + user_id + "')", con.con);
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




        // Inserir dados na tabela pivot link_user_company_pivot 
        public DataTable InsertoInToPivotlinkUserCompanyPivotController(int headOffice_id, int branchHeadOffice_id, int department_id, int user_id)
        {
            try
            {


                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO link_user_company_pivot (headOffice_id, branchHeadOffice_id, department_id, user_id) " +
                    "values (@headOffice_id, @branchHeadOffice_id, @department_id, @user_id)", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                sql.Parameters.AddWithValue("@headOffice_id", headOffice_id == 0 ? (object)DBNull.Value : headOffice_id);
                sql.Parameters.AddWithValue("@branchHeadOffice_id", branchHeadOffice_id == 0 ? (object)DBNull.Value : branchHeadOffice_id);
                sql.Parameters.AddWithValue("@department_id", department_id == 0 ? (object)DBNull.Value : department_id);
                sql.Parameters.AddWithValue("@user_id", user_id == 0 ? (object)DBNull.Value : user_id);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }

        }
        // Alteração de Role
        public DataTable RoleUpdateFromController(Role role)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE role SET nameRole=@roleName, roleStatus=@roleStatus, updated_at=@Updated_at WHERE role_id = @role_id", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                sql.Parameters.AddWithValue("@roleName", role.RoleName);
                sql.Parameters.AddWithValue("@roleStatus", role.RoleStatus);
                sql.Parameters.AddWithValue("@Updated_at", role.Updated_at);
                sql.Parameters.AddWithValue("@role_id", role.Role_id);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SearchButtonIn()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT role.role_id, role.nameRole, " +
                                               "IF(roleStatus > 0, 'Ativo', 'Inativo') AS status, " +
                                                "created_at " +
                                        "FROM role WHERE roleStatus ='0'", con.con);
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
    }
}
