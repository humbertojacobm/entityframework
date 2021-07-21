using Microsoft.EntityFrameworkCore;
using System;

namespace NETCore3WebApp.Infrastructure.DB
{
    public interface IMyDbContext : IDisposable
    {
        int SaveChanges();
        DbSet<Domain.Entity> Entities { get; set; }
        DbSet<Domain.Course> Courses { get; set; }
        DbSet<Domain.Student> Students { get; set; }
        DbSet<Domain.Enrollment> Enrollments { get; set; }
    }
}
