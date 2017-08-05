using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeDetailsDL : IEmployeeDetail
    {
        public Employee GetEmployeeDetails()
        {
            return new Employee { EmpID = 1, FirstName = "Vijayanath", LastName = "Viswanathan" };
        }
    }
}
