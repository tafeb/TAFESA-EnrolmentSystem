using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TAFESA_EnrolmentSystem;

namespace StudentTests
{
    [TestFixture]
    public class SearchingAndSortingTests
    {
        [Test]
        public void LinearSearchFound()
        {

            var target = new Student("0012340", "Test - student04", "04/04/2024", Utility.enrollment);

            // the target should be at index 4
            Assert.AreEqual(4, Utility.LinearSeachArray(Utility.tenStudents, target));
        }

        [Test]
        public void LinearSearchNotFound()
        {
            var target = new Student("0000000", "Test", "00/00/0000", Utility.enrollment);

            // the target is not in tenStudents array, should return -1
            Assert.AreEqual(-1, Utility.LinearSeachArray(Utility.tenStudents, target));
        }

        [Test]
        public void BinarySearchFound()
        {

            var target = new Student("0001234", "Test - student09", "09/09/2024", Utility.enrollment);
            // Copy tenStudents array to another array before sorting
            Student[] copyTenStudents = (Student[])Utility.tenStudents.Clone();
            // First sort the tenStudents
            Array.Sort(copyTenStudents);

            // the target should be at index 0 after the array is sorted
            Assert.AreEqual(0, Utility.LinearSeachArray(copyTenStudents, target));

        }

        [Test]
        public void BinarySearchNotFound()
        {

            var target = new Student("0000000", "Test", "00/00/0000", Utility.enrollment);
            // Copy tenStudents array to another array before sorting
            Student[] copyTenStudents = (Student[])Utility.tenStudents.Clone();
            // First sort the tenStudents
            Array.Sort(copyTenStudents);

            // the target is not in tenStudents array, should return -1
            Assert.AreEqual(-1, Utility.LinearSeachArray(copyTenStudents, target));
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
        //    //Array.Reverse(expected);

        //    CollectionAssert.IsOrdered(actual);
        //    //CollectionAssert.AreEqual(expected, actual);

        //}

    }
}
