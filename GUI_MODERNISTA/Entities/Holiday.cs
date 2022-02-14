using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Entities
{
    class Holiday
    {
        private int holiday_id;
        private string holidayName;
        private int headOffice_id;
        private int branchHeadOffice;
        private string description;
        private int holidayType;
        private DateTime holidayDate;
        private int statusFixed;
        private DateTime created_at;
        private DateTime updated_at;

        public int HeadOffice_id { get => headOffice_id; set => headOffice_id = value; }
        public int BranchHeadOffice { get => branchHeadOffice; set => branchHeadOffice = value; }
        public string Description { get => description; set => description = value; }
        public int Type { get => holidayType; set => holidayType = value; }
        public DateTime Date { get => holidayDate; set => holidayDate = value; }
        public int Holiday_id { get => holiday_id; set => holiday_id = value; }
        public int StatusFixed { get => statusFixed; set => statusFixed = value; }
        public string HolidayName { get => holidayName; set => holidayName = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }

    }
}
