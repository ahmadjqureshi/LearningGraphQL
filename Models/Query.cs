﻿using LearningGraphQL.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningGraphQL.Models
{
    public class Query
    {
        IStudentService _studentService = null;

        public Query(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public List<Student> Students => _studentService.GetStudents();
    }
}
