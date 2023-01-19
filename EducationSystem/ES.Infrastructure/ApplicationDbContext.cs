using ES.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ES.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ProgramSchool> ProgramSchools { get; set; }
        public DbSet<ProgramEnrollment> ProgramEnrollments { get; set; }
        public DbSet<CourseEnrollmentHistory> CourseEnrollmentHistories { get; set; }
        public DbSet<InstructorCourseHistory> InstructorCourseHistories { get; set; }
        public DbSet<CoursePrerequisite> CoursePrerequisites { get; set; }
        public DbSet<StudentAdvisor> StudentAdvisors { get; set; }
        public DbSet<ProgramCourse> ProgramCourses { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<StudentAttendance> StudentAttendances { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}