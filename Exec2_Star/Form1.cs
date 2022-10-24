namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = string.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int? rows = checkint();

			if (rows.HasValue == false)
			{
				MessageBox.Show("叫块计");
				return;
			}

			if (rows.Value <= 0)
			{
				MessageBox.Show("计ぃ眔0");
				return;
			}

			//string stars = generatestar(rows.Value);
			//textBox2.Text = stars;
			//label2.Text = stars;
			Display(generatestar(rows.Value));
		}
		private int? checkint()
		{
			string input = UserInput.Text;
			bool isint = int.TryParse(input, out int rows);
			if (isint)
				return rows;
			else
				return null;
		}
		private string generatestar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			Success();
			return result;
		}
		private string generatestar2(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', rows - i) + new string('*', i) + "\r\n";
			}
			Success();
			return result;
		}
		private string generatestar3(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', rows - i) + new string('*', i) + new string('*', i - 1) + "\r\n";
			}
			Success();
			return result;
		}
		//private void button2_Click(object sender, EventArgs e)
		//{
		//	int? rows = checkint();

		//	if (rows.HasValue == false)
		//	{
		//		MessageBox.Show("叫块计");
		//		return;
		//	}

		//	if (rows.Value <= 0)
		//	{
		//		MessageBox.Show("计ぃ眔0");
		//		return;
		//	}

		//	//string stars = generatestar2(rows.Value);
		//	//textBox2.Text = stars;
		//	//label2.Text = stars;
		//	Display(generatestar2(rows.Value));
		//}

		private void button3_Click(object sender, EventArgs e)
		{
			int? rows = checkint();

			if (rows.HasValue == false)
			{
				MessageBox.Show("叫块计");
				return;
			}

			if (rows.Value <= 0)
			{
				MessageBox.Show("计ぃ眔0");
				return;
			}

			//string stars = generatestar3(rows.Value);
			//textBox2.Text = stars;
			//label2.Text = stars;
			Display(generatestar3(rows.Value));
		}
		private string Display(string star)
		{
			textBox2.Text = star;
			return textBox2.Text;
		}
		private void Success()
		{
			label1.Text = "锣传Θ";
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			int? rows = checkint();

			if (rows.HasValue == false)
			{
				MessageBox.Show("叫块计");
				return;
			}

			if (rows.Value <= 0)
			{
				MessageBox.Show("计ぃ眔0");
				return;
			}

			//string stars = generatestar2(rows.Value);
			//textBox2.Text = stars;
			//label2.Text = stars;
			Display(generatestar2(rows.Value));
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			int? rows = checkint();

			if (rows.HasValue == false)
			{
				MessageBox.Show("叫块计");
				return;
			}

			if (rows.Value <= 0)
			{
				MessageBox.Show("计ぃ眔0");
				return;
			}

			//string stars = generatestar3(rows.Value);
			//textBox2.Text = stars;
			//label2.Text = stars;
			Display(generatestar3(rows.Value));
		}
	}
}