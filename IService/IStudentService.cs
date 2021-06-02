using LearningGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningGraphQL.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
