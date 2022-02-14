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
    public class HeadOfficeControloller
    {
        MySqlCommand sql;
        Connection con = new Connection();

        //listar na grid matriz e endereço
        public DataTable HeadOfficeList(int status, String headOffice)
        {         

            try
            {
                con.AbrirConexao();

                string mysql = "SELECT head_office.headOffice_id, " +
                    "headOffice, " +
                    "cnpj , " +
                    "IF(Situationstatus > 0, 'Ativo', 'Inativo') AS status, " +
                    "head_office.created_at, " +
                    "address.headOffice_id, " +
                    "address.zipCode, "+
                    "address.number, " +
                    "address.street, " +
                    "address.complement, " +
                    "address.district, " +
                    "address.location, " +
                    "address.uf " +
                    "FROM head_office " +
                    "LEFT JOIN address " +
                    "ON address.headOffice_id = head_office.headOffice_id " +
                    "WHERE";
                if (status < 10)
                    mysql += " situationStatus =  " + status;
                if (headOffice.Length > 0)
                    mysql += " AND headOffice LIKE '%" + headOffice + "%' AND Situationstatus = " + status;

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
        //Retorna o ID da empresa pelo nome
        public DataTable GetHeadOfficeIdRetourn(string headOffice)
        {
            con.AbrirConexao();
            sql = new MySqlCommand("SELECT headOffice_id FROM head_office WHERE headOffice = '" + headOffice + "'", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = sql;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Busca de Filial
        public DataTable GellistBranchHeadOfficeFromController(int branchHeadOffice_id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT DISTINCT(branchHeadOffice_id )  FROM link_user_company_pivot WHERE headOffice_id = '"+ branchHeadOffice_id + "' AND branchHeadOffice_id IS NOT NULL;')", con.con);
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

        //listar filial
        public DataTable BranchHeadOfficeList(int headOffice_id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT DISTINCT (branch_head_office.branchName), branch_head_office.branchHeadOffice_id FROM link_user_company_pivot " +
                                        "INNER JOIN head_office " +
                                        "ON head_office.headOffice_id = link_user_company_pivot.headOffice_id " +
                                      "INNER JOIN branch_head_office " +
                                        "ON branch_head_office.branchHeadOffice_id = link_user_company_pivot.branchHeadOffice_id " +
                                        "WHERE link_user_company_pivot.headOffice_id = '" + headOffice_id + "'", con.con);
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


        //Inserir empresa no Banco de Dados
        public int InsertHeadOfficeFromController(HeadOffice headOffice)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO head_office (headOffice, situationStatus, cnpj, created_at, updated_at ) values (@Headoffice, @SituationStatus,@Cnpj ,@Created_at, @Updated_at)", con.con);

                sql.Parameters.AddWithValue("@Headoffice", headOffice.Headoffice);
                sql.Parameters.AddWithValue("@SituationStatus", headOffice.SituationStatus);
                sql.Parameters.AddWithValue("@Cnpj", headOffice.Cnpj);
                sql.Parameters.AddWithValue("@Created_at", headOffice.Created_at);
                sql.Parameters.AddWithValue("@Updated_at", headOffice.Updated_at);

                sql.ExecuteNonQuery();
                con.CloseConnection();

                if (sql.LastInsertedId != 0)
                    sql.Parameters.Add(new MySqlParameter("headOffice_id", sql.LastInsertedId));
                return Convert.ToInt32(sql.Parameters["@headOffice_id"].Value);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Inserid Dados na Tabela Pivot
        public DataTable InsertWorkshiftPivotController(int headOffice_id, int branchHeadOffice_id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO link_user_company_pivot (headOffice_id , branchHeadOffice_id) values ('" + headOffice_id + "','" + branchHeadOffice_id + "')", con.con);
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


        public void addresHeadOfficeSaveController(Addres addres)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO address " +
                    "(" +
                    "zipCode, " +
                    "number, " +
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




        //Update de Empresas
        public int UpdateHeadOfficeFromController(HeadOffice headOffice)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE head_office SET  " +
                    "headOffice=@Headoffice, situationStatus=@SituationStatus, cnpj=@Cnpj,updated_at=@Updated_at WHERE headOffice_id=@headOffice_id", con.con);

                sql.Parameters.AddWithValue("@Headoffice", headOffice.Headoffice);
                sql.Parameters.AddWithValue("@SituationStatus", headOffice.SituationStatus);
                sql.Parameters.AddWithValue("@Cnpj", headOffice.Cnpj);
                sql.Parameters.AddWithValue("@Updated_at", headOffice.Updated_at);
                sql.Parameters.AddWithValue("@headOffice_id", headOffice.HeadOffice_id);

                sql.ExecuteNonQuery();
                con.CloseConnection();

                if (sql.LastInsertedId != 0)
                    sql.Parameters.Add(new MySqlParameter("headOffice_id", sql.LastInsertedId));
                return Convert.ToInt32(sql.Parameters["@headOffice_id"].Value);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //editar cep
        public void AddresUpdateHeadOffice(Addres addres)
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
                    "WHERE address.headOffice_id = @headOffice_id "


                    , con.con);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;


                sql.Parameters.AddWithValue("@addres_id", addres.Addres_id);
                sql.Parameters.AddWithValue("@zipCode", addres.Cep);
                sql.Parameters.AddWithValue("@number", addres.Number);
                sql.Parameters.AddWithValue("@headOffice_id", addres.HeadOffice_id);
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
