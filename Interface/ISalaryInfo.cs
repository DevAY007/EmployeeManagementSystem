using EmployeeManagement.DTO;

namespace EmployeeManagement.Interface
{
    public interface ISalaryInfo
    {
        public SalaryInfoDTO salaryInfo();
        public void SaveSalaryInfo();
    }
}