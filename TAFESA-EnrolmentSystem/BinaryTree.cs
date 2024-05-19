﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public bool Add(T value) 
        {
            Node<T> before = null;
            Node<T> after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.CompareTo(after.Data) < 0) //Is a new node in the left tree? (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if (value.CompareTo(after.Data) > 0) //Is a new node in right tree? (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node<T> newNode = new Node<T>();
            newNode.Data = value;

            if (this.Root == null) //Tree is empty
            {
                this.Root = newNode;
            }
            else
            {
                if (value.CompareTo(before.Data) < 0) // (value < before.Data)
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

        public Node<T> Find(T value)
        {
            return this.Find(value, this.Root);
        }

        private Node<T> Find(T value, Node<T> parent) 
        {
            if (parent != null)
            {
                if (value.Equals(parent.Data)) //(value == parent.Data)
                {
                    return parent;
                }
                if (value.CompareTo(parent.Data) < 0) //(value < parent.Data)
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

        public void Remove(T value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node<T> Remove(Node<T> parent, T key)
        {
            if (parent == null)
            {
                return parent;
            }

            if (key.CompareTo(parent.Data) < 0) //(key < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key.CompareTo(parent.Data) > 0) //(key > parent.Data)
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
                parent.Data = MinValue(parent.RightNode);
                // Delete the inorder successor
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }
            return parent;
        }

        private T MinValue(Node<T> node)
        {
            T minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return minv;
        }

        public void TraversePreOrder(Node<T> parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }

    }
}

