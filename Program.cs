using EmployeeManagement;
using EmployeeManagement.DTO;
using EmployeeManagement.Interface;
using EmployeeManagement.Services;


namespace Program
{
    public class Program
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEduBackGroundService _eduBackGroundService;
        private readonly INextOfKinService _nextOfKinService;
        private readonly IHealthInfo _healthInfo;
        private readonly ISalaryInfo _salaryInfo;
        private readonly IWorkHistory _workHistory;

        public Program(IEmployeeService employeeService, IEduBackGroundService eduBackGroundService, INextOfKinService nextOfKinService, IHealthInfo healthInfo, ISalaryInfo salaryInfo, IWorkHistory workHistory)
        {
            _employeeService = employeeService;
            _eduBackGroundService = eduBackGroundService;
            _nextOfKinService = nextOfKinService;
            _healthInfo = healthInfo;
            _salaryInfo = salaryInfo;
            _workHistory = workHistory;
        }

        public static void Main(string[] args)
        {
            
            IEmployeeService employeeService = new EmployeeService(); 
            IEduBackGroundService eduBackGroundService = new EducationalBackgroundService();
            INextOfKinService nextOfKinService = new NextOfKinService();
            IHealthInfo healthInfo = new HealthInfoService();
            ISalaryInfo salaryInfo = new SalaryInfoService();
            IWorkHistory workHistory = new WorkHistoryService();
            
            Program program = new Program(employeeService, eduBackGroundService, nextOfKinService, healthInfo, salaryInfo, workHistory);

           

            Console.WriteLine("Welcome \nPlease create a password to continue\nPassword can contain digits and special characters");
            string passWord = Console.ReadLine();
                while(passWord == "")
                {
                    Console.WriteLine("Invalid PassWord\nEnter a valid PassWord");
                    passWord = Console.ReadLine();
                }
               Console.WriteLine("Confirm Password");
                string confirmPassWord = Console.ReadLine();

                if (passWord == confirmPassWord)
 
                {
                    employeeService = new EmployeeService();

                    Console.WriteLine("How many employees would you like to add?");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numberOfEmployees; i++)
                    {
                        Console.WriteLine($"\nAdding Employee {i + 1}:");
                        employeeService.CreateEmployeeInfo();
                        eduBackGroundService.EduBackGround();
                        nextOfKinService.NextOfKin();
                        healthInfo.healthInfo();
                        salaryInfo.salaryInfo();
                        workHistory.workHistory();
                    }

                    employeeService.SaveAllEmployeesToFile();
                    eduBackGroundService.SaveEducationInfo();
                    nextOfKinService.SaveNextOfKinInfo();
                    healthInfo.healthInfo();
                    salaryInfo.salaryInfo();
                    workHistory.workHistory();

                    employeeService.DisplayAllEmployees();

                    if (numberOfEmployees == 0)
                    {
                        Console.WriteLine("Zero Employee Added");
                    }
                else
                {
                    CreateEmployeeDTO employee = program._employeeService.CreateEmployeeInfo();

                    EducationBackGroundDTO education = program._eduBackGroundService.EduBackGround();

                    NextOfKinDTO nextOfKin = program._nextOfKinService.NextOfKin();
    
                    HealthInfoDTO health = program._healthInfo.healthInfo();

                    SalaryInfoDTO salary = program._salaryInfo.salaryInfo();
    
                    WorkHistoryDTO work = program._workHistory.workHistory();

                    Console.WriteLine("Thank You For Providing this Infomations \nBear in mind your Details are safe with us");
                }
                }
                else
                {
                    Console.WriteLine("Passwords do not match.");
                }
        }
    }
}
