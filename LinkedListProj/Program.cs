using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] names = { "Avi", "Beni", "Dani", "Sholmi", "Jimmie", "Sahar", "David", "Moshe", "Amir", "Dvir" };
            Console.WriteLine("*******Initial Values********");
            Console.WriteLine("---List Of Ints---");
            LinkedList<int> listOfInts = CreateListOfInts();

            Console.WriteLine("\n---List Of Workers---");
            LinkedList<Worker> workers = CreateListOfWorkers(names);

            Console.WriteLine("\n---List Of Students---");
            LinkedList<Student> listOfStudents = CreateListOfStudents(names);

            Console.WriteLine("\n---List Of Students Array --");
            LinkedList<Student[]> listOfStudentArray = CreateListOfStudentArray(names);

            Console.WriteLine("\n---Array Of Student List --");
            LinkedList<Student>[] ArrayOfStudentLists = CreateArrayOfStudentLists(names);

            Console.WriteLine("************************************************************\n");
            //checks
            //1
            Console.WriteLine("\n1");
            Console.WriteLine($"Return int list length:{listOfInts.GetLength()}");
            Console.WriteLine($"Return worker list length:{workers.GetLength()}");
            Console.WriteLine("***************");
            //2
            Console.WriteLine("\n2");
            Console.WriteLine($"Return To string of int list:{listOfInts}");
            Console.WriteLine($"Return To string of wokrer list:\n{workers}");
            Console.WriteLine("***************");
            //3
            Console.WriteLine("\n3");
            listOfInts.AddFirst(121);
            workers.AddFirst(new Worker("check",8494));
            Console.WriteLine($"Add first node int list:{listOfInts}");
            Console.WriteLine($"Add first node worker list:{workers}");
            Console.WriteLine("***************");
            //4
            Console.WriteLine("\n4");
            listOfInts.AddLast(5454);
            workers.AddLast (new Worker("lastWorker", 9999));
            Console.WriteLine($"Add last node int list:{listOfInts}");
            Console.WriteLine($"Add last node worker list :{workers}");
            Console.WriteLine("***************");
            //5
            Console.WriteLine("\n5");
            listOfInts.DeleteFirst();
            workers.DeleteFirst();
            Console.WriteLine($"Delete first node int list:{listOfInts}");
            Console.WriteLine($"Delete first node worker list:{workers}");
            Console.WriteLine("***************");
            //6
            Console.WriteLine("\n6");
            listOfInts.DeleteLast();
            workers.DeleteLast();
            Console.WriteLine($"Delete last node int list:{listOfInts}");
            Console.WriteLine($"Delete last node worker list:{workers}");
            Console.WriteLine("***************");
            //7
            Console.WriteLine("\n7");
            Console.WriteLine($"Get first node value int list:{listOfInts.GetNodeFirstValue()}");
            Console.WriteLine($"Get first node value worker list:{workers.GetNodeFirstValue()}");
            Console.WriteLine("***************");
            //8
            Console.WriteLine("\n8");
            Console.WriteLine($"Get last node value int list:{listOfInts.GetNodeLastValue()}");
            Console.WriteLine($"Get last node value worker list:{workers.GetNodeLastValue()}");
            Console.WriteLine("***************");
            //9
            Console.WriteLine("\n9");
            Console.WriteLine($"Get node value by index int list:{listOfInts.GetNodeByIndex(9)}");
            Console.WriteLine($"Get node value by index worker list:{workers.GetNodeByIndex(2)}");
            Console.WriteLine("***************");
            //10
            Console.WriteLine("\n10");
            Worker w1 = new Worker("check", 8484);
            workers.AddLast(w1);
            Console.WriteLine($"Check if contains value int list:{listOfInts.Contains(4)}");
            Console.WriteLine($"Check if contains value worker list:{workers.Contains(w1)}");
            Console.WriteLine("***************");
            //11
            Console.WriteLine("\n11");
            Worker w2 = new Worker("check", 8484);
            workers.AddFirst(w2);
            listOfInts.AddFirst(222);
            listOfInts.AddLast(222);
            Console.WriteLine("before!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine($"Int list{listOfInts}");
            Console.WriteLine($"Worker list:{workers}");
            Console.WriteLine("after----------------------------");
            Console.WriteLine($"List with no duplicate int list:{listOfInts.ReturnListNoDuplicates()}");
            Console.WriteLine($"List with no duplicates worker list:{workers.ReturnListNoDuplicates()}");
            Console.WriteLine("***************");
            //12
            Console.WriteLine("\n12");
            listOfInts.ReverseList();
            workers.ReverseList();
            Console.WriteLine($"Reverse list int list:{listOfInts}");
            Console.WriteLine($"Reverse list worker list:{workers}");
            Console.WriteLine("***************");
            //13
            Console.WriteLine("\n13");
            listOfInts.SortList();
            workers.SortList();
            Console.WriteLine($"Reverse list int list:{listOfInts}");
            Console.WriteLine($"Reverse list worker list:{workers}");
            Console.WriteLine("******************");
            //14
            Console.WriteLine("\n14");
            LinkedList<int> clonedIntList = CloneList(listOfInts);
            Console.WriteLine(clonedIntList);
            Console.WriteLine("--------");
            LinkedList<Worker>clonedWorkerList=CloneList(workers);
            Console.WriteLine(clonedWorkerList);
            Console.WriteLine("******************");
            //15
            Console.WriteLine("\n15");
            clonedWorkerList.DeleteFirst();
            Console.WriteLine(IsBothListsAreSame(clonedIntList,listOfInts));
            Console.WriteLine(IsBothListsAreSame(clonedWorkerList,workers));
            Console.WriteLine("********************");
            //16
            Console.WriteLine("\n16");
            LinkedList<int> bothListValuesInt = MergeTwoLists(clonedIntList,listOfInts);
            LinkedList<Worker> bothListValuesWorker = MergeTwoLists(clonedWorkerList,workers);
            Console.WriteLine(bothListValuesInt);
            Console.WriteLine("--------------------");
            Console.WriteLine(bothListValuesWorker);
            Console.WriteLine("*********************");
            //17
            Console.WriteLine("\n17");
            clonedIntList.AddLast(77777);
            clonedWorkerList.AddLast(new Worker("mordehai", 979797));
            LinkedList<int> bothListValuesIntNoDup = MergeTwoListsWithOutDuplicate(clonedIntList, listOfInts);
            LinkedList<Worker> bothListValuesWorkerNoDup = MergeTwoListsWithOutDuplicate(clonedWorkerList, workers);
            Console.WriteLine(bothListValuesIntNoDup);
            Console.WriteLine("---------");
            Console.WriteLine(bothListValuesWorkerNoDup);
            Console.WriteLine("******************");
            //18
            Console.WriteLine("\n18");
            LinkedList<int> innerJoinedListInt = ReturnInnerJoinedList(clonedIntList, listOfInts);
            LinkedList<Worker> innerJoinedListWorker = ReturnInnerJoinedList(clonedWorkerList, workers);
            Console.WriteLine(innerJoinedListInt);
            Console.WriteLine("--------------------");
            Console.WriteLine(innerJoinedListWorker);
            Console.WriteLine("*********************");

            //20
            Console.WriteLine("\n20");
            PrintStudentGradeAvarage(listOfStudents);
            Console.WriteLine("********************");
            //21
            Console.WriteLine("\n21");
            LinkedList<Student> exceededStudentList = ReturnExceedStudentByClass(listOfStudentArray);
            Console.WriteLine(exceededStudentList);
            Console.WriteLine("********************");
            //22
            Console.WriteLine("\n22");
            Student[] arr = ReturnFailedStudentArr(ArrayOfStudentLists);
            foreach (Student item in arr)
            {
                Console.WriteLine(item+" ");
            }
            Console.WriteLine();

        }
        //Help methods to initialize objects
        private static LinkedList<int> CreateListOfInts()
        {
            Random rnd = new Random();
            LinkedList<int> listOfInts = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                listOfInts.AddLast(rnd.Next(50));
            }
            Console.WriteLine(listOfInts);
            return listOfInts;
        }
        private static LinkedList<Student> CreateListOfStudents(string[] names)
        {
            Random rnd = new Random();
            LinkedList<Student> listOfStudents = new LinkedList<Student>();
            for (int i = 0; i < names.Length; i++)
            {
                listOfStudents.AddLast(new Student(names[i], CreateCourses(rnd)));
                Console.WriteLine($"Name = {listOfStudents.GetNodeByIndex(i)}");
            }
            return listOfStudents;
        }

        private static LinkedList<Worker> CreateListOfWorkers(string[] names)
        {
            const float MAX = 20000, MIN = 8000;
            Random rnd = new Random();
            LinkedList<Worker> listOfWorkers = new LinkedList<Worker>();
            for (int i = 0; i < names.Length; i++)
            {
                listOfWorkers.AddLast(new Worker(names[i], Math.Round(rnd.NextDouble() * (MAX - MIN) + MIN, 2)));
                Console.WriteLine($"{listOfWorkers.GetNodeByIndex(i)}");
            }
            return listOfWorkers;
        }

        private static LinkedList<Student>[] CreateArrayOfStudentLists(string[] names)
        {
            Random rnd = new Random();
            LinkedList<Student>[] ArrayOfStudentLists = new LinkedList<Student>[3];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Class #: " + (i + 1));
                ArrayOfStudentLists[i] = new LinkedList<Student>();
                for (int j = 0; j < 3; j++)
                {
                    ArrayOfStudentLists[i].AddLast(new Student(names[count], CreateCourses(rnd)));
                    count++;
                    Console.WriteLine(ArrayOfStudentLists[i].GetNodeByIndex(j));
                }
                Console.WriteLine();

            }
            return ArrayOfStudentLists;
        }

        private static LinkedList<Student[]> CreateListOfStudentArray(string[] names)
        {
            Random rnd = new Random();
            LinkedList<Student[]> listOfClasses = new LinkedList<Student[]>();
            int count = 0;
            for (int i = 1; i < 4; i++)
            {
                Student[] s = new Student[3];
                for (int j = 0; j < 3; j++)
                {
                    s[j] = new Student(names[count], CreateCourses(rnd));
                    count++;

                }
                listOfClasses.AddLast(s);
            }
            Node<Student[]> node = listOfClasses.GetHead();
            for (int i = 0; i < listOfClasses.GetLength(); i++)
            {
                Console.WriteLine("Class #: " + (i + 1));
                for (int j = 0; j < node.GetValue().Length; j++)
                    Console.WriteLine(node.GetValue()[j]);
                node = node.GetNext();
                Console.WriteLine();
            }
            return listOfClasses;
        }

        private static Node<Course> CreateCourses(Random rnd)
        {

            Node<Course> course = new Node<Course>(new Course(1, rnd.Next(30, 101)));
            Node<Course> temp = course;

            for (int i = 2; i < 6; i++)
            {
                temp.SetNext(new Node<Course>(new Course(i, rnd.Next(30, 101))));
                temp = temp.GetNext();
            }
            return course;
        }
        //

        //static methods

        //15
        static bool IsBothListsAreSame<T>(LinkedList<T> list1, LinkedList<T> list2)
        {
            if (IsListNullCheck(list1) && IsListNullCheck(list2))
            {
                return true;
            }
            else if (IsListNullCheck(list1) || IsListNullCheck(list2))
            {
                return false;
            }
            if (list1.GetLength() != list2.GetLength())
            {
                return false;
            }
            if (list1 == list2)
            {
                return true;
            }
            Node<T> list1Head = list1.GetHead();
            Node<T> list2Head = list2.GetHead();
            while (list1Head != null)
            {
                if (!(list1Head.GetValue().Equals(list2Head.GetValue())))
                {
                    return false;
                }
                list1Head = list1Head.GetNext();
                list2Head = list2Head.GetNext();
            }
            return true;

        }
        //14
        static LinkedList<T> CloneList<T>(LinkedList<T> list)
        {
            
            if (IsListNullCheck(list))
            {
                return null;
            }
            LinkedList<T> NewList = new LinkedList<T>();
            Node<T> listHead = list.GetHead();

            while (listHead != null)
            {
                NewList.AddLast(listHead.GetValue());
                listHead = listHead.GetNext();
            }

            return NewList;
        }
        //17
        static LinkedList<T> MergeTwoListsWithOutDuplicate<T>(LinkedList<T> list1, LinkedList<T> list2)
        {

            LinkedList<T> NewList = MergeTwoLists(list1, list2);
            if (NewList == null)
            {
                return null;
            }
            NewList = NewList.ReturnListNoDuplicates();
            return NewList;

        }
        //16
        static LinkedList<T> MergeTwoLists<T>(LinkedList<T> list1, LinkedList<T> list2)
        {
            //אנחנו מניחים שעלינו להחזיר רשימה חדשה, וברגע שאחת הרשימות היא נאל, אנו נחזיר נאל ולא רשימה חדשה.
            if (IsListNullCheck(list1) || IsListNullCheck(list2))
            {
                return null;
            }
            LinkedList<T> NewList = new LinkedList<T>();
            Node<T> List1Head = list1.GetHead();
            Node<T> List2Head = list2.GetHead();
            while (List1Head != null)
            {
                NewList.AddLast(List1Head.GetValue());
                List1Head = List1Head.GetNext();
            }
            while (List2Head != null)
            {
                NewList.AddLast(List2Head.GetValue());
                List2Head = List2Head.GetNext();
            }
            return NewList;
        }
        //18
        static LinkedList<T> ReturnInnerJoinedList<T>(LinkedList<T> list1, LinkedList<T> list2)
        {
            
            if (IsListNullCheck(list1) || IsListNullCheck(list2))
            {
                return null;
            }
            LinkedList<T> newList = new LinkedList<T>();
            Node<T> list1Head = list1.GetHead();
            Node<T> list2Head = list2.GetHead();

            while (list1Head != null && list2Head != null)
            {
                if (list1.Contains(list2Head.GetValue()))
                {
                    newList.AddLast(list2Head.GetValue());

                }
                list2Head = list2Head.GetNext();
                list1Head = list1Head.GetNext();
            }
            return newList;
        }
        //help method null check
        static bool IsListNullCheck<T>(LinkedList<T> list)
        {

            if (list == null || list.GetHead() == null)
            {
                return true;
            }
            return false;

        }
        //20
        //assuming that course code is not null at this point
        public static void PrintStudentGradeAvarage(LinkedList<Student> studentList)
        {
            double avarage = 0;
            int counter = 0;
            if (IsListNullCheck(studentList))
            {
                return;
            }
            Node<Student> studentListHead = studentList.GetHead();
            Node<Course> courseHead = null;
            while (studentListHead != null)
            {
                courseHead = studentListHead.GetValue().GetCourse();
                while (courseHead != null)
                {
                    counter++;
                    avarage += courseHead.GetValue().GetMark();
                    courseHead = courseHead.GetNext();

                }
                Console.WriteLine($"{studentListHead.GetValue().GetName()}'s avarage is:{avarage / counter:f2}");
                counter = 0;
                avarage = 0;
                studentListHead = studentListHead.GetNext();
            }
        }

        //21
        public static LinkedList<Student> ReturnExceedStudentByClass(LinkedList<Student[]> studentLinkedList)
        {
            double sum = 0;
            int max = 0, counter = 0, index = 0;
            if (IsListNullCheck(studentLinkedList))
            {
                return null;
            }
            LinkedList<Student> listOfExceeded = new LinkedList<Student>();
            Node<Course> courseHead = null;
            //שמירת ראש הרשימה של הכיתה-היא בעצם מערך(רשימה של מערכים)
            Node<Student[]> total_list_head = studentLinkedList.GetHead();
            while (total_list_head != null)
            {
                for (int i = 0; i < total_list_head.GetValue().Length; i++)
                {
                    courseHead = total_list_head.GetValue()[i].GetCourse();
                    //סכימת כל הציונים של סטודנט בכיתה לפי קורס
                    while (courseHead != null)
                    {
                        counter++;
                        sum += courseHead.GetValue().GetMark();
                        courseHead = courseHead.GetNext();
                    }
                    //ממוצע ציונים של הסטודנט
                    sum /= counter;
                    //בדיקה האם הממוצע גבוה מהממוצע הכיתתי-אותחל בערך ברירת מחדל-במידה וכן-נשמור אותו
                    if (max < sum)
                    {
                        index = i;
                        max = (int)sum;
                    }
                    //איפוס ממוצע הציונים וכמות הקורסים-הכנה לסטודנט הבא
                    sum = 0;
                    counter = 0;
                }
                //איפוס הממוצע הכיתתי-הכי גבוה-הכנה לכיתה הבאה
                max = 0;
                //במידה והגענו עד הלום, יש בידנו את הסטודנט המצטיין בכיתה מסויימת-אותו נוסיף לרשימת המצטיינים
                listOfExceeded.AddLast(total_list_head.GetValue()[index]);
                //קידום הרשימה לכיתה הבאה
                total_list_head = total_list_head.GetNext();

            }
            //החזרת הרשימה של המצטיינים
            return listOfExceeded;
        }
        //22
        public static Student[] ReturnFailedStudentArr(LinkedList<Student>[] studentLinkedList)
        {
            const int FAIL_GRADE = 55;
            //יצירת מערך נכשלים כגודל הכיתות
            Student[] failedArr = new Student[studentLinkedList.Length];
            int maxCounter = -1;
            int counter = 0;


            for (int i = 0; i < studentLinkedList.Length; i++)
            {
                //מציאת רשימת הסטודנטים שנמצאת בכיתה מסויימת-בעצם כל תא ברשימה הוא כיתה
                Node<Student> studentHead = studentLinkedList[i].GetHead();
                while (studentHead != null)
                {
                    //  מציאת קורס על פי סטודנט 
                    Node<Course> courseHead = studentHead.GetValue().GetCourse();
                    while (courseHead != null)
                    {
                        //בדיקה האם הציון של הסטודנט הוא נכשל-אם כן נמנה את מספר הנכשלים שלו
                        if (courseHead.GetValue().GetMark() < FAIL_GRADE)
                        {
                            counter++;
                        }
                        //מעבר לקורס הבא
                        courseHead = courseHead.GetNext();
                    }
                    //אם סך הנכשלים של אותו סטודנט גדול יותר מסך הנכשלים הכיתתי-הוא זה שיוכנס למערך הנכשלים
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        failedArr[i] = new Student(studentHead.GetValue());
                    }
                    //מעבר לסטודנט הבא
                    studentHead = studentHead.GetNext();
                    //איפוס כמות נכשלים
                    counter = 0;
                }
                //איפוס מספר הנכשלים הכיתתי המקסימלי
                maxCounter = 0;

            }
            //החזרה של מערך הנכשלים לפי כיתות
            return failedArr;
        }

    }
}
