using EmployeeManagement.DTO;

namespace EmployeeManagement.Interface
{
    public interface INextOfKinService
    {
        public NextOfKinDTO NextOfKin();
        public void SaveNextOfKinInfo();
    }
}