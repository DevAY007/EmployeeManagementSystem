using EmployeeManagement.DTO;

namespace EmployeeManagement.Services
{
    public class EducationalBackgroundService : IEduBackGroundService
    {
private List<EducationBackGroundDTO> eduInfo = new List<EducationBackGroundDTO>(); 
        public EducationBackGroundDTO EduBackGround()
        {
            EducationBackGroundDTO education = new EducationBackGroundDTO();
            Console.WriteLine("Enter School Details");

            Console.WriteLine("Primary School Name");
            education.PrimarySchoolAttended = Console.ReadLine();

            Console.WriteLine("Primary School Gmail");
            education.PrimarySchoolGmail = Console.ReadLine();

            Console.WriteLine("Secondary School Name");
            education.SecondarySchoolAttended = Console.ReadLine();

            Console.WriteLine("Secondary School Gmail");
            education.SecondarySchoolGmail = Console.ReadLine();

            Console.WriteLine("Institution Name");
            education.InstitutionAttended = Console.ReadLine();

            Console.WriteLine("Institution Gmail");
            education.InstitutionGmail = Console.ReadLine();

            Console.WriteLine("Highest Qualification");
            education.Qualifications = Console.ReadLine();

            Console.WriteLine("Date Graduated");
            education.DateGraduated = Console.ReadLine();

            eduInfo.Add(education);

            return education;
        }

            public void SaveEducationInfo()
        {
            using (StreamWriter writer = new StreamWriter(@"Storage\EmployeeInfo.txt"))
            {
                foreach (EducationBackGroundDTO education in eduInfo)
                {
                    writer.WriteLine($"Primary School: {education.PrimarySchoolAttended}");
                    writer.WriteLine($"Primary School Mail: {education.PrimarySchoolGmail}");
                    writer.WriteLine($"Secondary School: {education.SecondarySchoolAttended}");
                    writer.WriteLine($"Secondary School Mail: {education.SecondarySchoolGmail}");
                    writer.WriteLine($"University: {education.InstitutionAttended}");
                    writer.WriteLine($"University Gmail: {education.InstitutionGmail}");
                    writer.WriteLine($"Highest Certificate: {education.Qualifications}");
                    writer.WriteLine($"Graduated from Higher Institution On: {education.DateGraduated}");
                    writer.WriteLine("--------------------------------------------");
                }
            }
        }     
    }
}