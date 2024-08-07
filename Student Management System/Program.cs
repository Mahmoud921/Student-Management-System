using Student_Management_System;

internal class Program
{
     static void Main(string[] args)
    {
        var sms = new StMangeSys();
        Console.WriteLine("Welcome To Student Management System 👨‍💻 ");
        
        while (true) {
            Console.WriteLine("");
            Console.WriteLine(" (1) Add Student");
            Console.WriteLine(" (2) Update Student");
            Console.WriteLine(" (3) Delete Student");
            Console.WriteLine(" (4) Add Course");
            Console.WriteLine(" (5) Update Course");
            Console.WriteLine(" (6) Delete Course");
            Console.WriteLine(" (7) Number Of Student");
            Console.WriteLine(" (8) Exit");
            Console.WriteLine("");
            Console.Write("After Reading the menue please choice from (1  -  7): ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            switch (option)
            {
                case 1:
                    Console.Write("Enter id for student: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter name for student: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age for student: ");
                    int age = int.Parse(Console.ReadLine());
                    sms.addStudent(id, name, age);
                    break;
                case 2:
                    Console.Write("Enter id for student: ");
                    int uid = int.Parse(Console.ReadLine());
                    Console.Write("Enter name for student: ");
                    string uname = Console.ReadLine();
                    Console.Write("Enter age for student: ");
                    int uage = int.Parse(Console.ReadLine());
                    sms.updateStudent(uid, uname, uage);
                    break;
                case 3:
                    Console.Write("Please Enter id for student to delete it: ");
                    int did = int.Parse(Console.ReadLine());
                    sms.deleteStudent(did);
                    break;
                case 4:
                    Console.Write("Enter id for student to add it: ");
                    int sid = int.Parse(Console.ReadLine());
                    Console.Write("Enter Course Id for student to add it: ");
                    int cid = int.Parse(Console.ReadLine());
                    Console.Write("Enter Course Name for student to add it: ");
                    string cname = Console.ReadLine();
                    Console.Write("Enter Course Cridet Hours for student to add it: ");
                    int ccridets = int.Parse(Console.ReadLine());
                    sms.addCourse(sid,cid,cname,ccridets);
                    break;
                case 5:
                    Console.Write("Enter New id for student: ");
                    int usid = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Course Id for student: ");
                    int ucid = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Course Name for student: ");
                    string ucname = Console.ReadLine();
                    Console.Write("Enter New Cridet Hours: ");
                    int uccridets = int.Parse(Console.ReadLine());
                    sms.addCourse(usid, ucid, ucname, uccridets);
                    break;
                case 6:
                    Console.Write("Please Enter ID for student: ");
                    int dsid = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter Course Id for student: ");
                    int dcid = int.Parse(Console.ReadLine());
                    sms.removeCourse(dsid,dcid);
                    break;
                case 7:
                    sms.calcCourseAndCridets();

                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Please Try Again 🥲");
                    break;
            }
        }
    }
}
