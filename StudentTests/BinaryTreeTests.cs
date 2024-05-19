using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_EnrolmentSystem;

namespace StudentTest
{
    [TestFixture]
    public class BinaryTreeTests
    {
        public Enrollment enrollment;
        public BinaryTree<Student> binaryTrees;

        [SetUp]
        public void Setup()
        {
            binaryTrees = new BinaryTree<Student>();

            // Add students with simple studentIDs
            binaryTrees.Add(new Student("1", "Test", "00/00/2024", enrollment));
            binaryTrees.Add(new Student("2", "Test", "00/00/2024", enrollment));
            binaryTrees.Add(new Student("7", "Test", "00/00/2024", enrollment));
            binaryTrees.Add(new Student("3", "Test", "00/00/2024", enrollment));
            binaryTrees.Add(new Student("6", "Test", "00/00/2024", enrollment));
            binaryTrees.Add(new Student("5", "Test", "00/00/2024", enrollment));
            binaryTrees.Add(new Student("8", "Test", "00/00/2024", enrollment));
        }

        [Test]
        public void TravesePreOrder()
        {
            binaryTrees.TraversePreOrder(binaryTrees.Root);
            // Tree Root should not be null
            Assert.IsNotNull(binaryTrees.Root);
            // Root should be "1"
            Assert.AreEqual("1", binaryTrees.Root.Data.StudentID);
            TestContext.Out.WriteLine("\nThe output should be: 1 2 7 3 6 5 8");

        }

        [Test]
        public void TraversePostOrder()
        {
            binaryTrees.TraversePostOrder(binaryTrees.Root);
            // Tree Root should not be null
            Assert.IsNotNull(binaryTrees.Root);
            // Root should be "1"
            Assert.AreEqual("1", binaryTrees.Root.Data.StudentID);
            TestContext.Out.WriteLine("\nThe output should be: 5 6 3 8 7 2 1");

        }

        [Test]
        public void TraverseInOrder() 
        {
            binaryTrees.TraverseInOrder(binaryTrees.Root);
            // Tree Root should not be null
            Assert.IsNotNull(binaryTrees.Root);
            // Root should be "1"
            Assert.AreEqual("1", binaryTrees.Root.Data.StudentID);
            TestContext.Out.WriteLine("\nThe output should be: 1 2 3 5 6 7 8");
        }
    }
}
