using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    internal class Node<T>
       
    {

        private T value;
        private Node<T> next;
        


        public Node(T value)
        {
            this.value = value;
            this.next = null;
           
        }

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
           
        }
      
        public T GetValue()
        {
            return this.value;
        }

        public Node<T> GetNext()
        {
            return this.next;
        }

        public bool HasNext()
        {
            return this.next != null;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public override string ToString()
        {
            string str = "";
            str += this.value;
            return str;
        }

        //check prints for nodes
        public string Print()
        {
            if (this.next == null)
            {
                return this.value + " --> null";
            }

            return this.value + " --> " + this.next.Print();
        }

       
    }

}
