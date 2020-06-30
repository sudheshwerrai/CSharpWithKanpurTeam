using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexerProperty
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int RolloNo { get; set; }
    }

    //StudentId=1,Name="Aakash"
    class School
    {
        List<Student> studentList;
        public School()
        {
            studentList = new List<Student>()
            {
                new Student(){StudentID=1,Name="Aakash",RolloNo=101 },
                new Student(){StudentID=2,Name="Sudhanshu",RolloNo=102 },
                new Student(){StudentID=3,Name="Bhavy",RolloNo=103 }
            };
        }

        //StudentId=1,Name="Aakash"
        public string this[int studentId]
        {
            get
            {
                return studentList.Where(sl => sl.StudentID == studentId).FirstOrDefault().Name;
            }
            set
            {
                studentList.Where(pl => pl.StudentID == studentId).FirstOrDefault().Name = value;
            }
        }

        static void Main()
        {
            School obj = new School();
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj[3]);

            obj[1] = "Abhishek";
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj[3]);


            Console.ReadKey();
        }
    }
}