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
        public Enrollment enrollment;
        private Student targetExist;
        private Student targetNotExist;
        public Student[] testStudents;

        [SetUp]
        public void Setup()
        { 
            targetExist = new Student("0055555", "Test - student06", "06/06/2024", enrollment);
            targetNotExist = new Student("0000000", "Test", "00/00/0000", enrollment);

            testStudents = new Student[] {
                                new Student("0023602", "Test - student05", "05/05/2024", enrollment),
                                new Student("0012345", "Test - student00", "00/00/2024", enrollment),
                                new Student("0012344", "Test - student09", "09/09/2024", enrollment),
                                new Student("0020124", "Test - student01", "01/01/2024", enrollment),
                                new Student("0013116", "Test - student07", "07/07/2024", enrollment),
                                new Student("0081021", "Test - student02", "02/02/2024", enrollment),
                                new Student("0063368", "Test - student03", "03/03/2024", enrollment),
                                new Student("0012340", "Test - student04", "04/04/2024", enrollment),
                                new Student("0055555", "Test - student06", "06/06/2024", enrollment),
                                new Student("0033333", "Test - student08", "08/08/2024", enrollment),
                            };

        }

        [Test]
        public void LinearSearchFound()
        {
            try
            {
                var result = Utility.LinearSeachArray(Utility.tenStudents, targetExist);
                // the target should be at index 6
                Assert.AreEqual(6, result);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception caught: {ex}");   
            }          
        }

        [Test]
        public void LinearSearchNotFound()
        {
            try
            {
                var result = Utility.LinearSeachArray(Utility.tenStudents, targetNotExist);

                // the target is not in tenStudents array, should return -1
                Assert.AreEqual(-1, result);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception caught: {ex}");
            }
            
        }

        [Test]
        public void BinarySearchFound()
        {
            Array.Sort(testStudents);

            try
            {
                var result = Utility.BinarySearchArray(testStudents, targetExist);

                // the target should be at index 7 after the array is sorted
                Assert.AreEqual(7, result);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception caught: {ex}");
            }     
        }

        [Test]
        public void BinarySearchNotFound()
        {
            Array.Sort(testStudents);

            try
            {
                var result = Utility.BinarySearchArray(testStudents, targetNotExist);

                // the target is not in tenStudents array, should return -1
                Assert.AreEqual(-1, result);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception caught: {ex}");
            }
            
        }

        [Test]
        public void SortInsertionAscending()
        {
            Utility.InsertionSortAscending(Utility.tenStudents);
            Utility.InsertionSortAscending(testStudents);

            Assert.That(testStudents, Is.Ordered.Ascending);
            CollectionAssert.AreEqual(Utility.tenStudents, testStudents);
       
        }

        [Test]
        public void SortInsertionDescending()
        {
            Utility.InsertionSortDescending(Utility.tenStudents);
            Utility.InsertionSortDescending(testStudents);
            
            Assert.That(testStudents, Is.Ordered.Descending);
            CollectionAssert.AreEqual(Utility.tenStudents, testStudents);
           
        }
    }
}
