using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Entities
{
    public class User
    {
        private int user_id;
        private DateTime created_at;
        private DateTime updated_at;
        private string userName; //nome
        private string numberWorkCard; //numero da carteira de trabalho
        private string serieWorkCard; //numero de serie da carteira de trabalho
        private string pis; //numero pis da carteira de trabalho
        private string enterpriseName;//nome da empresa
        private string branch;//filial
        private string branchBudget;//filial de orçamento
        private string CenterCost;//centro de custo
        private string re;//re
        private string userLevel;//nivel
        private string departament;//departamento
        private string shift;//turno
        private string office;//cargo
        private string maneger;//gerente
        private DateTime admission;//data de admissao
        private DateTime resignation;//data de demissao
        private int userStatus;//situação\\
        private int registPoint;//registra ponto
        private int usePassword;//utilizar senha
        private int compensatoryTimeOff;//banco de horas
        private int verifyInput;//verificar entrada\\
        private string userPassword;//senha
        private int takeabreak;//intervalo
        private int appointmentEveryDay;//gerar marcação em qualquer dia
        private int headOffice_id;//matriz empresa
        private int department_id;//departamento
        private int workShift_id;//turno
        private int role_id;//cargo
        private string template;
        private DateTime justTime;



        public int User_id { get => user_id; set => user_id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string NumberWorkCard { get => numberWorkCard; set => numberWorkCard = value; }
        public string SerieWorkCard { get => serieWorkCard; set => serieWorkCard = value; }
        public string Pis { get => pis; set => pis = value; }
        public string EnterpriseName { get => enterpriseName; set => enterpriseName = value; }
        public string Branch { get => branch; set => branch = value; }
        public string BranchBudget { get => branchBudget; set => branchBudget = value; }
        public string CenterCost1 { get => CenterCost; set => CenterCost = value; }
        public string Re { get => re; set => re = value; }
        public string Level { get => userLevel; set => userLevel = value; }
        public string Departament { get => departament; set => departament = value; }
        public string Shift { get => shift; set => shift = value; }
        public string Office { get => office; set => office = value; }
        public string Maneger { get => maneger; set => maneger = value; }
        public DateTime Admission { get => admission; set => admission = value; }
        public DateTime Resignation { get => resignation; set => resignation = value; }
        public int UserStatus { get => userStatus; set => userStatus = value; }
        public int RegistPoint { get => registPoint; set => registPoint = value; }
        public int UsePassword { get => usePassword; set => usePassword = value; }
        public int CompensatoryTimeOff { get => compensatoryTimeOff; set => compensatoryTimeOff = value; }
        public int VerifyInput { get => verifyInput; set => verifyInput = value; }
        public string Password { get => userPassword; set => userPassword = value; }
        public int Takeabreak { get => takeabreak; set => takeabreak = value; }
        public int AppointmentEveryDay { get => appointmentEveryDay; set => appointmentEveryDay = value; }
        public DateTime DataCadastro { get => created_at; set => created_at = value; }
        public DateTime UpdateCadastro { get => updated_at; set => updated_at = value; }
        public int HeadOffice_id { get => headOffice_id; set => headOffice_id = value; }
        public int Department_id { get => department_id; set => department_id = value; }
        public int WorkShift_id { get => workShift_id; set => workShift_id = value; }
        public int Role_id { get => role_id; set => role_id = value; }
        public string Template { get => template; set => template = value; }
        public DateTime JustTime { get => justTime; set => justTime = value; }
    }
}
