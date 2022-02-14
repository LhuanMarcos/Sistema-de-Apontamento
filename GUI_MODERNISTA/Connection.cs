using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace GUI_MODERNISTA
{
    public class Connection
    {
        readonly string connection = "SERVER=mysql.localhost; DATABASE=lhuandb; UID=root; PWD=root;";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar" + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                con = new MySqlConnection(connection);
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao fechar conexão" + ex.Message);
            }
        }
    }
}
