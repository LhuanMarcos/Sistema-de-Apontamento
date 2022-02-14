using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Entities
{
    public class PointC
    {
        private int point_id;
        private int user_id;
        private string userName;
        private string user_re;
        private string employee;
        private DateTime pointOne;
        private DateTime pointTwo;
        private DateTime pointTree;
        private DateTime pointFour;
        private string starSearch;
        private string endSearch;
        private string cbEmployee;
        private string pointStatus;
        private string searchStatus;
        private DateTime created_at;
        private DateTime updated_at;
        private int updateUser_id;
        private string pOne;
        private string pTwo;
        private string pTree;
        private string pFour;
        private string createdDate;
        private int headOffice;
        private int BrantHeadOffice;

        public int PointRecord_id { get => point_id; set => point_id = value; }
        public string Employee { get => employee; set => employee = value; }
        public string CbEmployee { get => cbEmployee; set => cbEmployee = value; }
        public string Status { get => pointStatus; set => pointStatus = value; }
        public string SearchStatus { get => searchStatus; set => searchStatus = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public string User_re { get => user_re; set => user_re = value; }
        public DateTime PointOne { get => pointOne; set => pointOne = value; }
        public DateTime PointTwo { get => pointTwo; set => pointTwo = value; }
        public DateTime PointTree { get => pointTree; set => pointTree = value; }
        public DateTime PointFour { get => pointFour; set => pointFour = value; }
        public string StarSearch { get => starSearch; set => starSearch = value; }
        public string EndSearch { get => endSearch; set => endSearch = value; }
        public string UserName { get => userName; set => userName = value; }
        public string POne { get => pOne; set => pOne = value; }
        public string PFour { get => pFour; set => pFour = value; }
        public string PTwo { get => pTwo; set => pTwo = value; }
        public string PTree { get => pTree; set => pTree = value; }
        public string CreatedDate { get => createdDate; set => createdDate = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int HeadOffice { get => headOffice; set => headOffice = value; }
        public int BrantHeadOffice1 { get => BrantHeadOffice; set => BrantHeadOffice = value; }
        public int UpdateUser_id { get => updateUser_id; set => updateUser_id = value; }
    }
}
