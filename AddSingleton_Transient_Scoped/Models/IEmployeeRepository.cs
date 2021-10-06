using System.Collections.Generic;


//////////////////////////////////////////////////////////////////////////////////////////////
/////         Video tutorial here: https://www.youtube.com/watch?v=v6Nr7Zman_Y           /////
//////////////////////////////////////////////////////////////////////////////////////////////


namespace AddSingleton_Transient_Scoped.Models
{
    public interface IEmployeeRepository
    {
        Employee GetImployee(int Id);

        IEnumerable<Employee> GetAllEmployees();

        Employee Add(Employee employee);
    }
}
