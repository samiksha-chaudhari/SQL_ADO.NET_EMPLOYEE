using System;

namespace SQL_ADO.NET_EMPLOYEE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wELCOME TO ADO .NET");
            EmployeeR repo = new EmployeeR();
            Emp_model employee = new Emp_model();
            employee.EmployeeName = "Samiksha";
            employee.Department = "Database";
            employee.PhoneNumber = "7412589632";
            employee.Address = "Jalgaon";
            employee.Gender = 'F';
            employee.BasicPay = 1025791;
            employee.Deductions = 20000.00;
            employee.StartDate = Convert.ToDateTime("2021-10-12");



            //repo.AddEmployee(employee);
            repo.GetAllEmployee();
        }
    }
}
