using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA.Views
{
    public partial class frmRelatorioPonto : Form
    {
        public frmRelatorioPonto()
        {
            InitializeComponent();
            CreatePDFReportPoint();
        }

        static void CreatePDFReportPoint()
        {

            var employees = new List<Employee>
            {
                new Employee{Code = "1",Name = "Joe"},
                new Employee{Code = "1.1.1",Name = "Joe"},
                new Employee{Code = "1.1",Name = "Joe"},
                new Employee{Code = "1.1.2",Name = "Joe"},
                new Employee{Code = "1.2.2",Name = "Joe"},
                new Employee{Code = "1.2",Name = "Joe"},
                new Employee{Code = "2",Name = "Joe"},
                new Employee{Code = "3",Name = "Joe"},
                new Employee{Code = "3.1",Name = "Joe"},
                new Employee{Code = "3.3",Name = "Joe"},
                new Employee{Code = "2.1",Name = "Joe"},
                new Employee{Code = "2.1.3",Name = "Joe"},
                new Employee{Code = "2.1.3.1",Name = "Joe"},
                new Employee{Code = "3.2",Name = "Joe"},
                new Employee{Code = "3.2.1",Name = "Joe"},
                new Employee{Code = "3.1.1",Name = "Joe"},
                new Employee{Code = "3.1.4",Name = "Joe"},
                new Employee{Code = "1.1.2.3",Name = "Joe"},
                new Employee{Code = "1.1.2.1",Name = "Joe"},
            };

      
            if (employees.Count > 0)
            {
                MessageBox.Show(employees.Count.ToString());

                //Configuração do documento  PDF

                var pxPorMn = 72 / 25.2f;
                var pdf = new Document(PageSize.A4, 15 * pxPorMn, 15 * pxPorMn , 15 * pxPorMn, 20 * pxPorMn);
                
                var nomeArquivo = $"pessoas.{ DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss")}.pdf";


            }
        }
    }


    public class Employee
    {
  
        public string Code { get; internal set; }
        public string Name { get; internal set; }
    }
}
