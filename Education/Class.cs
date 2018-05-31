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
		public string Language { get; set; }  //CSharp or Java
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; } //The first Instructor the type!
		public List<Student> Students = new List<Student>();  //This is a list - unlike an array, we don't have set a fixed amount of data sets

	}
}
