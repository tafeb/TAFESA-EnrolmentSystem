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
        // for address class
        private Address addess;

        // Property Assessor methods
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // for addess class
        public Address StudentAddress { get; set; }

        // no-args constructor
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONENUMBER)
        { 
        
        }

        // all-args constructor
        public Person(string name, string email, string phoneNumber) : this(name, email, phoneNumber, new Address())
        { 
            //Name = name;
            //Email = email;
            //PhoneNumber = phoneNumber;
        }

        // new all-args constructor
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            StudentAddress = address;
        }

        /// <summary>
        /// Ovverride the ToString method
        /// </summary>
        /// <returns>The name, email, phone number, and Address</returns>
        public override string ToString()
        {
            return "name: " + Name + ", email: " + Email + ", phone Number: " + PhoneNumber
                + ",\nAddress: " + StudentAddress;
        }


    }
}
