using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportToMsSql.partial
{
	[DelimitedRecord(",")]
	public partial class Autoeval
	{
		public string Student_Id;
		public string Last_Name;

		public string First_Name;
		public string DOBirth;
		public string AdmTyp;
		public string Prog;
		public string ProgActn;
		public string ActnRsn;
		public string ActnDt;
	}
}