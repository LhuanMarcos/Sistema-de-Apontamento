using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PONTO.Entities
{
    public class JustificationCategory
    {
        private int category_id;
        private string category;
        private int user_create;
        private int user_update;
        private int statu;
        private DateTime created_at;
        private DateTime updated_at;

        public int Category_id { get => category_id; set => category_id = value; }
        public string Category { get => category; set => category = value; }
        public int User_create { get => user_create; set => user_create = value; }
        public int Statu { get => statu; set => statu = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int User_update { get => user_update; set => user_update = value; }
    }
}
