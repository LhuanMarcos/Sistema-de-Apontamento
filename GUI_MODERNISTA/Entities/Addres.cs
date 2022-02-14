using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Refit;
using System.Windows.Forms;

namespace GUI_PONTO.Entities
{


    public  class Addres
    {
        private int user_id;
        private int addres_id;
        private int headOffice_id;
        private string cep;
        private string number;
        private DateTime created_at;
        private DateTime updated_at;
        private string street;
        private string district;
        private string location;
        private string uf;
        private string complement;

        public string Cep { get => cep; set => cep = value; }
        public string Number { get => number; set => number = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public string Street { get => street; set => street = value; }
        public string District { get => district; set => district = value; }
        public string Location { get => location; set => location = value; }
        public string Uf { get => uf; set => uf = value; }
        public int Addres_id { get => addres_id; set => addres_id = value; }
        public string Complement { get => complement; set => complement = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int HeadOffice_id { get => headOffice_id; set => headOffice_id = value; }
    }

}
