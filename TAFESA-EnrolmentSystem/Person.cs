using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Person
    {
        // constants
        const string DEF_NAME = "No name provided";
        const string DEF_EMAIL = "No email provided";
        const string DEF_PHONENUMBER = "No phone number provided";

        // variables 
        private string name;
        private string email;
        private string phoneNumber;

        // Property Assessor methods
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // no-args constructor
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONENUMBER)
        { 
        
        }

        // all-args constructor
        public Person(string name, string email, string phoneNumber)
        { 
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Ovverride the ToString method
        /// </summary>
        /// <returns>The name, email, and phone number</returns>
        public override string ToString()
        {
            return "Name: " + Name + ", Email: " + Email + "PhoneNumber: " + PhoneNumber;
        }


    }
}
