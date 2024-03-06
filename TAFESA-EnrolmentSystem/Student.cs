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
        public Student(string studentID, string program, string dateRegistered, Enrollment enrollment)
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
            return "studentID: " + StudentID + ", program: " + Program + ", date registered: " + DateRegistered
                + ",\nEnrollment " + StudentEnrollment;
        }

    }
}
