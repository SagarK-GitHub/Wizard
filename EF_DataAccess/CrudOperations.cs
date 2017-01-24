using EF_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_DataAccess
{
    public class CrudOperations
    {
        SagarEntities objDB = new SagarEntities();
        public void create(EmployeeDetails employee)
        {
            employee objemp =new employee();
            objemp.empId = employee.empId;
            objemp.empName = employee.empName;
            objemp.experience = employee.experience;
            objemp.salary = employee.salary;
            objemp.skillSet = employee.skillSet;
            objemp.designation = employee.designation;
            objDB.employees.Add(objemp);
        }
    }
}
