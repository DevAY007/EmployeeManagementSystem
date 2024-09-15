using EmployeeManagement.DTO;

namespace EmployeeManagement.Interface
{
    public interface IWorkHistory
    {
        public WorkHistoryDTO workHistory();
        public void SaveWorkInfo();
    }
}