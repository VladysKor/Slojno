using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slojno
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBook EmpBook = new EmployeeBook();

            EmpBook.GetAllEmployees();
            EmpBook.CalculateMonthlySalary();
            EmpBook.FindEmployeeWithLowestSalary();
            EmpBook.FindEmployeeWithHighestSalary();
            EmpBook.CalculateAverageSalary();
            EmpBook.GetAllEmployeeNames();
            EmpBook.SalaryIndexing();
            EmpBook.DepartmentEmployeeWithLowestSalary();
            EmpBook.DepartmentEmployeeWithHighestSalary();
            EmpBook.DepartmentCalculateAverageSalary();
            EmpBook.DepartmentSalaryIndexing();
            EmpBook.GetAllDepartmentEmployeeNames();
            EmpBook.SalaryLess();
            EmpBook.SalaryMoreOrEqually();
            EmpBook.Add();
            EmpBook.Remove();
            EmpBook.Edit();
            EmpBook.EmployeesDepartments();
        }
    }
}
