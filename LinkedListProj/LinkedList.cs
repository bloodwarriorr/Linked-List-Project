using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    internal class LinkedList<T>
    {
        Node<T> head;
        int length;

        public LinkedList()
        {

        }
        

        public int GetLength()
        {
            return length;
        }
        public Node<T> GetHead()
        {
            return head;
        }
        //בוצע שינוי למתודה של החוליה משום שאנו מדפיסים את הרשימה הכוללת ולא חוליה יחידה.
        public override string ToString()
        {
            string str = "";
            Node<T> temp = head;
            while (temp != null)
            {
                str += temp.ToString() + "-->";
                temp = temp.GetNext();
            }
            return str + "null";
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.SetNext(this.head);
            head = newNode;
            length++;

        }

       
        public void AddLast(T value)
        {

            Node<T> newNode = new Node<T>(value);

            if (this.head == null)
            {
                this.head = newNode;
                length++;
                return;

            }

            Node<T> lastNode = this.head;
            while (lastNode.HasNext())
            {
                lastNode = lastNode.GetNext();
            }
            lastNode.SetNext(newNode);
            length++;

        }
        public void DeleteLast()
        {
            if (this.head == null || !this.head.HasNext())
            {
                return;
            }

            Node<T> lastNode = this.head;
            Node<T> prevNode = null;
            while (lastNode.HasNext())
            {
                prevNode = lastNode;
                lastNode = lastNode.GetNext();
            }

            prevNode.SetNext(null);
            length--;

        }
        public void DeleteFirst()
        {
            if (this.head == null)
                return;

            Node<T> temp = this.head;
            this.head = this.head.GetNext();
            temp.SetNext(null);
            length--;

        }

        public T GetNodeFirstValue()
        {
            if (this.head == null)
            {
                return default(T);
            }
            return this.head.GetValue();
        }

        public T GetNodeLastValue()
        {
            if (this.head == null)
            {
                return default(T);
            }
            Node<T> node = this.head;
            while (node.HasNext())
            {
                node = node.GetNext();
            }
            return node.GetValue();
        }


        public T GetNodeByIndex(int index)
        {
            if (index >= length)
            {
                return default(T);
            }
            Node<T> node = this.head;
            int i = 0;
            while (++i < index + 1)
            {
                node = node.GetNext();
            }
            return node.GetValue();
        }

       
        public bool Contains(T value)
        {
           
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.GetValue().Equals(value))
                {
                    return true;
                }
                temp = temp.GetNext();
            }

            return false;
        }


        public LinkedList<T> ReturnListNoDuplicates()
        {
            if (head == null)
            {
                return null;
            }
            LinkedList<T> listWithOutDup = new LinkedList<T>();
            listWithOutDup.AddLast(this.head.GetValue());
            Node<T> node = head.GetNext();
            while (node != null)
            {
                if (!listWithOutDup.Contains(node.GetValue()))
                {
                    listWithOutDup.AddLast(node.GetValue());
                }

                node = node.GetNext();
            }
            return listWithOutDup;
        }
        public void ReverseList()
        { //10,20,30,40,50,60->60,50,40,30,20,10
            Node<T> prev = null, current = head, next = null;//prev null,current 10,next null 
            while (current != null)
            {
                next = current.GetNext(); //next =20 ->next 30
                current.SetNext(prev); //10->null ->20->10
                prev = current; //prev=10-> prev=20
                current = next; //current =20 ->current=30
                
            }
            head = prev;//60,50,40,30,20,10
        }

     

        
       
        public void SortList()
        {
           //10,54,2,6,88,1->1,2,6,10,54,88
            Node<T> current = head, index = null;//current-10 ,index=null
            T temp; //temp=null

            if (head == null)
            {
                return;
            }
            else
            {
                //bubble sort-אנחנו ממיינים את הערכים של החוליות על ידי מיון בועות-החלפת ערכים על ידי השוואה-
                //שימוש בממשק ICOMPAREABLE
                while (current != null)
                {
                    
                    index = current.GetNext();//index->54

                    while (index != null)
                    {
                        IComparable<T> nodeValue = (IComparable<T>)current.GetValue();//(icompareable)10
                        
                        if (nodeValue.CompareTo(index.GetValue()) > 0)//בדיקה האם הערך שנמצא בחולייה גדול מהערך שנמצא באינדקס-אם כן-החלף בינהם
                        {
                            
                            temp = current.GetValue(); //שמירת הערך הנוכחי במשתנה זמני -temp-10
                            current.SetValue(index.GetValue());//current=54
                            index.SetValue(temp);//index=10
                        }
                        index = index.GetNext();//
                    }
                    current = current.GetNext();
                }
            }
        }

       
    }
}
