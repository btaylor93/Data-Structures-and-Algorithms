﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public abstract class Tree<T>
    {
        public Node<T> Root { get; set; }

        public void PreOrder()
        {
            PreOrder(Root);
        }

        protected void PreOrder(Node<T> node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        public void InOrder()
        {
            InOrder(Root);
        }

        protected void InOrder(Node<T> node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }

        protected void PostOrder(Node<T> node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);
        }

        public void BreadthFirst()
        {
            BreadthFirst(Root);
        }

        protected void BreadthFirst(Node<T> root)
        {
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node<T> front = breadth.Dequeue();
                Console.WriteLine(front.Value);

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        abstract public void Add(Node<T> node);
        abstract public Node<T> Search(T value);
        abstract protected Node<T> Search(Node<T> root, T value);
    }
}
