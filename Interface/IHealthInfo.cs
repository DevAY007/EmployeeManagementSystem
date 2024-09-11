using EmployeeManagement.DTO;

namespace EmployeeManagement.Interface
{
    public interface IHealthInfo
    {
        public HealthInfoDTO healthInfo();
        public void SaveAllEmployeesToFile();
    }
}