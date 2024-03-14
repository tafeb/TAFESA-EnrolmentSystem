using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Person
    {
        // constants
        public const string DEF_NAME = "No name provided";
        public const string DEF_EMAIL = "No email provided";
        public const string DEF_PHONENUMBER = "No phone number provided";

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

        // OLD all-args constructor
        public Person(string name, string email, string phoneNumber) : this(name, email, phoneNumber, new Address())
        {
            //Name = name;
            //Email = email;
            //PhoneNumber = phoneNumber;
        }

        // NEW all-args constructor
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            StudentAddress = address;
        }

        /// <summary>
        /// Override the ToString method
        /// </summary>
        /// <returns>The name, email, phone number, and Address</returns>
        public override string ToString()
        {
            return "name: " + Name + ", email: " + Email + ", phone Number: " + PhoneNumber
                + ",\nAddress-> " + StudentAddress;
        }

        /// <summary>
        /// Overriding the virtual Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Boolean value when comparing Person instances.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;

            Person p = (Person)obj;
            return this.Name == p.Name && this.Email == p.Email;
        }

        /// <summary>
        /// Overriding the GetHashCode method
        /// </summary>
        /// <returns>The hashed name and email.</returns>
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Email.GetHashCode();
        }

        /// <summary>
        /// Overloading the "==" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Boolean value when comparing two Person instances.</returns>
        public static bool operator ==(Person x, Person y)
        {
            return object.Equals(x, y);
        }

        /// <summary>
        /// Overloading the "!=" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Boolean value when comparing two Person instances.</returns>
        public static bool operator !=(Person x, Person y)
        {
            return !object.Equals(x, y);
        }
    }
}
