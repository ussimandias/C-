using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class ChallengeStudentCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                resultLabel.Text = "";
            }
        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ... 
             * make up the details). Each Course should have at least two 
             * students enrolled in them. Use Object and Collection Initializers.
             * Then, iterate through each Course and print out the Course's details
             * and the Students that are enrolled in each Course.
             */

            string result = "";

            List<Course> courses = new List<Course>()

            {
                new Course {
                    CourseId = 101,
                    Name ="Intro to Computers ",
                    Students = new List<StudentE>(){ new StudentE(){ StudentId = 1111, Name = "John Shcmoe"},
                                                    new StudentE(){ StudentId = 1112, Name = "Patrick Henson"},
                                                    new StudentE(){ StudentId = 1113, Name = "Hermanie Granger"},
                                                    new StudentE(){ StudentId = 1114, Name = "Patrick Henson"}
                    }
                },

            new Course {
                CourseId = 102,
                Name = "Machine Learning ",
                Students = new List<StudentE>() { new StudentE { StudentId = 1115, Name = "Neville Longbottom"},
                                                 new StudentE { StudentId = 1116, Name = "Arthur C Clarke"},
                                                 new StudentE { StudentId = 1117, Name = "Ron Weasly"}} },

            new Course {
                CourseId = 103,
                Name = "Database Structures",
                Students = new List<StudentE>() { new StudentE() {StudentId = 1118, Name = "Max Payne" },
                                                 new StudentE() {StudentId = 1119, Name = "Trevor Hoffman" },
                }
            },

            };

            foreach (Course course in courses)
            {
                result += string.Format("<br/>COURSE: {0} -- {1}", course.Name, course.CourseId.ToString());
                resultLabel.Text = result;

                foreach (var student in course.Students)
                {
                    result += string.Format("<br/>&nbsp;&nbsp;STUDENT:{0} -- {1}", student.StudentId, student.Name);
                    resultLabel.Text = result;
                }
            }

            //resultLabel.Text = result;
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a dictionary of Students (add three example students
             * ... make up the details). Use the student as the key. 
             * Each student must be enrolled in two Courses. Use Object and 
             * Collection Initializers. Then, Iterate through each student and 
             * print out to the web page each Student's info and the Courses the 
             * student is enrolled in.
             */

            Course course1 = new Course() { CourseId = 301, Name = "Statistics" };
            Course course2 = new Course() { CourseId = 302, Name = "Business Law" };

            Dictionary<int, StudentE> students = new Dictionary<int, StudentE>(){
                { 1, new StudentE { Name = "Belamy Jerome",
                                            StudentId = 2000,
                                            Courses = new List<Course>() { new Course() { CourseId = 301, Name = "Statistics "},
                                                                           new Course() { CourseId = 302, Name = "Business Law " },
                                                                           new Course() { CourseId = 303, Name = "African American History" }
                                            }
                }
                },

                { 2, new StudentE { Name = "Bart Fielch",
                                            StudentId = 2001,
                                            Courses = new List<Course>() { new Course() { CourseId = 301, Name = "Statistics "},
                                                                           new Course() { CourseId = 302, Name = "Business Law " },
                                                                           new Course() { CourseId = 303, Name = "African American History" }
                                            }
                }
                },

                { 3, new StudentE { Name = "Ronn Danne",
                                            StudentId = 2001,
                                            Courses = new List<Course>() { course1, course2 }
                                             //Courses = new List<Course>() { new Course() { CourseId = 301, Name = "Statistics "},
                                             //                              new Course() { CourseId = 302, Name = "Business Law " },
                                             //                              new Course() { CourseId = 303, Name = "African American History"}
                                             //}
                }
                }
            };

            foreach (var student in students)
            {
                resultLabel.Text += string.Format("<br/>Student: {0} - {1}", student.Value.StudentId, student.Value.Name);
                foreach (Course course in student.Value.Courses)
                {
                    resultLabel.Text += string.Format("<br/>&nbsp;&nbsp;Course: {0} - {1}", course.CourseId, course.Name);
                }
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * we need to Keep track of Students's grade (0 - 100) in a 
             * particular Course. This means at a minimum, you'll need to add
             * another class, and depending on your implementation, you will
             * probably need to modify the exiting classes to accomodate this 
             * requirement. Give each student a grade in each Course they are 
             * enrolled in (make up data). Then, for each student, print out 
             * each Course they are enrolled in and their grade.
             */

            StudentE student = new StudentE() { Name = "Pato Dos Santos", StudentId = 3333 };

            student.Enrollment = new List<Enrollment>() { new Enrollment { Grade = "B+", Course = new Course() { CourseId = 501, Name = "Psychology" } },
                                                          new Enrollment {Grade = "A+", Course =  new Course() { CourseId = 502, Name = "Visual Arts" } }
            };

            resultLabel.Text += string.Format("<br/>&nbsp;&nbspStudent ID: {0} -- Name: {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollment)
            {
                resultLabel.Text += string.Format("<br/>&nbsp;&nbsp;Enrolled In: {0} -- Grades: {1}", enrollment.Course.Name, enrollment.Grade);

            }
           
        }

    }

    public class StudentE
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Enrollment> Enrollment { get; set; }

    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<StudentE> Students { get; set; }
    }

    public class Enrollment
    {
        public Course Course { get; set; }
        public StudentE Student { get; set; }
        public string Grade { get; set; }

    }
}