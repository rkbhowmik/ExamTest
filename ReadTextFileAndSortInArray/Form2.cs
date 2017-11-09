using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTextFileAndSortInArray
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int counter = 0;
				string line = "";
				StreamReader sr = new StreamReader(@"c:\users\studerande\desktop\test\sample.txt");
				List<int> list = new List<int>();
				while ((line = sr.ReadLine()) != null)
				{
					listBox1.Items.Add(line);
					list.Add(int.Parse(line));
					counter++;
				}
				int[] arr = list.ToArray();
				Array.Sort(arr);
				foreach (int item in arr)
				{
					listBox2.Items.Add(item);
				}
		}
	}
}


