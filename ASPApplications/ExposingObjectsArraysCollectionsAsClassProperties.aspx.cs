using ASPApplications.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class ExposingObjectsArraysCollectionsAsClassProperties : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            Domain.Student student = setUpStudent();
            Domain.Course course = setUpCourse();

            student.Enrollments.Add(setupEnrollment(course));
            course.Students.Add(student);

            StringBuilder sb = new StringBuilder();
            sb.Append("<h3>Student Details</h3><p>Id: ");
            sb.Append(student.Id);
            sb.Append("<br/>Name: ");
            sb.Append(student.Name);
            sb.Append("<br/>Enrollment");
            foreach (var enrollment in student.Enrollments)
            {
                sb.Append("<br/>&nbsp;&nbsp");
                sb.Append(enrollment.Course.Title);
                sb.Append(" -- ");
                sb.Append(enrollment.GradePoint);
            }

            sb.Append("</p><h3>Courses</h3><p>Id: ");
            sb.Append(course.Id);
            sb.Append("<br/>Title: ");
            sb.Append(course.Title);
            sb.Append("<br/>Facility: ");
            sb.Append(course.Room.Building);
            sb.Append(" -- ");
            sb.Append(course.Room.RoomNumber);
            sb.Append("<br/>Students: ");
            foreach (Domain.Student studentInCourse in course.Students)
            {
                sb.Append("<br/>&nbsp;&nbsp");
                sb.Append(studentInCourse.Id);
                sb.Append(" -- ");
                sb.Append(studentInCourse.Name);
            }

            sb.Append("<br/>Times: ");
            foreach (Domain.Schedule schedule in course.Schedule)
            {
                sb.Append("<br/>&nbsp;&nbsp");
                sb.Append(schedule.DayOfTheWeek);
                sb.Append(" -- ");
                sb.Append(schedule.TimeBegin);
                sb.Append(" -- ( ");
                sb.Append(schedule.DurationInMinutes);
                sb.Append(" minutes) ");
            }

            sb.Append("</p>");
            resultLabel.Text = sb.ToString();
        }

        private Domain.Enrollment setupEnrollment(Domain.Course course)
        {
            Domain.Enrollment enrollment = new Domain.Enrollment();
            enrollment.Course = course;
            enrollment.GradePoint = 99;
            return enrollment;
        }

        private Domain.Course setUpCourse()
        {
            Domain.Course course = new Domain.Course();
            course.Students = new List<Domain.Student>();
            course.Id = 1;
            course.Room = setUpRoom();
            course.Title = ("C# 101");
            course.Schedule = setupSchedule();
            return course;
        }

        private Domain.Schedule[] setupSchedule()
        {
            Domain.Schedule[] schedule = new Domain.Schedule[3];

            Domain.Schedule schedule0 = new Domain.Schedule();
            schedule0.DayOfTheWeek = 2;
            schedule0.TimeBegin = 8;
            schedule0.DurationInMinutes = 90;

            Domain.Schedule schedule1 = new Domain.Schedule();
            schedule1.DayOfTheWeek = 4;
            schedule1.TimeBegin = 8;
            schedule1.DurationInMinutes = 90;

            Domain.Schedule schedule2 = new Domain.Schedule();
            schedule2.DayOfTheWeek = 6;
            schedule2.TimeBegin = 9;
            schedule2.DurationInMinutes = 60;

            schedule[0] = schedule0;
            schedule[1] = schedule1;
            schedule[2] = schedule2;

            return schedule;

        }

        private Domain.Room setUpRoom()
        {
            Domain.Room room = new Domain.Room();
            room.Building = "Emerging Technologies Building";
            room.RoomNumber = 404;
            return room;
        }

        private Domain.Student setUpStudent()
        {
            Domain.Student student = new Domain.Student();
            student.Id = 1;
            student.Name = "Uss Tarfa";
            student.Enrollments = new List<Domain.Enrollment>();
            return student;
        }
    }
}