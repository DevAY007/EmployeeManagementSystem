namespace EmployeeManagement
{
    public class CreateEmployeeDTO : EmployeePersonalInfo
    {
        public new string PhoneNumber{get; set;}
        public new string Gmail{get; set;}
        public new string HomePhoneNumber{get; set;}
        public new string Address{get; set;}
        public new string MaritalStatus{get; set;}
        public new string Department{get; set; }
    }
}