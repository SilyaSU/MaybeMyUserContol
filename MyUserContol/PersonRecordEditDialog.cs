namespace MyUserContol
{
    public partial class PersonRecordEditDialog : Form
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }

        public PersonRecordEditDialog(string id, string firstName, string lastName, string middleName, int age)
        {
            InitializeComponent();
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Age = age;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ID = IDTextBox.Text;
            FirstName = NameTextBox.Text;
            LastName = SecondNameTextBox.Text;
            MiddleName = ThirdNameTextBox.Text;
            Age = int.Parse(AgeTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
