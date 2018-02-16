namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void titleTimer_Tick(object sender, System.EventArgs e)
		{
			//if (titleLabel.Text == "WELCOME TO MY CLASS")
			//{
			//	titleLabel.Text = "I AM DARIUSH TASDIGHI";
			//	titleLabel.ForeColor = System.Drawing.Color.Blue;
			//}
			//else
			//{
			//	titleLabel.Text = "WELCOME TO MY CLASS";
			//	titleLabel.ForeColor = System.Drawing.Color.Black;
			//}

			// می‌کنیم یعنی بزرگ و کوچکی حروف مهم نیست true را ignoreCase وقتی
			if (string.Compare(titleLabel.Text, "WELCOME TO MY CLASS", ignoreCase: true) == 0)
			{
				titleLabel.Text = "I AM DARIUSH TASDIGHI";
				titleLabel.ForeColor = System.Drawing.Color.Blue;
			}
			else
			{
				titleLabel.Text = "WELCOME TO MY CLASS";
				titleLabel.ForeColor = System.Drawing.Color.Black;
			}
		}
	}
}
