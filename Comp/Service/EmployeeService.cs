using Comp.Model;

namespace Comp.Service
{
    public class EmployeeService : IEmployee
    {
      
        private static List<Employee> employees = new List<Employee>
        {
            new Employee()
            {
                id= 1,
                Name="Nour",
                Age=23,
                CompanyId= 1
            },
            new Employee()
            {
                id = 2,
                Name="Omar",
                Age =24,
                CompanyId= 2
            },
            new Employee()
            {
                id=3,
                Name="Rami",
                Age=26,
                CompanyId=3
            },

        };
        public async Task<List<Employee>> AddEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
            return employees;
        }

        public async Task<List<Employee>> DeleteEmployee(int id)
        {
            Employee emp1 = employees.First(x => x.id == id);
            employees.Remove(emp1);
            return employees;
        }

        public async Task<Employee> GetById(int id)
        {

            return employees.First(x => x.id == id);
        }

        public async Task<List<Employee>> GetEmployee()
        {
            return employees;
        }

        public async Task<List<Employee>> UpdateEmployee(Employee updateEmployee)
        {
            Employee emp1 = employees.First(x => x.id == updateEmployee.id);
            emp1.Name=updateEmployee.Name;
            emp1.Age=updateEmployee.Age;
            emp1.CompanyId=updateEmployee.CompanyId;
            return employees;
        }
    }
}
