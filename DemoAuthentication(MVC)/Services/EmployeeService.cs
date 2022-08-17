using DemoAuthentication_MVC_.Models;

namespace DemoAuthentication_MVC_.Services
{
    public class EmployeeService
    {
        private readonly Employee _employee;

        public EmployeeService(Employee employee)
        {
            _employee = employee;
        }
        public List<EmployeeViewModel> Get()
        {
            return _employee;
        }
        public List<EmployeeViewModel> Create(EmployeeViewModel emp)
        {
            _employee.Add(emp);
            return _employee;
        }
    }
}
