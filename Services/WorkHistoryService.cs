using EmployeeManagement.DTO;
using EmployeeManagement.Interface;

namespace EmployeeManagement.Services
{
    public class WorkHistoryService : IWorkHistory
    {
private List<WorkHistoryDTO> work = new List<WorkHistoryDTO>(); 
        public WorkHistoryDTO workHistory()
        {
            Console.WriteLine("\nInput Info about your Work History");

            WorkHistoryDTO workHistory = new WorkHistoryDTO();

            Console.WriteLine("Enter Previous Company Name");
            workHistory.CompanyName = Console.ReadLine();

            Console.WriteLine("Company Address");
            workHistory.CompanyAddress = Console.ReadLine();

            Console.WriteLine("Company Gmail");
            workHistory.CompanyGmail = Console.ReadLine();

            Console.WriteLine("Position Held");
            workHistory.PositionHeld = Console.ReadLine();

            Console.WriteLine("Resume Date");
            workHistory.ResumeDate = Console.ReadLine();

            Console.WriteLine("Re-Sign Date");
            workHistory.EndDate = Console.ReadLine();

            Console.WriteLine("Why Did you leave the Company");
            workHistory.ReasonForQuiting = Console.ReadLine();

            Console.WriteLine("What is your Experience in the last company");
            workHistory.Experience = Console.ReadLine();
            
            work.Add(workHistory);
            return workHistory;
        }

         public void SaveAllEmployeesToFile()
        {
            using (StreamWriter writer = new StreamWriter(@"Storage\EmployeeInfo.txt"))
            {
                foreach (WorkHistoryDTO workHistory in work)
                {
                    writer.WriteLine($"Previous Company : {workHistory.CompanyName}");
                    writer.WriteLine($"Previous Company Address: {workHistory.CompanyAddress}");
                    writer.WriteLine($"Previous Company Mail: {workHistory.CompanyGmail}");
                    writer.WriteLine($"Position In Previous Company: {workHistory.PositionHeld}");
                    writer.WriteLine($"Started working in previous company on: {workHistory.ResumeDate}");
                    writer.WriteLine($"Stoped working in previous company on: {workHistory.EndDate}");
                    writer.WriteLine($"Reason For quiting in the previous company: {workHistory.ReasonForQuiting}");
                    writer.WriteLine($"Experience: {workHistory.Experience}");
                    writer.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}