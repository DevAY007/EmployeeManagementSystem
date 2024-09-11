namespace EmployeeManagement
{
    public interface IEmployeeService
    {
        public CreateEmployeeDTO CreateEmployeeInfo();
        void SaveAllEmployeesToFile();
        void DisplayAllEmployees();
    }
}