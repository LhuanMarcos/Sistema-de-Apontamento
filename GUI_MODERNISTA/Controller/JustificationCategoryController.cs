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
using GUI_PONTO.Entities;

namespace GUI_PONTO.Controller
{
    public class JustificationCategoryController
    {


        MySqlCommand sql;
        Connection con = new Connection();

        //Listagem de categorias de justificativas PARA Combobox
        public DataTable JustificationCategoryCombobox()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT category_id, category FROM justification_category WHERE status = '1';", con.con);
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

        //Listagem de Justificativas
        public DataTable CategoryListGridController(int status)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT category_id,category, " +
                                               "IF(status > 0, 'Ativo', 'Inativo') AS status, " +
                                                "created_at " +
                                        "FROM justification_category WHERE status ='" + status + "' ", con.con);
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
        public DataTable CategoryListGridByJustificationAndNameController(JustificationCategory cate)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT category_id,category, " +
                                               "IF(status > 0, 'Ativo', 'Inativo') AS status, " +
                                                "created_at " +
                                        "FROM justification_category WHERE category  LIKE '%" + cate.Category + "%' AND status ='" + cate.Statu + "' ", con.con);
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

        //Cdastro de Categoria
        public void InsertCategoryInToDataBase(JustificationCategory cate)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO justification_category (category, status,user_create, created_at, updated_at) " +
                "values (@category, " +
                "@status, " +
                "@user_create, " +
                "@created_at, " +
                "@updated_at) ", con.con);

                sql.Parameters.AddWithValue("@category", cate.Category);
                sql.Parameters.AddWithValue("@status", cate.Statu);
                sql.Parameters.AddWithValue("@user_create", cate.User_create);
                sql.Parameters.AddWithValue("@created_at", cate.Created_at);
                sql.Parameters.AddWithValue("@updated_at", cate.Updated_at);

                sql.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.CloseConnection();
            }
        }
        //Update de justificativa
        public DataTable CategoryUpdateFromController(JustificationCategory cate)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE justification_category SET category=@category, status=@status,user_update=@user_update ,updated_at=@updated_at WHERE category_id = @category_id", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                sql.Parameters.AddWithValue("@category", cate.Category);
                sql.Parameters.AddWithValue("@status", cate.Statu);
                sql.Parameters.AddWithValue("@user_update", cate.User_create);
                sql.Parameters.AddWithValue("@created_at", cate.User_update);
                sql.Parameters.AddWithValue("@updated_at", cate.Updated_at);
                sql.Parameters.AddWithValue("@category_id", cate.Category_id);
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
