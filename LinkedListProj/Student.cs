using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    internal class Student:IComparable<Student>
    {
        string name;
        Node<Course> Course;

        public Student(string name,Node<Course> Course)
        {
            this.name = name;
            this.Course = Course;
        }
        public Student(Student obj)
        {
          this.name=obj.name;
          this.Course = obj.Course;
        }
        public string GetName()
        {
            return name;
        }
        public Node<Course> GetCourse()
        {
            return Course;
        }
        public override string ToString()
        {
            return this.name+ " " + this.Course.Print();
        }

        public int CompareTo(Student other)
        {
            return name.CompareTo(other.name);
        }
    }
}
