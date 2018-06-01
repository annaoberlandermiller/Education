using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Class
	{
		public string Name { get; set; }
		private string _Language;
		public string Language {
		get {
				return _Language;
			}
		set {
				if(value.ToUpper()=="CSHARP" || value.ToUpper()=="JAVA") { _Language = value; }
				}
			
	}
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; } 
		public List<Student> Students = new List<Student>();  //This is a list - unlike an array, we don't have set a fixed amount of data sets

		public void DistributeAssignment(Assignment assignment)
		{
			foreach(Student student in Students) {
				Assignment asgn = new Assignment(); //create a new instance of Assignment
				//This loop is giving each student a COPY of the assignment 
				//If we just gave them each the assignment, we wouldn't be able to give each student different grades - they'd overwrite eachother
				//They will all have the same value for now, since it hasn't been graded yet
				asgn.Assignmentid = assignment.Assignmentid;
				asgn.Comments = assignment.Comments;
				asgn.Grade = assignment.Grade;
				asgn.Name = assignment.Name;
				student.Assignments.Add(asgn);//This is assigning each student a copy so that we can assign individual grades 
			}
			try {   //Try Catch Loop
				int x = 0;
				int y = 1 / x;
			} catch (DivideByZeroException ex) {
				Console.WriteLine(ex.Message); //This tells the user that it tried to divide by zero. 
				Console.ReadLine();
			} catch(Exception ex) {
				throw ex; //this is saying if there's another exception besides divide by zero, let the program blow
			}

		}

	}
}
