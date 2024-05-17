using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Student : Person, IComparable<Student>, IEquatable<Student>, IComparable
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


        //no-args constructor
        public Student() : this(DEF_STUDENTID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Enrollment())
        {
        
        }

        // OLD all-args constructor
        public Student(string studentID, string program, string dateRegistererd, Enrollment enrollment) 
            : this(studentID, program, dateRegistererd, enrollment, DEF_NAME, DEF_EMAIL, DEF_PHONENUMBER, new Address())
        {
            //StudentID = studentID;
            //Program = program;
            //DateRegistered = dateRegistered;
            //StudentEnrollment = enrollment;
        }

        // constructor thats create the Student with the specific Enrollment details and Subject name
        public Student(string studentID, string program, string dateRegistererd, string dateEnrolled, string grade, string semester, Subject subject) : 
            this(studentID, program, dateRegistererd, new Enrollment(dateEnrolled, grade, semester, subject))
        { 
            
        }

        // New all-args constructor
        public Student (string studentID, string program, string dateRegistererd, Enrollment enrollment, string name, string email, string phoneNumber, Address address) 
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistererd;
            StudentEnrollment = enrollment;
        }

        //// Constructor has only the studentID, for simply testing of list
        //public Student(string studentID)
        //{
        //    StudentID = studentID;
        //}

        /// <summary>
        /// Overriding the ToString method
        /// </summary>
        /// <returns>The Person and Address, studentID, program, registered, Enrollment and Subject of the Student object</returns>
        //public override string ToString()
        //{
        //    return "Person-> " + base.ToString() + "\nstudentID: " + StudentID + ", program: " + Program + ", date registered: " + DateRegistered
        //        + ",\nEnrollment-> " + StudentEnrollment;
        //}

        // A modified ToString() method for simply testing lists
        public override string ToString()
        {
            return StudentID;
        }

        public bool Equals(Student other)
        {
            return this.StudentID == other.StudentID;
        }

        /// <summary>
        /// Overriding the virtual Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Boolean value when comparing Student instances.</returns>
        public override bool Equals(object obj)
        {
            // check null object to avoid NullReferenceException
            if (obj == null)
                return false;
            // check reference equality
            if (ReferenceEquals(this, obj))
                return true;
            // check different object types
            if (obj.GetType() != GetType())
                return false;

            //if (!base.Equals(obj)) 
            //    return false;

            Student ts = (Student) obj;
            return this.StudentID == ts.StudentID; 
        }

        /// <summary>
        /// Override the GetHashCode method
        /// </summary>
        /// <returns>The hashed student id.</returns>
        public override int GetHashCode()
        {
            //return this.StudentID.GetHashCode();
            return base.GetHashCode() ^ this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Overloading the "==" operator
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>Boolean value when comparing two Student instances.</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            // calls the static Equals method
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// Overloading the "!=" operator
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>Boolean value when comparing two Student instances.</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

        /// <summary>
        /// Override the CompareTo method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>An integer that indicate the order of object in sorting order.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is Student))
                throw new ArgumentException("Expected Student instance", "obj");
            return CompareTo((Student)obj);
        }

        /// <summary>
        /// Override the CompareTo method for Student
        /// </summary>
        /// <param name="other"></param>
        /// <returns>An integer that indicate the order of object in sorting order for Student.</returns>
        public int CompareTo(Student other)
        {
            return this.StudentID.CompareTo(other.StudentID);
        }

        /// <summary>
        /// Overloading the "<" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>An integer that indicate Student x is less than Student y.</returns>
        public static bool operator <(Student x, Student y)
        {
            //return x.studentID < y.studentID;
            return x.CompareTo(y) < 0;
        }

        /// <summary>
        /// Overloading the "<=" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>An integer that indicate Student x is less than or equal to Student y.</returns>
        public static bool operator <=(Student x, Student y)
        {
            //return x.studentID <= y.studentID;
            return x.CompareTo(y) <= 0;
        }

        /// <summary>
        /// Overloading the ">" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>An integer that indicate Student x is greater than Student y.</returns>
        public static bool operator >(Student x, Student y)
        {
            //return x.studentID > y.studentID;
            return x.CompareTo(y) > 0;
        }

        /// <summary>
        /// Overloading the ">=" operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>An integer that indicate Student x is greater than or equal to Student y.</returns>
        public static bool operator >=(Student x, Student y)
        {
            //return x.studentID >= y.studentID;
            return x.CompareTo(y) >= 0;
        }
    }
}
