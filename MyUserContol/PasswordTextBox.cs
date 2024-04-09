namespace MyUserContol
{
    public partial class PasswordTextBox : UserControl
    {
        private bool isPasswordHidden = true;

        public PasswordTextBox()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Password
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isPasswordHidden = !isPasswordHidden;
            if (isPasswordHidden)
            {
                textBox1.PasswordChar = '*';
            }
            else
            {
                textBox1.PasswordChar = '\0';
            }
        }



    }
}
