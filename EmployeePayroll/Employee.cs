using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
   public class Employee
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=payroll_service4;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public bool AddEmployee(EmployeeModel employee)
        {
            try
            {
                using(this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails2", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                    command.Parameters.AddWithValue("@phonenumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", employee.Addess);
                    command.Parameters.AddWithValue("@department", employee.Department);
                    command.Parameters.AddWithValue("@Gender", employee.Gender);
                    command.Parameters.AddWithValue("@basicpay", employee.BasicPay);
                    command.Parameters.AddWithValue("@deductions", employee.Deductions);
                    command.Parameters.AddWithValue("@Taxablepay", employee.TaxablePay);
                    command.Parameters.AddWithValue("@Tax", employee.Tax);
                    command.Parameters.AddWithValue("@netPay", employee.NetPay);
                    command.Parameters.AddWithValue("@city", employee.city);
                    command.Parameters.AddWithValue("@statdate", DateTime.Now);
                    command.Parameters.AddWithValue("@country", employee.Country);


                    this.connection.Open();

                    var result = command.ExecuteNonQuery();
                    this.connection.Close();

                    if(result!=0)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }



    }
}
