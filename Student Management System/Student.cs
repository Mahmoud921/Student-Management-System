namespace Student_Management_System
{
    public class Student
    {
        int sid;
        public string Name {  get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public Student(int _sid, string _name,int _age)
        {
            SID = _sid;
            Name = _name;
            Age = _age;

        }
        public int SID
        {
            get => sid;
            set
            {
                if (value > 0)
                    sid = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, message: $"{nameof(SID)} must be > 0");
            }
        }

        public override string ToString()
        {
            return $"ID For {Name}: {SID} ";
        }
    }
}
