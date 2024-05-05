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
            targetExist = new Student("0055555", "Test - student06", "06/06/2024", Utility.enrollment);
            targetNotExist = new Student("0000000", "Test", "00/00/0000", Utility.enrollment);
        }


        [Test]
        public void LinearSearchFound()
        {
            var result = Utility.LinearSeachArray(Utility.tenStudents, targetExist);
            // the target should be at index 4
            Assert.AreEqual(6, result);
        }

        [Test]
        public void LinearSearchNotFound()
        {
            var result = Utility.LinearSeachArray(Utility.tenStudents, targetNotExist);
            // the target is not in tenStudents array, should return -1
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void BinarySearchFound()
        {
            // Copy tenStudents array to another array before sorting
            Student[] copyTenStudents = (Student[])Utility.tenStudents.Clone();
            // First sort the tenStudents
            Array.Sort(copyTenStudents);
            var result = Utility.LinearSeachArray(copyTenStudents, targetExist);

            // the target should be at index 0 after the array is sorted
            Assert.AreEqual(7, result);

        }

        [Test]
        public void BinarySearchNotFound()
        {
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
