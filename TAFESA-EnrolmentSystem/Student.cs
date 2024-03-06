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

        // Property Assessor methods
        public string StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }


        // no-args constructor
        public Student() : this(DEF_STUDENTID, DEF_PROGRAM, DEF_DATE_REGISTERED)
        {

        }
        
        // all-args constructor
        public Student(string studentID, string program, string dateRegistered)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }

        /// <summary>
        /// Overriding the ToString method
        /// </summary>
        /// <returns>The studentID, program, and date registered</returns>
        public override string ToString()
        {
            return "studentID: " + StudentID + ", program: " + Program + ", date registered: " + DateRegistered;
        }

    }
}
