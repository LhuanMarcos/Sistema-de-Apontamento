using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PONTO.Entities
{
    public class InsertJustification
    {

        private int user_id;
        private string user_re;
        private int UserCreation_id;
        private int UserModification_id;
        private string userName;
        private string justification;
        private int justification_id;
        private string category;
        private int category_id;
        private string creat_date;
        private DateTime hours;
        private string startDate;
        private string endDate;
        private int userStatus;
        private int headOffice_id;
        private int branchHeadOffice_id;
        private string observation;
        private DateTime dateTimeJus;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime CompDateIni;
        private DateTime compensatoryDay;

        // Afastamento
        private DateTime beginDate;
        private DateTime endDate2;

        private DateTime compensatedDay;
        private DateTime justDateCorrence;

        public int User_id { get => user_id; set => user_id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Justification { get => justification; set => justification = value; }
        public string Category { get => category; set => category = value; }
        public string Creat_date { get => creat_date; set => creat_date = value; }
        public DateTime Hours { get => hours; set => hours = value; }
        public int UserStatus { get => userStatus; set => userStatus = value; }
        public string User_re { get => user_re; set => user_re = value; }
        public int HeadOffice_id { get => headOffice_id; set => headOffice_id = value; }
        public int BranchHeadOffice_id { get => branchHeadOffice_id; set => branchHeadOffice_id = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public int Justification_id { get => justification_id; set => justification_id = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public string Observation { get => observation; set => observation = value; }
        public DateTime BeginDate { get => beginDate; set => beginDate = value; }
        public DateTime EndDate2 { get => endDate2; set => endDate2 = value; }
        public DateTime DateTimeJus { get => dateTimeJus; set => dateTimeJus = value; }
        public DateTime CompensatedDay { get => compensatedDay; set => compensatedDay = value; }
        public int UserCreation_id1 { get => UserCreation_id; set => UserCreation_id = value; }
        public int UserModification_id1 { get => UserModification_id; set => UserModification_id = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime JustDateCorrence { get => justDateCorrence; set => justDateCorrence = value; }
        public DateTime CompDateIni1 { get => CompDateIni; set => CompDateIni = value; }
        public DateTime CompensatoryDay { get => compensatoryDay; set => compensatoryDay = value; }
    }
}
