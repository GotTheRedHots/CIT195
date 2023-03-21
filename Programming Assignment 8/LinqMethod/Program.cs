
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Program;

class Program
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public double Tuition { get; set; }
    }
    public class StudentClubs
    {
        public int StudentID { get; set; }
        public string ClubName { get; set; }
    }
    public class StudentGPA
    {
        public int StudentID { get; set; }
        public double GPA { get; set; }
    }
    public static void Main(string[] args)
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00} ,
                new Student() { StudentID = 1, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 } ,
                new Student() { StudentID = 2, StudentName = "Cookie Crumb",  Age = 21, Major="CIT", Tuition=2500.00 } ,
                new Student() { StudentID = 3, StudentName = "Ima Script",  Age = 48, Major="CIT", Tuition=5500.00 } ,
                new Student() { StudentID = 3, StudentName = "Cora Coder",  Age = 35, Major="CIT", Tuition=1500.00 } ,
                new Student() { StudentID = 4, StudentName = "Ura Goodchild" , Age = 40, Major="Marketing", Tuition=500.00} ,
                new Student() { StudentID = 5, StudentName = "Take Mewith" , Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
        };
        // Student GPA Collection
        IList<StudentGPA> studentGPAList = new List<StudentGPA>() {
                new StudentGPA() { StudentID = 1,  GPA=4.0} ,
                new StudentGPA() { StudentID = 2,  GPA=3.5} ,
                new StudentGPA() { StudentID = 3,  GPA=2.0 } ,
                new StudentGPA() { StudentID = 4,  GPA=1.5 } ,
                new StudentGPA() { StudentID = 5,  GPA=4.0 } ,
                new StudentGPA() { StudentID = 6,  GPA=2.5} ,
                new StudentGPA() { StudentID = 7,  GPA=1.0 }
            };
        // Club collection
        IList<StudentClubs> studentClubList = new List<StudentClubs>() {
            new StudentClubs() {StudentID=1, ClubName="Photography" },
            new StudentClubs() {StudentID=1, ClubName="Game" },
            new StudentClubs() {StudentID=2, ClubName="Game" },
            new StudentClubs() {StudentID=5, ClubName="Photography" },
            new StudentClubs() {StudentID=6, ClubName="Game" },
            new StudentClubs() {StudentID=7, ClubName="Photography" },
            new StudentClubs() {StudentID=3, ClubName="PTK" },
        };
        var gpaQuery = from StudentGPA in studentGPAList
                       group StudentGPA by StudentGPA.GPA;

        foreach (var gpaGroup in gpaQuery)
        {
            foreach (var studentGPA in gpaGroup)
            {
                Console.WriteLine($"{studentGPA.StudentID}");
            }
        }
        Console.WriteLine("-----------------------------------------------------");

        var clubQuery = from StudentClubs in studentClubList
                        group StudentClubs by StudentClubs.ClubName;

        foreach (var clubGroup in clubQuery)
        {
            foreach (var studentClubs in clubGroup)
            {
                Console.WriteLine($"{studentClubs.StudentID}");
            }
        }
        Console.WriteLine("-----------------------------------------------------");

        var passingGradeQuery = from StudentGPA in studentGPAList
                                where StudentGPA.GPA >= 2.5 && StudentGPA.GPA <= 4.0
                                select StudentGPA;

        Console.WriteLine($"{passingGradeQuery.Count()} students are passing with a 2.5 or higher.");
        Console.WriteLine("-----------------------------------------------------");


        var tuitionAvg = studentList.Average(s => s.Tuition);

        Console.WriteLine($"${tuitionAvg} is the average tuition.");
        Console.WriteLine("-----------------------------------------------------");

        var tuitionMax = studentList.Max(s => s.Tuition);

        foreach (var student in studentList)
        {
            if (student.Tuition == tuitionMax)
            {
                Console.WriteLine($"The student paying the highest tuition is: {student.StudentName}, majoring in {student.Major}, paying ${student.Tuition}.");
            }
            Console.WriteLine("-----------------------------------------------------");

            var gpaJoin = studentList.Join(studentGPAList,
                                    student => student.StudentID,
                                    gpa => gpa.StudentID,
                                    (student, gpa) => new
                                    {
                                        StudentName = student.StudentName,
                                        Major = student.Major,
                                        gpa = gpa.GPA
                                    });
            foreach (var s in gpaJoin)
            { Console.WriteLine($"Student name:{s.StudentName}, Student Major:{s.Major}, Student GPA:{s.gpa}"); }
            Console.WriteLine("-----------------------------------------------------");

            var clubs = from s in studentList
                              join c in studentClubList
                              on s.StudentID equals c.StudentID
                              where c.ClubName == "Game"
                              select new { s.StudentName, c.ClubName };
            foreach (var club in clubs)
            {
                Console.WriteLine($"Name: {club.StudentName} Club: {club.ClubName} ");
                Console.WriteLine();
            }
        }
    }
}

/*


b) Sort by Club, then group by Club and display the student's IDs

c) Count the number of students with a GPA between 2.5 and 4.0

d) Average all student's tuition

e) Find the student paying the most tuition and display their name, major and tuition. HINT: You will need to retrieve and store the highest tuition, then use a foreach loop to iterate through the studentList comparing each student's tuition to the highest. If they are equal, print out the data.

f) Join the student list and student GPA list on student ID and display the student's name, major and gpa

g) Join the student list and student club list. Display the names of only those students who are in the Game club.
*/