using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * \n to " "
 */

namespace ImportToMsSql
{
	public partial class Form1 : Form
	{
		private string _filePathAndNameRead = @"U:\dev\autoeval_20170601.csv";
		private string _filePathAndNameWrite = @"U:\dev\autoeval_20170601_output.csv";

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_readLine();
			// return;

			var engine = new FileHelperEngine<partial.Autoeval>();
			// To Read Use:
			var result = engine.ReadFile(_filePathAndNameRead);
			// result is now an array of Customer
			// To Write Use:
			engine.WriteFile(_filePathAndNameWrite, result);
		}

		private void _readAll()
		{
			var engine = new FileHelperEngine<partial.Autoeval>();

			// To Read Use:
			var result = engine.ReadFile(_filePathAndNameRead);

			// result is now an array of Customer

			// To Write Use:
			engine.WriteFile(_filePathAndNameWrite, result);
		}

		private void _readLine()
		{
			var engine = new FileHelperAsyncEngine<partial.Autoeval>();


			// object x = from t in engine; 
			List<partial.Autoeval> autoEvals = new List<partial.Autoeval>();
			// Read
			using (engine.BeginReadFile(_filePathAndNameRead))
			{
				int i = 0;
				// The engine is IEnumerable
				foreach (partial.Autoeval autoeval in engine)
				{
					autoEvals.Add(autoeval);
					// your code here

					//Console.WriteLine(i++);
					//Console.WriteLine(autoeval.ActnDt);
					//Console.WriteLine(autoeval.ActnRsn);
					//Console.WriteLine(autoeval.AdmTyp);
					//Console.WriteLine(autoeval.DOBirth);
					//Console.WriteLine(autoeval.First_Name);
					//Console.WriteLine(autoeval.Last_Name);
					//Console.WriteLine(autoeval.Prog);
					//Console.WriteLine(autoeval.ProgActn);
					//Console.WriteLine(autoeval.Student_Id);

					// Console.WriteLine(autoeval.);
				}
			}

			// Write
			/*
			using (engine.BeginWriteFile(_filePathAndNameWrite))
			{
				foreach (Autoeval autoeval in autoeval_list)
				{
					engine.WriteNext(autoeval);
				}
			}
			*/
		}
	}
}