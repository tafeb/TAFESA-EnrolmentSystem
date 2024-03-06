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
        // for subject class
        private Subject subject;

        // Property Assessor methods
        public string DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        // for subject class
        public Subject StudentSubject { get; set; }

        // no-arg constructor
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        { 
            
        }

        // all-args constructor
        public Enrollment(string dateEnrolled, string grade, string semester) : this(dateEnrolled, grade, semester, new Subject())
        { 
            //DateEnrolled = dateEnrolled;
            //Grade = grade;
            //Semester = semester;
        }

        // new all-args constructor
        public Enrollment(string dateEnrolled, string grade, string semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            StudentSubject = subject;
        }

        /// <summary>
        /// Override the ToString method
        /// </summary>
        /// <returns>The dateEnrolled, grade, semester, and Subject</returns>
        public override string ToString()
        {
            return "date enrolled: " + DateEnrolled + ", grade: " + Grade + ", semester: " + Semester
                    + ",\nSubject: " + StudentSubject;
        }

    }
}
