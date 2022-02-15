using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidationEx
{
    class TestValidation
    {
        public void Test<T>(T model)
        {

            var vResultList = new List<ValidationResult>();
            ValidationContext validation = new ValidationContext(model);
            var IsValid = Validator.TryValidateObject(model, validation, vResultList, true);

            if(!IsValid)
            {
                foreach (var result in vResultList)
                {
                    Console.WriteLine($"Error Message = {result.ErrorMessage}");
                    Console.ReadKey();
                
                }
            }
        
        }
    }
}
