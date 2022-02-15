using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidationEx
{
   public class TestClass
    {
        [Required(ErrorMessage = "{0} should not be empty")]
        public string Name { get; set; }

        [Range(15, 30, ErrorMessage = "{0} is not be between {1} and {2}")]
        public int Age { get; set; }

        [MaxLength(25, ErrorMessage = "{0} is too long")]
        [MinLength(8, ErrorMessage = "{0} is too short")]
        [Required(ErrorMessage = "{0} is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} is not valid")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="{0} is not valid")]
        //[DataType(DataType.EmailAddress,ErrorMessage = "{0} is not valid")]
        public string Email { get; set; }

        
        [StringLength(8, MinimumLength =6, ErrorMessage = "{0} should be range between {2} and {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Compare("Password",ErrorMessage ="{0} is not matched")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "{0} is not valid")]
        //[Phone(ErrorMessage ="{0} is not valid")]
        [DataType(DataType.PhoneNumber, ErrorMessage ="{0} is not valid")]

        public string PhoneNumber { get; set; }

     
    }
}
