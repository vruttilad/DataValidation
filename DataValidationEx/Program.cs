
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidationEx
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass employee = new TestClass
            {
                Name = "Vedanshi",
                Age = 10,
                UserName = "agness@17",
                Email = "xyz@",
                Password = "12345678",
                ConfirmPassword ="12345678",
                PhoneNumber= "(123)-(765)-(9085)",


            };

            TestValidation tester = new TestValidation();
            tester.Test(employee);
        }
    }
}
