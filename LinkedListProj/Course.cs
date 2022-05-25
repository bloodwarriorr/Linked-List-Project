using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    internal class Course:IComparable<Course>
    {
        int courseCode;
        int mark;
        public Course(int courseCode, int mark)
        {
            this.courseCode = courseCode;
            this.mark = mark;
        }

       

        public int GetCourseCode()
        {
            return courseCode;
        }
        public int GetMark()
        {
            return mark;
        }
        
        public override string ToString()
        {
            return this.mark + " " + this.courseCode;
        }
        public int CompareTo(Course other)
        {
           if(courseCode<other.courseCode) return -1;
           else if(courseCode>other.courseCode) return 1;
           else return 0;
        }
    }
}
