using EmployeeManagement.DTO;
using EmployeeManagement.Interface;

namespace EmployeeManagement.Services
{
    public class HealthInfoService : IHealthInfo
    {
private List<HealthInfoDTO> health = new List<HealthInfoDTO>(); 

        public HealthInfoDTO healthInfo()
        {
            Console.WriteLine("\nInput Your Health");

            HealthInfoDTO healthInfo = new HealthInfoDTO();

            Console.WriteLine("Blood Group");
            healthInfo.BloodGroup = Console.ReadLine();

            Console.WriteLine("Blood Type");
            healthInfo.BloodType = Console.ReadLine();

            Console.WriteLine("Allergies");
            healthInfo.Allergies = Console.ReadLine();

            Console.WriteLine("Health Status");
            healthInfo.HealthStatus = Console.ReadLine();

            Console.WriteLine("Precautions");
            healthInfo.Precautions = Console.ReadLine();

            Console.WriteLine("Comment");
            healthInfo.Comment = Console.ReadLine();

            health.Add(healthInfo);
            return healthInfo;
        }

         public void SaveHealthInfo()
        {
            using (StreamWriter writer = new StreamWriter(@"Storage\EmployeeInfo.txt"))
            {
                foreach (HealthInfoDTO healthInfo in health)
                {
                    writer.WriteLine($"Employee ID: {healthInfo.BloodGroup}");
                    writer.WriteLine($"Name: {healthInfo.BloodType}");
                    writer.WriteLine($"Date of Birth: {healthInfo.Allergies}");
                    writer.WriteLine($"Gender: {healthInfo.HealthStatus}");
                    writer.WriteLine($"Gmail: {healthInfo.Precautions}");
                    writer.WriteLine($"Home Phone Number: {healthInfo.Comment}");
                    writer.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}