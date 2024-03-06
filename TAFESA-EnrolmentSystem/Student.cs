using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Student : Person
    {
        // constants
        const string DEF_STUDENTID = "N/A";
        const string DEF_PROGRAM = "N/A";
        const string DEF_DATE_REGISTERED = "N/A";

        // variables
        private string studentID;
        private string program;
        private string dateRegistered;
        // for enrollment class
        private Enrollment enrollment;

        // Property Assessor methods
        public string StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }
        // for enrollment class
        public Enrollment StudentEnrollment { get; set; }


        // no-args constructor
        public Student() : this(DEF_STUDENTID, DEF_PROGRAM, DEF_DATE_REGISTERED)
        {

        }
        
        // all-args constructor
        public Student(string studentID, string program, string dateRegistered) : this(studentID, program, dateRegistered, new Enrollment())
        {
            //StudentID = studentID;
            //Program = program;
            //DateRegistered = dateRegistered;
        }

        // new all-args constructor
        public Student(string studentID, string program, string dateRegistered, Enrollment enrollment) : base(DEF_NAME, DEF_EMAIL, DEF_PHONENUMBER)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }

        /// <summary>
        /// Overriding the ToString method
        /// </summary>
        /// <returns>The studentID, program, and date registered</returns>
        public override string ToString()
        {
            return "Person-> " + base.ToString() + "\nstudentID: " + StudentID + ", program: " + Program + ", date registered: " + DateRegistered
                + ",\nEnrollment-> " + StudentEnrollment;
        }

        /// <summary>
        /// Overriding the Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True if objects are equal otherwise not equal.</returns>
        public override bool Equals(object obj)
        {
            // check null object to avoid NullReferenceException
            if(obj == null)
                return false;
            // chec reference equality
            if(ReferenceEquals(this, obj))
                return true;
            // check different object types
            if(obj.GetType() != GetType())
                return false;

            Student student = (Student)obj;
            return student.StudentID == this.StudentID; 

        }

        /// <summary>
        /// Override the GetHashCode method
        /// </summary>
        /// <returns>The hashed student id.</returns>
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Overloading the "==" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True if Student x equals Student y.</returns>
        public static bool operator == (Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// Overloading the "!=" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>False if Student x not equal Student y</returns>
        public static bool operator != (Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

    }
}
