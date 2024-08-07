
namespace Student_Management_System
{
    public class Course
    {
        int courseId;
        public string CourseName { get; set; }
        public int Cridets { get; set; }

        
        public Course(int _courseId,string _courseName, int _cridets) {
            CourseId = _courseId;
            CourseName = _courseName;
            Cridets = _cridets;


        }
        public int CourseId
        {
            get => courseId;
            set
            {
                if (value > 0)
                    courseId = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, message: $"{nameof(CourseId)} must be > 0");
            }
        }


        public override string ToString()
        {
            return $"Course ID: {CourseId} and Course Name: {CourseName} and  Credits: {Cridets}";
        }

    }
}
