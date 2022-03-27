using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class EmployeeModel
    {
        public int EmplyeeId { get; set; }

        


        public string EmployeeName { get; set; }


        public string Addess { get; set; }


        public string PhoneNumber { get; set; }


        public string Department { get; set; }


        public char Gender { get; set; }


        public double BasicPay { get; set; }

        public double Deductions { get; set; }

        public double TaxablePay { get; set; }


        public double Tax { get; set; }


        public double NetPay { get; set; }

        public DateTime startDate { get; set; }

        public string city { get; set; }

        public string Country { get; set; }





    }
}
