using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_EnrolmentSystem;

namespace StudentTests
{
    [TestFixture]
    public class DoublyLinkedListTests
    {
        public Enrollment enrollment;
        public DoublyLinkedList<Student> studentListsDouble;

        [SetUp]
        public void Setup()
        {
            studentListsDouble = new DoublyLinkedList<Student>
                        {
                            new Student("0023602", "Test - student05", "05/05/2024", enrollment),
                            new Student("0055555", "Test - student06", "06/06/2024", enrollment),
                            new Student("0013116", "Test - student07", "07/07/2024", enrollment),
                            new Student("0033333", "Test - student08", "08/08/2024", enrollment),
                            new Student("0012344", "Test - student09", "09/09/2024", enrollment)
                        };
        }

        [Test]
        public void AddFirst()
        {
            studentListsDouble.AddFirst(new Student("4444444", "Test", "00/00/2024", enrollment));
            // the student id at the Head of list should be "4444444"
            Assert.AreEqual("4444444", studentListsDouble.Head.Value.StudentID);

        }

        [Test]
        public void AddLast()
        {
            studentListsDouble.AddLast(new Student("7777777", "Test", "00/00/2024", enrollment));
            // the student id at the Tail of the list should be "7777777"
            Assert.AreEqual("7777777", studentListsDouble.Tail.Value.StudentID);

        }

        [Test]
        public void FindStudent()
        {
            var findTargetDouble1 = studentListsDouble.Contains(new Student("0013116", "Test - student07", "07/07/2024", enrollment));
            // the findTarget should exist in linkedlist
            Assert.IsTrue(findTargetDouble1);
        }

        [Test]
        public void RemoveFirst()
        {
            studentListsDouble.RemoveFirst();
            // student id should be "0033333", when the first student is remove first
            Assert.AreEqual("0033333", studentListsDouble.Head.Value.StudentID);
        }

        [Test]
        public void RemoveLast()
        {
            studentListsDouble.RemoveLast();
            // student id should be "0055555", when the last student is remove last
            Assert.AreEqual("0055555", studentListsDouble.Tail.Value.StudentID);
        }
    }
}
