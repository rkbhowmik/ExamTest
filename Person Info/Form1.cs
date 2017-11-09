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

namespace Person_Info
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}


		private void button1_Click(object sender, EventArgs e)
		{
			var name = txtName.Text;
			var mail = txtemail.Text;
			var phone = txtphone.Text.ToString();
			var birthday = int.Parse(dateTimePicker1.Value.ToString("yyyyMMdd"));
			var today = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
			var age = ((today - birthday) / 10000).ToString();
			var content = $"Name: {name}, Email: {mail}, Phone No. {phone}, {age} Years old";

			saveFileDialog1.ShowDialog();
			File.AppendAllText(saveFileDialog1.FileName, content + Environment.NewLine);
		}
	}
}
