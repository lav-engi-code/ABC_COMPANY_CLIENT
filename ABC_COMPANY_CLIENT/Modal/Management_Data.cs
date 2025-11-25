using System.ComponentModel.DataAnnotations;

namespace ABC_COMPANY_CLIENT.Modal
{
    public class Management_Data
    {
        [Required(ErrorMessage = "UserId is Required")]

        public string userId { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        public string password { get; set; }
    }
}
