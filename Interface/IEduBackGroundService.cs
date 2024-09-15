using EmployeeManagement.DTO;

namespace EmployeeManagement
{
    public interface IEduBackGroundService
    {
        public EducationBackGroundDTO EduBackGround();
        public void SaveEducationInfo();
    }
}