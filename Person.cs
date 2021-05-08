using System;
using System.Collections.Generic;
using System.Text;

namespace DapperPractice
{
    class Person
    {
        public int id { get; set; }
       
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       
        public string EmailAddress { get; set; }
        
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get {
                    // "Sam Gawn (test@test.com)"
                    return $"{ FirstName } { LastName } ({ EmailAddress })";
                }
        }
    }
}
