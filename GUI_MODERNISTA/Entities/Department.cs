using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GUI_MODERNISTA.Entities
{
    public class Department
    {

        private int department_id;
        private string departmentt;
        private int branchHeadOffice;
        private string maneger;
        private int departmentStatus;
        private string search;
        private string searchStatus;
        private DateTime created_at;
        private DateTime updated_at;


        public int Departament_id { get => department_id; set => department_id = value; }
        public string Departamentt { get => departmentt; set => departmentt = value; }
        public int BranchHeadOffice { get => branchHeadOffice; set => branchHeadOffice = value; }
        public string Maneger { get => maneger; set => maneger = value; }
        public string Search { get => search; set => search = value; }
        public string SearchStatus { get => searchStatus; set => searchStatus = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int DepartmentStatus { get => departmentStatus; set => departmentStatus = value; }
    }
}
