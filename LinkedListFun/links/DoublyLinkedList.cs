using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListFun.links
{
    class DoublyLinkedList
    {
        private DoublyLinkedNode head = null;
        private DoublyLinkedNode tail = null;
        private int size = 0;

        public void Add(Object data)
        {
            if (head == null)
            {
                head = new DoublyLinkedNode(data);
                tail = head;

            }
            else
            {
                tail.next = new DoublyLinkedNode(data, null, tail);
                tail = tail.next;
            }
            size++;
        }

        public Boolean Remove(Object data)
        {
            if (head == null)
            {
                return false;
            }

            if (tail.data.Equals(data))
            {
                tail = tail.previous;
                tail.next = null;
                size--;
                return true;
            }

            if (head.data.Equals(data))
            {
                head = head.next;
                head.previous = null;
                size--;
                return true;
            }
            DoublyLinkedNode current = tail;
            while (current.previous != null && !current.previous.data.Equals(data))
            {
                current = current.previous;
            }



            return false;
        }

        public new string ToString
        {
            get
            {
                if (head == null)
                {
                    return "The list is empty";
                }
                else
                {
                    string result = "h > " + head.data;
                    DoublyLinkedNode current = head.next;
                    while (current != null)
                    {
                        result += " > " + current.data;
                        current = current.next;
                    }
                    result += " > null";
                    return result;
                }
            }
        }

        public class DoublyLinkedNode
        {
            public Object data = null;
            public DoublyLinkedNode previous = null;
            public DoublyLinkedNode next = null;

            public DoublyLinkedNode(Object data)
            {
                this.data = data;
            }

            public DoublyLinkedNode(Object data, DoublyLinkedNode next, DoublyLinkedNode previous)
            {
                this.data = data;
                this.next = next;
                this.previous = previous;
            }

            public Object getData()
            {
                return data;
            }
        }
    }
    }
