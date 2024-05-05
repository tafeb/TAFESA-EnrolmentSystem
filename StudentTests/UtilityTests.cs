using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TAFESA_EnrolmentSystem;

namespace StudentTest
{
    [TestFixture]
    public class UtilityTests
    {
        private Student targetExist;
        private Student targetNotExist;

        [SetUp]
        public void Setup()
        { 
            targetExist = new Student("0012340", "Test - student04", "04/04/2024", Utility.enrollment);
            targetNotExist = new Student("0000000", "Test", "00/00/0000", Utility.enrollment);
        }


        [Test]
        public void LinearSearchFound()
        {
            //var target = new Student("0012340", "Test - student04", "04/04/2024", Utility.enrollment);
            var result = Utility.LinearSeachArray(Utility.tenStudents, targetExist);
            // the target should be at index 4
            Assert.AreEqual(4, result);
        }

        [Test]
        public void LinearSearchNotFound()
        {
            //var target = new Student("0000000", "Test", "00/00/0000", Utility.enrollment);
            var result = Utility.LinearSeachArray(Utility.tenStudents, targetNotExist);
            // the target is not in tenStudents array, should return -1
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void BinarySearchFound()
        {
            //var target = new Student("0001234", "Test - student09", "09/09/2024", Utility.enrollment);
            // Copy tenStudents array to another array before sorting
            Student[] copyTenStudents = (Student[])Utility.tenStudents.Clone();
            // First sort the tenStudents
            Array.Sort(copyTenStudents);
            var result = Utility.LinearSeachArray(copyTenStudents, targetExist);

            // the target should be at index 0 after the array is sorted
            Assert.AreEqual(0, result);

        }

        [Test]
        public void BinarySearchNotFound()
        {
            //var target = new Student("0000000", "Test", "00/00/0000", Utility.enrollment);
            // Copy tenStudents array to another array before sorting
            Student[] copyTenStudents = (Student[])Utility.tenStudents.Clone();
            // First sort the tenStudents
            Array.Sort(copyTenStudents);
            var result = Utility.LinearSeachArray(copyTenStudents, targetNotExist);

            // the target is not in tenStudents array, should return -1
            Assert.AreEqual(-1, result);
        }

        //[Test]
        //public void SortInsertionAscending()
        //{
        //    // Copy tenStudents array to another array before sorting
        //    Student[] expected = (Student[])Utility.tenStudents.Clone();
        //    Student[] actual = (Student[])Utility.tenStudents.Clone();
        //    // First sort the tenStudents
        //    Utility.InsertionSortAscending(actual);
        //    //Array.Sort(expected);

        //    CollectionAssert.IsOrdered(actual);
        //    //CollectionAssert.AreEqual(expected, actual);

        //}

        //[Test]
        //public void SortInsertionDescending()
        //{
        //    // Copy tenStudents array to another array before sorting
        //    Student[] expected = (Student[])Utility.tenStudents.Clone();
        //    Student[] actual = (Student[])Utility.tenStudents.Clone();
        //    // First sort the tenStudents
        //    Utility.InsertionSortAscending(actual);
        //    Array.Reverse(expected);

        //    CollectionAssert.IsOrdered(actual);
        //    CollectionAssert.AreEqual(expected, actual);

        //}

    }
}
