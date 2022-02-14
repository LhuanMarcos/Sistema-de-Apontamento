using GUI_PONTO.Entities;
using Refit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_PONTO;

namespace GUI_PONTO.Controller
{
    public static class AddressController
    {
        public static DataSet Addres(string zipCode)
        {
           
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", zipCode);

                ds.ReadXml(xml);

                return ds;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
