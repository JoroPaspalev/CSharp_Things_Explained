using System;
using System.Collections.Generic;
using System.Linq;

namespace AddSingleton_Transient_Scoped.Models
{
    //////////////////////////////////////////////////////////////////////////////////////////////
    /////         Video tutorial here: https://www.youtube.com/watch?v=v6Nr7Zman_Y           /////
    //////////////////////////////////////////////////////////////////////////////////////////////

    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id =1, Name = "Jorge", Department = "Programming", Email = "aaa@gmail.com"},
                new Employee() { Id =2, Name = "Ivan", Department = "Programming", Email = "bbb@gmail.com"},
                new Employee() { Id =3, Name = "Pesho", Department = "Programming", Email = "vvv@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            //Намери ми в List -тата с Employees най-голямото Id
            employee.Id = _employeeList.Max(e => e.Id) + 1;

            _employeeList.Add(employee);

            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetImployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
