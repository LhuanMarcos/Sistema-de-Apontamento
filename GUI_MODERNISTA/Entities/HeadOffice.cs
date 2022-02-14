using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Entities
{
    public class HeadOffice
    {
        private int headOffice_id;
        private string headoffice;
        private int brantOffice_id;
        private int statusBranchHeadOffice;
        private string cnpj;
        private int situationStatus;
        private DateTime created_at;
        private DateTime updated_at;


        public int HeadOffice_id { get => headOffice_id; set => headOffice_id = value; }
        public string Headoffice { get => headoffice; set => headoffice = value; }
        public int StatusBranchHeadOffice { get => statusBranchHeadOffice; set => statusBranchHeadOffice = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int BrantOffice_id { get => brantOffice_id; set => brantOffice_id = value; }
        public int SituationStatus { get => situationStatus; set => situationStatus = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
    }
}
