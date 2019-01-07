using System;

namespace Class_Student
{
  public class Student
  {
 public string FirstName;
 public string LastName;
  }
  class Program
  {   
   static Student[] Students;
   static void PrintStudent(Student student)
   {
  Console.WriteLine("{0,15}{1}{2}", student.FirstName, student.LastName);

   }
 
 static void Main(string[] args)
 {
   Students = new Student[2];
   Students[0] = new Student();
   Students[1] = new Student();
   
 }
  }
}
