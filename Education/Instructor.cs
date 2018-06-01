using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Instructor
	{
		public string Name { get; set; }
		public int ExperienceInYears { get; set; }
		public string PrimaryLanguage { get; set; } //CSharp or Java
		public string Email { get; set; }
		public string PhoneNumber { get; set; }

		public Assignment CreateAssignment(string name, string assignmentId) 
			//this will return a type of assignment
			//string name and string assignmentid are our parameters
		{ 
			Assignment asgn = new Assignment(); 
			asgn.Comments = null;
			asgn.Grade = null;
			asgn.Name = name;
			asgn.Assignmentid = assignmentId;
			return asgn;  //make sure to include return or else you'll get an error
		}
	}
}
