using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern._01_iterator
{
    class StudentList
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddStudent(Student addStudent)
        {
            Students.Add(addStudent);
        }

        public Student GetStudentAt(int num)
        {
            return Students.ElementAt(num);
        }

        public int GetLastNum()
        {
            return Students.Count;
        }
    }
}
