using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Subject
    {
        // constants
        const string DEF_SUBJECT_CODE = "Not provided";
        const string DEF_SUBJECT_NAME = "N/A";
        const double DEF_COST = 0.0;

        // variables 
        private string subjectCode;
        private string subjectName;
        private double cost;

        // Property Assessor methods
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        // no-args constructor
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
            
        }

        // all-args constructor
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        /// <summary>
        /// Overriding the ToString method
        /// </summary>
        /// <returns>The subjectCode, subjectName, and cost</returns>
        public override string ToString()
        {
            return "subject code: " + SubjectCode + ", subject name: " + SubjectName + ", cost: $" + Cost;
        }
    }
}
