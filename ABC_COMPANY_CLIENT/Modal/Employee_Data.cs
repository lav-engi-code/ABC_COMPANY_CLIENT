using System.ComponentModel.DataAnnotations;

namespace ABC_COMPANY_CLIENT.Modal
{
    public class Employee_Data
    {
        //[Required(ErrorMessage ="ID is Required For Create New Employee")]
        //[StringLength(1000,ErrorMessage ="ID Should be Greater Than 1000")]
        public int employee_Id { get; set; }

        //[Required(ErrorMessage = "Name is Required For Create New Employee")]
        //[StringLength(20, ErrorMessage = "Name Should be Greater Than 20")]
        public string? employee_Name { get; set; }
        public string? employee_Gender { get; set; }
        public int employee_Age { get; set; }
        public string? employee_Address { get; set; }
        public string? employee_Department { get; set; }
        public int employee_Joining_Year { get; set; }
        public int employee_Salary { get; set; }
    }
}
