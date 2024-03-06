using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Enrollment
    {
        // constants
        const string DEF_DATE_ENROLLED = "Not provided";
        const string DEF_GRADE = "Not provided";
        const string DEF_SEMESTER = "N/A";

        // variables
        private string dateEnrolled;
        private string grade;
        private string semester;

        // Property Assessor methods
        public string DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }

        // no-arg constructor
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        { 
            
        }

        // all-args constructor
        public Enrollment(string dateEnrolled, string grade, string semester)
        { 
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
        }

        /// <summary>
        /// Override the ToString method
        /// </summary>
        /// <returns>The dateEnrolled, grade, and semester</returns>
        public override string ToString()
        {
            return "date enrolled: " + DEF_DATE_ENROLLED + ", grade: " + Grade + ", semester: " + Semester;
        }

    }
}
