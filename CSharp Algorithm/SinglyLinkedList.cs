using System;

namespace CSharp_Algorithm
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            // save the current head
            Node<T> temp =  Head;

            Head = node;

            // the new head should point to the former head - shifting the former head
            Head.Next = temp;

            Count++;

            // if the count equals one, then the tail and the head should point at the same node
            if(Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if(IsEmpty)
            {
                Head = node;

            } 
            else
            {
                // points to the next node if the list isn't empty
                Tail.Next = node;
            }
            // Then assign the new node to the tail
            Tail = node;

            Count++;
        }


        private bool IsEmpty => Count == 0;
    }
}
