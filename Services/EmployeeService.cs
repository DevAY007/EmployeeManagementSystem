namespace EmployeeManagement
{
    public class EmployeeService : IEmployeeService
    {
        private List<CreateEmployeeDTO> employees = new List<CreateEmployeeDTO>(); 
        public CreateEmployeeDTO CreateEmployeeInfo()
        {
            CreateEmployeeDTO employee = new CreateEmployeeDTO();

            Console.WriteLine("Enter First Name");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Middle Name");
            employee.MiddleName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter your Date Of Birth");
            employee.DOB = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            employee.Gender = Console.ReadLine();

            Console.WriteLine("Input PhoneNumber");
            employee.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Gmail");
            employee.Gmail = Console.ReadLine();

            Console.WriteLine("Enter Home Phone Number");
            employee.HomePhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Home Address");
            employee.Address = Console.ReadLine();

            Console.WriteLine("What Is Your Marital Status");
            employee.MaritalStatus = Console.ReadLine();

            Console.WriteLine("Enter The Department you work in");
            employee.Department = Console.ReadLine();

            employee.EmployeeID = Guid.NewGuid();

            employees.Add(employee);

            return employee;
        }

        public void SaveAllEmployeesToFile()
        {
            try
            {
            using (StreamWriter writer = new StreamWriter(@"Storage\EmployeeInfo.txt"))
            {
                foreach (CreateEmployeeDTO employee in employees)
                {
                    writer.WriteLine($"Employee ID: {employee.EmployeeID}");
                    writer.WriteLine($"Name: {employee.FirstName} {employee.MiddleName} {employee.LastName}");
                    writer.WriteLine($"Date of Birth: {employee.DOB}");
                    writer.WriteLine($"Gender: {employee.Gender}");
                    writer.WriteLine($"Gmail: {employee.Gmail}");
                    writer.WriteLine($"Phone Number : {employee.PhoneNumber}");
                    writer.WriteLine($"Home Phone Number: {employee.HomePhoneNumber}");
                    writer.WriteLine($"Address: {employee.Address}");
                    writer.WriteLine($"Marital Status: {employee.MaritalStatus}");
                    writer.WriteLine($"Department: {employee.Department}");
                    writer.WriteLine("--------------------------------------------");
                }
            }
            Console.WriteLine("\nAll employee data has been saved to the file.");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Could not save Employee Details.\nPlease try again ):");
            }
        }
        
        public void DisplayAllEmployees()
        {
            Console.WriteLine("All Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeID}");
                Console.WriteLine($"Name: {employee.FirstName} {employee.MiddleName} {employee.LastName}");
                Console.WriteLine($"Date of Birth: {employee.DOB}");
                Console.WriteLine($"Gender: {employee.Gender}");
                Console.WriteLine($"Gmail: {employee.Gmail}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Home Phone Number: {employee.HomePhoneNumber}");
                Console.WriteLine($"Address: {employee.Address}");
                Console.WriteLine($"Marital Status: {employee.MaritalStatus}");
                Console.WriteLine($"Department: {employee.Department}");
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
