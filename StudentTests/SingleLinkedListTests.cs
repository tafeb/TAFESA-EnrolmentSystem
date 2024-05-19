using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_EnrolmentSystem;

namespace StudentTest
{
    [TestFixture]
    public  class SingleLinkedListTests
    {
        public Enrollment enrollment;
        public SingleLinkedList<Student> studentLists;

        [SetUp]
        public void Setup()
        {
            studentLists = new SingleLinkedList<Student>
                    {
                        new Student("0012345", "Test - student00", "00/00/2024", enrollment),
                        new Student("0020124", "Test - student01", "01/01/2024", enrollment),
                        new Student("0081021", "Test - student02", "02/02/2024", enrollment),
                        new Student("0063368", "Test - student03", "03/03/2024", enrollment),
                        new Student("0012340", "Test - student04", "04/04/2024", enrollment),
                    };  
        }

        [Test]
        public void AddFirstToHead()
        {
            studentLists.AddFirst(new Student("3333333", "Test", "00/00/2024", enrollment));
            // the student id at the Head of list should be "3333333"
            Assert.AreEqual("3333333", studentLists.Head.Value.StudentID);

        }

        [Test]
        public void AddLastToTail()
        {
            studentLists.AddLast(new Student("1111111", "Test", "00/00/2024", enrollment));
            // the student id at the Tail of the list should be "1111111"
            Assert.AreEqual("1111111", studentLists.Tail.Value.StudentID);

        }

        [Test]
        public void FindStudentInLinkedList()
        {
            var findTarget = studentLists.Contains(new Student("0063368", "Test - student03", "03/03/2024", enrollment));
            // the findTarget should exist in linkedlist
            Assert.IsTrue(findTarget);
        }

        [Test]
        public void RemoveFirstFromBeginning()
        {
            studentLists.RemoveFirst();
            // student id should be "0063368", when the first student is remove first
            Assert.AreEqual("0063368", studentLists.Head.Value.StudentID);
        }

        [Test]
        public void RemoveLastFromEnd()
        {
            studentLists.RemoveLast();
            // student id should be "0020124", when the last student is remove last
            Assert.AreEqual("0020124", studentLists.Tail.Value.StudentID);
        }
    }
}
