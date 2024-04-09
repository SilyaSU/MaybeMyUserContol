namespace MyUserContol
{
    public partial class MyForm : Form
    {
        MyComponent mComponent;

        public MyForm()
        {
            InitializeComponent();

            mComponent = new MyComponent();
            mComponent.AttachLabel(timeLabel);
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void BtnShowDialog_Click(object sender, EventArgs e)
        {
            MyForm myForm = new MyForm();
            DialogResult result = myForm.ShowDialog();
            MessageBox.Show("Результат диалога: " + result.ToString());
            if (result == DialogResult.OK)
            {
                string password = myForm.Password;
                passwordTextBox.Password = password;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
