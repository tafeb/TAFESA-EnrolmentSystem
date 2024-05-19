using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Utility
    {
        public static Enrollment enrollment = new Enrollment();

        // create array of 10 students
        public static Student[] tenStudents = {
                                new Student("0012345", "Test - student00", "00/00/2024", enrollment),
                                new Student("0020124", "Test - student01", "01/01/2024", enrollment),
                                new Student("0081021", "Test - student02", "02/02/2024", enrollment),
                                new Student("0063368", "Test - student03", "03/03/2024", enrollment),
                                new Student("0012340", "Test - student04", "04/04/2024", enrollment),
                                new Student("0023602", "Test - student05", "05/05/2024", enrollment),
                                new Student("0055555", "Test - student06", "06/06/2024", enrollment),
                                new Student("0013116", "Test - student07", "07/07/2024", enrollment),
                                new Student("0033333", "Test - student08", "08/08/2024", enrollment),
                                new Student("0012344", "Test - student09", "09/09/2024", enrollment)
                                };
    

        /// <summary>
        /// The method uses a sequential or linear search through an array of any type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>Returns 1 if target is found; -1 if target is not found.</returns>
        public static int LinearSeachArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;
            // convert to upper case
            //target = target.ToUpper();
            // while not found and not end of arraytarget
            while (!found && i < array.Length)
            {
                try
                {
                    if (target.CompareTo(array[i]) == 0)
                    {
                        found = true;
                    }
                    else
                    {
                        // if no match, move to next element in array
                        i++;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Exception caught: {ex}");
                }
            }
            if (i < array.Length)
            {
                //return true;
                // return index of array element found
                return i;
            }
            else
            {
                //return false;
                // return -1 if not found
                return -1;
            }
        }

        /// <summary>
        /// The method uses binary search through array of any type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>Returns 1 if target is found; -1 if target is not found.</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1; // Runtime error fix, should be array.Length - 1
            int mid;
            //target = target.ToUpper();

            do
            {
                try
                {
                    mid = (min + max) / 2; //logical error fix, it should be (min + max)/2
                    // if the item is found,
                    if (array[mid].CompareTo(target) == 0)
                    {
                        // return the index mid
                        return mid;
                    }
                    // checks if the criteria is alphabetically after myArray[mid] 
                    // then the criteria is in the top half of the search
                    if (target.CompareTo(array[mid]) > 0)
                    {
                        // the item must be in the upper half,
                        // set the min for the search to start at mid+1
                        min = mid + 1;
                    }
                    else
                    {
                        // otherwise the item must be in the lower half,
                        // set the max to the mid-1
                        max = mid - 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {ex}");
                }
            }
            while (min <= max);
                // -1 is returnded when not found
                return -1;
            
        }
        
        //public static void SelectionSort<T>(T[] sortItem) where T : IComparable<T>
        //{
        //    T temp;
        //    int minIndex;
        //    for (int i = 0; i < sortItem.Length - 1; i++)
        //    {
        //        minIndex = i;
        //        for (int j = i + 1; j < sortItem.Length; j++)
        //        {
        //            if (sortItem[j].CompareTo(sortItem[minIndex]) < 0)
        //            {
        //                minIndex = j;
        //            }
        //        }
        //        // swap
        //        // converting Type T to String
        //        temp = sortItem[minIndex];
        //        sortItem[minIndex] = sortItem[i];
        //        sortItem[i] = (T)(object)temp;
        //    }
        //}

        /// <summary>
        /// The method uses an insertion sort algorithm for sorting in asecending order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sortItem"></param>
        public static void InsertionSortAscending<T>(T[] sortItem) where T : IComparable<T>
        {
            T temp;

            for (int i = 0; i < sortItem.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    // Swap if the element at j - 1 position is greater than the element at j position
                    if (sortItem[j - 1].CompareTo(sortItem[j]) > 0)
                    {
                        temp = sortItem[j - 1];
                        sortItem[j - 1] = sortItem[j];
                        sortItem[j] = (T)(object)temp;
                    }
                }
            }
        }

        /// <summary>
        /// The method uses an insertion sort algorithm for sorting in desecending order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sortItem"></param>
        public static void InsertionSortDescending<T>(T[] sortItem) where T : IComparable<T>
        {
            T temp;

            for (int i = 0; i < sortItem.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    // Swap if the element at j - 1 position is lesser than the element at j position
                    if (sortItem[j - 1].CompareTo(sortItem[j]) < 0)
                    {
                        temp = sortItem[j - 1];
                        sortItem[j - 1] = sortItem[j];
                        sortItem[j] = (T)(object)temp;
                    }
                }
            }
        }

    }
}
