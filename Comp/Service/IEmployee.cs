using Comp.Model;

namespace Comp.Service
{
    public interface IEmployee
    {

        Task<List<Employee>> GetEmployee();
        Task<Employee> GetById(int id);
        Task<List<Employee>> AddEmployee(Employee newEmployee);
        Task<List<Employee>> UpdateEmployee(Employee updateEmployee);
        Task<List<Employee>> DeleteEmployee(int id);

    }
}
