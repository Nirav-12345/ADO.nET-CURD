using System;

namespace EmployeePayroll;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Payroll");

        Employee repo = new Employee();

        EmployeeModel employee = new EmployeeModel();

        employee.EmployeeName = "Nirav Raj";
        employee.Addess = "Gopal nagar";
        employee.PhoneNumber = "7585853052";
        employee.Department = "GG";
        employee.Gender = 'M';
        employee.BasicPay = 2250;
        employee.Deductions = 44;
        employee.TaxablePay = 4;
        employee.Tax = 5;
        employee.NetPay = 6;
        employee.city = "Asansol";
        employee.Country = "InDia";
        

        repo.AddEmployee(employee);
    }
}
   