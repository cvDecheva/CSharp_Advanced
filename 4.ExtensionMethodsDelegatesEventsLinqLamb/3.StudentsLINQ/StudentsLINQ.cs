using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.StudentsLINQ
{
    public class StudentsLINQ
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student{FirstName = "cvetelina", LastName = "decheva" , Age = 22, FacultyNumber = "123" , Email = "cvetelina@abv.bg", Marks = new List<int>{ 1,2},Phone = "232" },
                new Student{FirstName = "neli", LastName = "decheva" , Age = 45, FacultyNumber = "343532" , Email = "ghnfgh@abcv.bg", Marks = new List<int>{5,3,2},Phone = "4654654" },
                new Student{FirstName = "neli", LastName = "avanov" , Age = 12, FacultyNumber = "434" , Email = "hhh@abv.bg", Marks = new List<int>{ 1,2},Phone = "24564" },
                new Student{FirstName = "denislav", LastName = "decheva" , Age = 54, FacultyNumber = "1234523" , Email = "a@abcv.bg", Marks = new List<int>{ 6,6,6,6},Phone = "66664" },
            };

            Print(AlphabeticalName(students));
            Print(FirstAndlast(students));
            Print(Asceding(students));
            Print(WhereEmail(students));
            Print(TwoMarks(students));
            Console.Read();
        }

        public static void Print(IEnumerable<Student> students)
        {
            Console.WriteLine(new String('-',20));
            foreach (var item in students)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }

        public static IEnumerable<Student> AlphabeticalName(List<Student> students)
        {
            return from student in students
                   where student.FirstName[0].CompareTo(student.LastName[0]) < 0
                   select student;
        }

        public static IEnumerable<Student> FirstAndlast(List<Student> students)
        {
            List<Student> firstLast = new List<Student>();
            firstLast.Add(students
               .Where(s => s.Age > 18 && s.Age < 50)
               .FirstOrDefault());
            firstLast.Add(students
              .Where(s => s.Age > 18 && s.Age < 50)
              .LastOrDefault());
            return firstLast;
        }

        public static IEnumerable<Student> Asceding(List<Student> students)
        {
            return students
                .OrderBy(s => s.FirstName)
                .ThenBy(s => s.LastName);
        }

        public static IEnumerable<Student> WhereEmail(List<Student> students)
        {
            return students
                .Where(s => s.Email.Contains("@abv."));
        }

        public static IEnumerable<Student> TwoMarks(List<Student> students)
        {
            return students
                .Where(s => s.Marks.Count == 2);
        }


        //public static IEnumerable Anonymous(List<Student> students)
        //{
        //    return from student in students
        //           where student.Marks.Contains(6)
        //           select new { fullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
        //}
    }
}
