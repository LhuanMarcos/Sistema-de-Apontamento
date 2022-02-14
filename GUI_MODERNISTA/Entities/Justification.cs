using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Entities
{
    public class Justification
    {
        private int justification_id;
        private string justification;
        private int statu;
        private DateTime created_at;
        private DateTime updated_at;
    

        public int Jugistification_id { get => justification_id; set => justification_id = value; }
        public string JustificationP { get => justification; set => justification = value; }
        public int Statu { get => statu; set => statu = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
