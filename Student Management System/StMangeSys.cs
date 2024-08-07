
namespace Student_Management_System
{
    public class StMangeSys
    {
        List<Student> student = new List<Student>();
        
        public void addStudent(int id,string name,int age)
        {
            var st = new Student(id,name,age);
            student.Add(st);
            Console.WriteLine("Student Added Successfully ❤️");

        }
        public void updateStudent(int id, string name, int age)
        {
            int position = student.FindIndex(s => s.SID ==id);
            
            if (position != -1)
            {
                student[position].Name = name;
                student[position].Age = age;
                Console.WriteLine("Student Updated Successfully ❤️");
            }
            else
            {
                Console.WriteLine("Student not Found Sir 🥲");
            }


        }
        public void deleteStudent(int id) { 
            int position = student.FindIndex(s =>s.SID ==id);
            if (position != -1)
            {
                student.RemoveAt(position);
                Console.WriteLine("Student Removed Successfully ❤️");
            }
            else
            {
                Console.WriteLine("Student not Found Sir 🥲");
            }

        }
        public void addCourse(int studentId,int courseID, string courseName, int cridets) {
            int position = student.FindIndex( s => s.SID==studentId);
            if (position != -1) {
                var c = new Course(courseID, courseName, cridets);
                student[position].Courses.Add(c);
                Console.WriteLine($"Course {c.CourseName} Added Successfully ❤️");
            }
            else
            {
                Console.WriteLine("Student not Found Sir 🥲");
            }
        }
        public void updateCourse(int studentId, int courseID, string courseName, int cridets) {
            int position = student.FindIndex(s => s.SID == studentId);
            if (position != -1)
            {
                int positionCourse = student[position].Courses.FindIndex(c =>c.CourseId == courseID);
                if (positionCourse != -1)
                {
                    
                    student[position].Courses[positionCourse].CourseName = courseName;
                    student[position].Courses[positionCourse].Cridets = cridets;
                    Console.WriteLine("Course Updated Successfully ❤️");

                }
                else
                {
                    Console.WriteLine("Course not Found Sir 🥲");
                }
            }
            else
            {
                Console.WriteLine("Student not Found Sir 🥲");
            }

        }
        public void removeCourse(int studentId, int courseID)
        {
            int position = student.FindIndex(s => s.SID == studentId);
            if (position != -1)
            {
                int positionCourse = student[position].Courses.FindIndex(c => c.CourseId == courseID);
                if (positionCourse != -1) {

                    student[position].Courses.RemoveAt(positionCourse);

                }
                else
                {
                    Console.WriteLine("Course removed Successfully ❤️");
                }


            }
            else
            {
                Console.WriteLine("Student not Found Sir 🥲");
            }
        }
        public void calcCourseAndCridets()
        {
            if (student.Count == 0)
            {
                Console.WriteLine("There are no students in the system 😭");
            }
            else
            {
                Console.WriteLine("Student List:");
                Console.WriteLine("");
                foreach (var st in student)
                {
                    int sum = 0;
                    Console.WriteLine(st);
                    Console.WriteLine("");
                    foreach (var course in st.Courses)
                    {
                        Console.WriteLine(course);
                        sum += course.Cridets;
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"The Total Cridets Hours: {sum}⏳ ");
                    Console.WriteLine("");
                }


            }
        }

        
    }
}
