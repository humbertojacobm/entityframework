using Microsoft.EntityFrameworkCore;
using NETCore3WebApp.Infrastructure.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETCore3WebApp.Business
{
    public class CourseManager : ICourseManager
    {
        private readonly IDbContextGenerator _contextGenerator;
        public CourseManager(IDbContextGenerator contextGenerator)
        {
            _contextGenerator = contextGenerator;
        }

        public Domain.Course GetCourse(int id)
        {
            return _contextGenerator.GenerateMyDbContext().Courses
                .Include(c => c.Enrollments)
                .AsNoTracking()
                .FirstOrDefault(course => course.CourseId == id)
                ;
        }
    }
}