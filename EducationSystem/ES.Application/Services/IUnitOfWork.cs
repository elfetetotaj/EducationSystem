using ES.Application.Services.Interfaces;
using ES.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Application.Services
{
    public interface IUnitOfWork
    {
        IStudent Students { get; }
        ICourse Courses { get; }
        IInstructor Instructors { get; }
        IEnrollment Enrollments { get; }
        IDepartment Departments { get; }
        IProgramSchool ProgramsSchool { get; }
        IProgramEnrollment ProgramEnrollments { get; }
        ICourseEnrollmentHistory CourseEnrollmentHistories { get; }
        IInstructorCourseHistory InstructorCourseHistories { get; }
        ICoursePrerequisite CoursePrerequisites { get; }
        IStudentAdvisor StudentAdvisors { get; }
        IProgramCourse ProgramCourses { get; }
        IStudentGrade StudentGrades { get; }
        IStudentAttendance StudentAttendances { get; }
        ICourseSchedule CourseSchedules { get; }

        Task SaveAsync();
    }

    public class UnitOfWork /*: IUnitOfWork*/
    {
        private readonly ApplicationDbContext _context;
        private IStudent _students;
        private ICourse _courses;
        private IInstructor _instructors;
        private IEnrollment _enrollments;
        private IDepartment _departments;
        private IProgramSchool _programsschool;
        private IProgramEnrollment _programEnrollments;
        private ICourseEnrollmentHistory _courseEnrollmentHistories;
        private IInstructorCourseHistory _instructorCourseHistories;
        private ICoursePrerequisite _coursePrerequisites;
        private IStudentAdvisor _studentAdvisors;
        private IProgramCourse _programCourses;
        private IStudentGrade _studentGrades;
        private IStudentAttendance _studentAttendances;
        private ICourseSchedule _courseSchedules;

    }

    //public class UnitOfWork : IUnitOfWork, IDisposable
    //{
    //    private readonly ApplicationDbContext _context;
    //    private readonly ILogger _logger;

    //    public IStudent Student { get; private set; }

    //    public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
    //    {
    //        _context = context;
    //        _logger = loggerFactory.CreateLogger("logs");

    //        Users = new UserRepository(context, _logger);
    //    }

    //    public async Task CompleteAsync()
    //    {
    //        await _context.SaveChangesAsync();
    //    }

    //    public void Dispose()
    //    {
    //        _context.Dispose();
    //    }
    //}

    //public async Task SaveAsync()
    //{
    //    await _context.SaveChangesAsync();
    //}
}
