namespace DemoAuthentication_MVC_.Models
{
    public class EmployeeViewModel
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }
    public class Employee : List<EmployeeViewModel>
    {
        public Employee()
        {
            Add(new EmployeeViewModel() { EmpName = "Ajeet", EmpNo = 1, Salary = 12000 });
            Add(new EmployeeViewModel() { EmpName = "Pranay", EmpNo = 2, Salary = 13000 });

        }
    }
}
