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
				MessageBox.Show("�п�J�Ʀr");
				return;
			}

			if (rows.Value <= 0)
			{
				MessageBox.Show("�Ʀr���o�p��0");
				return;
			}
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
		private string Display(string star)
		{
			textBox2.Text = star;
			return textBox2.Text;
		}
		private void Success()
		{
			label1.Text = "�ഫ���\";
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			int? rows = checkint();

			if (rows.HasValue == false)
			{
				MessageBox.Show("�п�J�Ʀr");
				return;
			}

			if (rows.Value <= 0)
			{
				MessageBox.Show("�Ʀr���o�p��0");
				return;
			}
			Display(generatestar2(rows.Value));
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			int? rows = checkint();

			if (rows.HasValue == false)
			{
				MessageBox.Show("�п�J�Ʀr");
				return;
			}

			if (rows.Value <= 0)
			{
				MessageBox.Show("�Ʀr���o�p��0");
				return;
			}
			Display(generatestar3(rows.Value));
		}
	}
}