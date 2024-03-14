using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Testing Address Class -------");
            // create a new address using no-arg constructor
            Console.WriteLine("** using no-arg constructor **");
            Address address1 = new Address();
            Console.WriteLine(address1);
            // test Property Accessor Methods
            address1.StreetNum = "155";
            address1.StreetName = "Street A";
            address1.Suburb = "Adeladie";
            address1.Postcode = "5000";
            address1.State = "SA";
            Console.WriteLine("address1 street number: " + address1.StreetNum);
            Console.WriteLine("address1 street name: " + address1.StreetName);
            Console.WriteLine("address1 suburb: " + address1.Suburb);
            Console.WriteLine("address1 state: " + address1.State);
            // create a new address using all-args constructor
            Console.WriteLine("\n** using all-args constructor **");
            Address address2 = new Address("45", "Street B", "Port Lincoln", "5606", "SA");
            Console.WriteLine(address2);
            Console.WriteLine("------- End Testing Address Class -------");

            Console.WriteLine("\n------- Testing Person Class -------");
            // create a new person using no-arg constructor
            Console.WriteLine("** using no-arg constructor **");
            Person person1 = new Person();
            Console.WriteLine(person1);
            // test Property Accessor Methods
            person1.Name = "Jane Austen";
            person1.Email = "janeA@email.com";
            person1.PhoneNumber = "0412345678";
            Console.WriteLine("person1 name: " + person1.Name);
            Console.WriteLine("person1 email: " + person1.Email);
            Console.WriteLine("person1 phone number: " + person1.PhoneNumber);
            // create a new person using OLD all-args constructor
            Console.WriteLine("\n** using Person(string name, string email, string phoneNumber) constructor **");
            Person person2 = new Person("Charlotte Bronte", "charB@email.com", "0422334455");
            Console.WriteLine(person2);
            Console.WriteLine();
            // create a new person using NEW all-args contructor
            Console.WriteLine("\n** using Person(string name, string email, string phoneNumber, Address address) constructor **");
            Address addressTest = new Address("streetNumTest", "streetNameTest", "suburbTest", "postcodeTest", "stateTest");
            Person personTest = new Person("nameTest", "emailTest", "phoneNumberTest", addressTest);
            Console.WriteLine(personTest);
            Console.WriteLine("------- End Testing Person Class -------");


            Console.WriteLine("\n------- Testing Subject Class -------");
            // create a new subject using no-arg constructor
            Console.WriteLine("** using no-arg constructor **");
            Subject subject1 = new Subject();
            Console.WriteLine(subject1);
            // test Property Accessor Methods
            subject1.SubjectCode = "ASDJA";
            subject1.SubjectName = "Java";
            subject1.Cost = 500.25;
            Console.WriteLine("subject1 subject code: " + subject1.SubjectCode);
            Console.WriteLine("subjcet1 subject name: " + subject1.SubjectName);
            Console.WriteLine("subject1 cost: " + subject1.Cost);
            // create a new subject using all-args constructor
            Console.WriteLine("\n** using all-args constructor **");
            Subject subject2 = new Subject("ASDN", "TCP-IP", 450.50);
            Console.WriteLine(subject2);
            Console.WriteLine("------- End Testing Subject Class -------");

            Console.WriteLine("\n------- Testing Enrollment Class -------");
            // create a new enrollment using no-arg constructor
            Console.WriteLine("** using no-arg constructor **");
            Enrollment enrollment1 = new Enrollment();
            Console.WriteLine(enrollment1);
            // test Property Accessor Methods
            enrollment1.DateEnrolled = "01/03/2023";
            enrollment1.Grade = "PA";
            enrollment1.Semester = "Semester 1";
            Console.WriteLine("enrollment1 date enrolled: " + enrollment1.DateEnrolled);
            Console.WriteLine("enrollment1 grade: " + enrollment1.Grade);
            Console.WriteLine("enrollment1 semester: " + enrollment1.Semester);
            // create a new enrollment using OLD all-args constructor
            Console.WriteLine("\n** using Enrollment(string dateEnrolled, string grade, string semester) constructor **");
            Enrollment enrollment2 = new Enrollment("01/06/2023", "PA", "Semester 2");
            Console.WriteLine(enrollment2);
            Console.WriteLine();
            // create a new enrollment using NEW all-args contructor
            Console.WriteLine("\n** using Enrollment(string dateEnrolled, string grade, string semester, Subject subject) constructor **");
            Subject sujectTest = new Subject("subjectCodeTest", "subjectNameTest", 100000.00);
            Enrollment enrollmentTest = new Enrollment("dateEnrolledTest", "gradeTest", "semesterTest", sujectTest);
            Console.WriteLine(enrollmentTest);
            Console.WriteLine("------- End Testing Enrollment Class -------");

            Console.WriteLine("\n------- Testing Student Class -------");
            // create a new student using no-arg constructor
            Console.WriteLine("** using no-arg constructor **");
            Student student1 = new Student();
            Console.WriteLine(student1);
            // test Property Accessor Methods
            student1.StudentID = "A00112345";
            student1.Program = "Diploma of Programming";
            student1.DateRegistered = "25/02/2022";
            Console.WriteLine("student1 student id: " + student1.StudentID);
            Console.WriteLine("student1 student program: " + student1.Program);
            Console.WriteLine("student1 date registered: " + student1.DateRegistered);
            // create a new student using OLD all-args constructor
            Console.WriteLine("\n** using Student(string studentID, string program, string dateRegistererd, Enrollment enrollment) constructor **");
            Student student2 = new Student("A00115678", "Diploma of Cyber Security", "06/03/2023", enrollment2);
            Console.WriteLine(student2);
            Console.WriteLine();
            // create a new student using NEW all-args contructor
            Console.WriteLine("\n** using Student (string studentID, string program, string dateRegistererd, Enrollment enrollment, " +
                "string name, string email, string phoneNumber, Address address) constructor **");
            Student studentTest = new Student("studentIDTest", "studentProgramTest", "studentDateRegisteredTest", enrollmentTest, 
                "studentNameTest", "studentEmailTest", "studentPhoneNumberTest", addressTest);
            Console.WriteLine(studentTest);
            // create a new student with the specific Enrollment details and Subject name
            Console.WriteLine("\n** using Student(string studentID, string program, string dateRegistererd, " +
                "string dateEnrolled, string grade, string semester, Subject subject) constructor **");
            Student student3 = new Student("000727789", "Diploma Software Development", "01/06/2021", "01/02/2024", "PA", "Semester 1", subject1);
            Console.WriteLine(student3);
            Console.WriteLine("------- End Testing Student Class -------");





            Console.WriteLine("\n** Testing of overloading '==', '!=' operators and overriding Equal method of Student Class **");
            Student studentA = new Student("A10021", "Advance C#", "01/01/2021", enrollmentTest);
            Student studentB = new Student("A10021", "Advance C#", "01/01/2021", enrollmentTest);
            Student studentC = new Student("A10300", "Advance C#", "10/10/2021", enrollmentTest);
            Console.WriteLine(studentA + "\n");
            Console.WriteLine(studentB + "\n");
            Console.WriteLine(studentC + "\n");

            Console.WriteLine("Testing the '==' operator");
            Console.WriteLine("studentA == studentB is " + (studentA == studentB));
            Console.WriteLine("studentA == studentC is " + (studentA == studentC));

            Console.WriteLine("\nTesting the '!=' operator");
            Console.WriteLine("studentA != studentB is " + (studentA != studentB));
            Console.WriteLine("studentA != studentC is " + (studentA != studentC));

            Console.WriteLine("\nTesting the Equals method");
            Console.WriteLine("studentA.Equals(studentB) is " + (studentA.Equals(studentB)));
            Console.WriteLine("studentA.Equals(studentC) is " + (studentA.Equals(studentC)));
            Console.WriteLine("studentA.Equals(null) is " + (studentA.Equals(null)));

            Console.WriteLine("\nHashCode for studentA studentID is " + studentA.GetHashCode());


            Console.ReadKey();

        }
            
    }
}
