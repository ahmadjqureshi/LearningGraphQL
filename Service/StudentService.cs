using LearningGraphQL.IService;
using LearningGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningGraphQL.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            for (int i = 0 ; i < 100; i++)
            {
                students.Add(
                    new Student
                    {
                        StudentId = i + 1,
                        RollNumber = 1000 + i + 1,
                        StudentName = $"StudentName {i + 1}"
                    }
                    ) ;
            }

            return students;
        }
    }
}
