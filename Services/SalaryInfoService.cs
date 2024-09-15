using EmployeeManagement.DTO;
using EmployeeManagement.Interface;

namespace EmployeeManagement.Services
{
    public class SalaryInfoService : ISalaryInfo
    {
private List<SalaryInfoDTO> salary = new List<SalaryInfoDTO>(); 
        public SalaryInfoDTO salaryInfo()
        {
            Console.WriteLine("\nEnter Your Salary Information");
            SalaryInfoDTO salaryInfo = new SalaryInfoDTO();

            Console.WriteLine("Monthly Income Earned");
            salaryInfo.MonthlyIncome = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Currency");
            salaryInfo.Currency = Console.ReadLine();

            Console.WriteLine("Amount Of Tax Paid");
            salaryInfo.Taxes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("First Salary payment Date");
            salaryInfo.FirstPamentDate = Console.ReadLine();

            salary.Add(salaryInfo);
            
            return salaryInfo;
        }

         public void SaveSalaryInfo()
        {
            using (StreamWriter writer = new StreamWriter(@"Storage\EmployeeInfo.txt"))
            {
                foreach (SalaryInfoDTO salaryInfo in salary)
                {
                    writer.WriteLine($"Income Per Month: {salaryInfo.MonthlyIncome}");
                    writer.WriteLine($"Currency: {salaryInfo.Currency}");
                    writer.WriteLine($"Tax Paid: {salaryInfo.Taxes}");
                    writer.WriteLine($"First Payment Recieved Date: {salaryInfo.FirstPamentDate}");
                    writer.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}