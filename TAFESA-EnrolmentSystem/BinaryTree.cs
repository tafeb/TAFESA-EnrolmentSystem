using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public bool Add(string value)
        {
            Node before = null;
            Node after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.CompareTo(after.StringData) < 0) //Is a new node in the left tree? (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if (value.CompareTo(after.StringData) > 0) //Is a new node in right tree? (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.StringData = value;

            if (this.Root == null) //Tree is empty
            {
                this.Root = newNode;
            }
            else
            {
                if (value.CompareTo(before.StringData) < 0) // (value < before.Data)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }
            return true;
        }

        public Node Find(string value)
        {
            return this.Find(value, this.Root);
        }

        private Node Find(string value, Node parent)
        {
            if (parent != null)
            {
                if (value.CompareTo(parent.StringData) == 0) //(value == parent.Data)
                {
                    return parent;
                }
                if (value.CompareTo(parent.StringData) < 0) //(value < parent.Data)
                {
                    return Find(value, parent.LeftNode);
                }
                else
                {
                    return Find(value, parent.RightNode);
                }
            }
            return null;
        }

        public void Remove(string value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, string key)
        {
            if (parent == null)
            {
                return parent;
            }

            if (key.CompareTo(parent.StringData) < 0) //(key < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key.CompareTo(parent.StringData) > 0) //(key > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, key);
            }
            else //if value is same as parent's value, then this is the node to be deleted
            {
                // node with ony one child or no child
                if (parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null)
                {
                    return parent.LeftNode;
                }

                // node with two children: Get the inorder successor(smallest in the right subtree)
                parent.StringData = MinValue(parent.RightNode);
                // Delete the inorder successor
                parent.RightNode = Remove(parent.RightNode, parent.StringData);
            }
            return parent;
        }

        private string MinValue(Node node)
        {
            string minv = node.StringData;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.StringData;
                node = node.LeftNode;
            }
            return minv;
        }

        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.StringData + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.StringData + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.StringData + " ");
            }
        }
    }
}

