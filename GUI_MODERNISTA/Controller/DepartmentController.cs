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
    class DepartmentController
    {
        MySqlCommand sql;
        Connection con = new Connection();

        //listagem de produto
        public DataTable DepartmentList()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT department_id, departmentt, IF(departmentStatus > 0, 'Ativo', 'Inativo') AS status, created_at FROM department WHERE departmentStatus = '1'", con.con);
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
        //listagem de departamento busca reativa
        public DataTable DepartmentSearchListFromController(Department dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT department_id, departmentt, IF(department.departmentStatus > 0, 'Ativo', 'Inativo') AS status," +
                    " created_at FROM department WHERE departmentt LIKE '%" + dado.Departamentt + "%'  AND departmentStatus = '" + dado.DepartmentStatus + "' ", con.con);
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
        //Listagen de empresas
        public DataTable HeadOfficeListController()
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
        //inserir dados na pivot
        public DataTable InsertDepartmentInToDatabaseController(Department dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE department SET departmentt='"+ dado.Departamentt +"' , departmentStatus='"+dado.DepartmentStatus+ "' where department_id = '" + dado.Departament_id + "' ", con.con);
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

        //pesquisar
        public DataTable InsertDepartmentSearchInToDatabaseController(Department dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT department_id, departmentt, IF(departmentStatus > 0, 'Ativo', 'Inativo') AS status, created_at FROM department WHERE departmentStatus = '0'", con.con);
                    
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
        public int Save(Department dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO department (departmentt, departmentStatus, created_at, updated_at) values (@departamentt, @departmentStatus, @created_at, @updated_at)", con.con);
                sql.Parameters.AddWithValue("@departamentt", dado.Departamentt);
                sql.Parameters.AddWithValue("@departmentStatus", dado.DepartmentStatus);
                sql.Parameters.AddWithValue("@created_at", dado.Created_at);
                sql.Parameters.AddWithValue("@updated_at", dado.Updated_at);

                sql.ExecuteNonQuery();
                // Verifica se existe um ultimo id inserido e adiciona um
                // parametro para tratá-lo
                if (sql.LastInsertedId != 0)
                    sql.Parameters.Add(new MySqlParameter("department_id", sql.LastInsertedId));
                // Retorna o id do novo rgistro e convert de Int64 para Int32 (int).
                return Convert.ToInt32(sql.Parameters["@department_id"].Value);
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



        //puxando dados do formulario e inserindo no banco
        public void DepartmentSaveInPivotTable(int headOffice_id, int branchHeadOffice_id, int department_id)
        {


            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO link_user_company_pivot (headOffice_id, branchHeadOffice_id, department_id) values (@headOffice_id, @branchHeadOffice_id, @department_id)", con.con);


                sql.Parameters.AddWithValue("@headOffice_id", headOffice_id == 0 ? (object)DBNull.Value : headOffice_id);
                sql.Parameters.AddWithValue("@branchHeadOffice_id", branchHeadOffice_id == 0 ? (object)DBNull.Value : branchHeadOffice_id);
                sql.Parameters.AddWithValue("@department_id", department_id == 0 ? (object)DBNull.Value : department_id);


                sql.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.CloseConnection();
            }
        }



        //Buscar umtima 
        public DataTable GetLastDepartmentId()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT MAX(department.department_id) FROM department;", con.con);
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
