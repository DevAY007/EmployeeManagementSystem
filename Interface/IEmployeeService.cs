namespace EmployeeManagement
{
    public interface IEmployeeService
    {
        public CreateEmployeeDTO CreateEmployeeInfo();
        public void SaveAllEmployeesToFile();
        public void DisplayAllEmployees();
    }
}