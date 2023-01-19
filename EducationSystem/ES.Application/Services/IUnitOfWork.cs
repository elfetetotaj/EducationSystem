using ES.Application.Services.Interfaces;
using ES.Application.Services.Repository;
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
        IBirthplace Birthplace { get; }

    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IStudent Students { get; private set; }
        public ICourse Courses { get; private set; }
        public IInstructor Instructors { get; private set; }
        public IEnrollment Enrollments { get; private set; }
        public IDepartment Departments { get; private set; }
        public IProgramSchool ProgramsSchool { get; private set; }
        public IProgramEnrollment ProgramEnrollments { get; private set; }
        public ICourseEnrollmentHistory CourseEnrollmentHistories { get; private set; }
        public IInstructorCourseHistory InstructorCourseHistories { get; private set; }
        public ICoursePrerequisite CoursePrerequisites { get; private set; }
        public IStudentAdvisor StudentAdvisors { get; private set; }
        public IProgramCourse ProgramCourses { get; private set; }
        public IStudentGrade StudentGrades { get; private set; }
        public IStudentAttendance StudentAttendances { get; private set; }
        public ICourseSchedule CourseSchedules { get; private set; }
        public IBirthplace Birthplace { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Students = new StudentRepository(context);
            Courses = new CourseRepository(context);
            Instructors = new InstructorRepository(context);
            Birthplace = new BirthplaceRepository(context);
            //Enrollments = new EnrollmentRepository(context);
            //Departments = new DepartmentRepository(context);
            //ProgramsSchool = new ProgramSchoolRepository(context);
            //ProgramEnrollments = new ProgramEnrollmentRepository(context);
            //CourseEnrollmentHistories = new CourseEnrollmentHistoryRepository(context);
            //InstructorCourseHistories = new InstructorCourseHistoryRepository(context);
            //CoursePrerequisites = new CoursePrerequisiteRepository(context);
            //StudentAdvisors = new StudentAdvisorRepository(context);
            //ProgramCourses = new ProgramCourseRepository(context);
            //StudentGrades = new StudentGradeRepository(context);
            //StudentAttendances = new StudentAttendanceRepository(context);
            //CourseSchedules = new CourseScheduleRepository(context);

        }
    }
}
