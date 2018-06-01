using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Program
	{
		static void Main(string[] args)
		{
			Instructor danTheMan = new Instructor(); //this is an instance
			danTheMan.Name = "Dan";
			danTheMan.ExperienceInYears = 17;
			danTheMan.PrimaryLanguage = "CSharp";
			danTheMan.Email = "danTheMan@military.gov";
			danTheMan.PhoneNumber = "123-456-7890";
			
			Class dotnetbc4 = new Class();
			dotnetbc4.Capacity = 16;
			dotnetbc4.Code = "DN4";
			dotnetbc4.Language = "CSharpx";
			dotnetbc4.Name = "Dot Net Boot Camp 4";
			dotnetbc4.Instructor = danTheMan;

			Student foster = new Student();
			foster.Name = "Foster";
			foster.Absences = 0;
			foster.ContactInfo = "Call Foster...";
			foster.FirstJob = DateTime.MinValue; //FirstJob's data type is DateTime. Foster doesn't have a job yet. We can't put null.
			foster.Class = dotnetbc4;
			
			Student jj = new Student();
			jj.Name = "Jonathan";
			jj.Absences = 0;
			jj.ContactInfo = "Call Jon";
			jj.FirstJob = null;
			jj.Class = dotnetbc4;


			Student am = new Student();
			am.Name = "Anna";
			am.Absences = 0;
			am.ContactInfo = "Email Anna";
			am.FirstJob = null;
			am.Class = dotnetbc4;

			dotnetbc4.Students.Add(foster); //this is adding Foster to the list
			dotnetbc4.Students.Add(jj);

			Assignment asg1 = danTheMan.CreateAssignment("First Fundementals assignment", "Fundamentals 12");
			//This line is equivelant to the following:
			//Assignment asg1 = new Assignment();
			//asg1.Assignmentid = "Fundamentals 12";
			//asg1.Comments = null;
			//asg1.Grade = null;
			//asg1.Name = "First Fundementals assignment";

			dotnetbc4.DistributeAssignment(asg1);
			


		}
	}
}
