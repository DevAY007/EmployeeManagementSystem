using EmployeeManagement.DTO;
using EmployeeManagement.Interface;

namespace EmployeeManagement.Services
{
    public class NextOfKinService : INextOfKinService
    {
private List<NextOfKinDTO> nextKin = new List<NextOfKinDTO>(); 
        public NextOfKinDTO NextOfKin()
        {
            Console.WriteLine("\nNext Of Kin Info");

            NextOfKinDTO nextOfKin = new NextOfKinDTO();
            Console.WriteLine("First Name");
            nextOfKin.FirstName = Console.ReadLine();

            Console.WriteLine("Middle Name");
            nextOfKin.MiddleName = Console.ReadLine();

            Console.WriteLine("Last Name");
            nextOfKin.LastName = Console.ReadLine();

            Console.WriteLine("DOB");
            nextOfKin.DOB = Console.ReadLine();

            Console.WriteLine("Gender");
            nextOfKin.Gender = Console.ReadLine();

            Console.WriteLine("Phone Number");
            nextOfKin.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Gmail");
            nextOfKin.Gmail = Console.ReadLine();

            Console.WriteLine("Home Address");
            nextOfKin.HomeAddress = Console.ReadLine();

            Console.WriteLine("Home Phone Number");
            nextOfKin.HomePhoneNumber = Console.ReadLine();

            Console.WriteLine("Education Status");
            nextOfKin.EducationStatus = Console.ReadLine();

            nextKin.Add(nextOfKin);
            return nextOfKin;
        }
        public void SaveAllEmployeesToFile()
        {
            using (StreamWriter writer = new StreamWriter(@"Storage\EmployeeInfo.txt"))
            {
                foreach (NextOfKinDTO nextOfKin in nextKin)
                {
                    writer.WriteLine($"Name: {nextOfKin.FirstName} {nextOfKin.MiddleName} {nextOfKin.LastName}");
                    writer.WriteLine($"Date of Birth: {nextOfKin.DOB}");
                    writer.WriteLine($"Gender: {nextOfKin.Gender}");
                    writer.WriteLine($"Gmail: {nextOfKin.Gmail}");
                    writer.WriteLine($"Home Phone Number: {nextOfKin.PhoneNumber}");
                    writer.WriteLine($"Address: {nextOfKin.HomeAddress}");
                    writer.WriteLine($"Marital Status: {nextOfKin.HomePhoneNumber}");
                    writer.WriteLine($"Department: {nextOfKin.EducationStatus}");
                    writer.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}