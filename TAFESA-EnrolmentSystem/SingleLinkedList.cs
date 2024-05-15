using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TAFESA_EnrolmentSystem
{
    public class SingleLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public int Count
        {
            get;
            private set;
        }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            // Save the head node to temp so we don't lose it
            // need to set the new Head node Next to it
            LinkedListNode<T> temp = Head;
            // Point head to the new node
            Head = node;
            // Insert the rest of the list to the head Next
            Head.Next = temp;

            Count++;
            if (Count == 1)
            {
                // If the list was empty and we now have 1 node
                // then Head and Tail should both point to the new node
                Tail = Head;
            }
        }
        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            // case when no nodes, we add the first node
            // which is both the Head and Tail
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // Before: Head -> 3 -> 5
                // After: Head -------> 5

                // Head -> 3 -> null
                // Head ------> null
                Head = Head.Next;

                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    // Before: Head --> 3 --> 5 --> 7
                    //         Tail = 7
                    // After:  Head --> 3 --> 5 --> null
                    //         Tail = 5;
                    LinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }

        // Implements the ICollection interface
        public void Add(T item)
        {
            AddFirst(item);
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;
            // scenarios:
            // 1: Empty list, current == null, do nothing return false
            // 2: Single node, then previous == null
            // 3: Mandy nodes:
            //      a: node to remove is the first node
            //      b: node to remove is in the middle or last node

            while (current != null) //while we have a node to remove
            {
                if (current.Value.Equals(item))
                {
                    // 3b: if its a node in the middle or end
                    if (previous != null)
                    {
                        //Eg before: Head -> 3 -> 5 -> null
                        //   after: Head -> 3 -------> null
                        previous.Next = current.Next;
                        // if it was at the end, update Tail
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        // case 2 or 3a
                        RemoveFirst();
                    }
                    return true; //we have removed a node
                }
                previous = current;
                current = current.Next;
            }
            return false; // no nodes to remove
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

    }
}

