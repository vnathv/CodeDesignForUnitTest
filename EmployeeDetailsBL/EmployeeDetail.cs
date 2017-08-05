using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace EmployeeDetailsBL
{
    public class EmployeeDetail
    {
        private readonly IEmployeeDetail _employeeDetail;
        public EmployeeDetail(IEmployeeDetail employeeDetail)
        {
            _employeeDetail = employeeDetail;
        }
        public string GetFullName()
        {         
           
            var employeeDetail = _employeeDetail.GetEmployeeDetails();

            return employeeDetail.FirstName + " " + employeeDetail.LastName;

        }
    }
}
