using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Entities
{
    class Manager
    {
        private int manager_id;
        private string nameManager;
        private string branchHeadOffice;
        private string departamentt;
        private string status;
        private string searchStatus;
        private string searchNameManager;

        public int Manager_id { get => manager_id; set => manager_id = value; }
        public string NameManager { get => nameManager; set => nameManager = value; }
        public string BranchHeadOffice { get => branchHeadOffice; set => branchHeadOffice = value; }
        public string Departamentt { get => departamentt; set => departamentt = value; }
        public string Status { get => status; set => status = value; }
        public string SearchStatus { get => searchStatus; set => searchStatus = value; }
        public string SearchNameManager { get => searchNameManager; set => searchNameManager = value; }
    }
}
