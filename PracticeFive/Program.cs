using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFive
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }
    class classroom
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student {StudentId = 1, StudentName = "Ali", ClassId = 1},
                new Student {StudentId = 2, StudentName = "Fatma", ClassId = 2},
                new Student {StudentId = 3, StudentName = "Mehmet", ClassId = 1},
                new Student {StudentId = 4, StudentName = "Zeynep", ClassId = 3},
                new Student {StudentId = 5, StudentName = "Ahmet", ClassId =2}
            };
            var classrooms = new List<classroom>
            {
                new classroom {ClassId = 1, ClassName = "Matematik"},
                new classroom {ClassId = 2, ClassName = "Türkçe"},
                new classroom {ClassId = 3, ClassName = "kimya"}
            };
            var studentClassrooms = classrooms.GroupJoin(students, c => c.ClassId, s => s.ClassId, (c, s) => new
            {
                ClassName = c.ClassName,
                Students = s.Select(st => st.StudentName)
            });
            foreach (var studentClassroom in studentClassrooms)
            {
                Console.WriteLine($"Sınıf Adı: {studentClassroom.ClassName}");
                foreach (var student in studentClassroom.Students)
                {
                    Console.WriteLine($"Öğrenci: {student}");
                }
            }
            Console.ReadKey();
        }
    }
}
