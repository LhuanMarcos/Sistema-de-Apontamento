using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Entities
{
    public class Role
    {
        private int role_id;
        private string roleName;
        private int roleStatus;
        private DateTime created_at;
        private DateTime updated_at;


        public string RoleName { get => roleName; set => roleName = value; }
        public int RoleStatus { get => roleStatus; set => roleStatus = value; }
        public int Role_id { get => role_id; set => role_id = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
