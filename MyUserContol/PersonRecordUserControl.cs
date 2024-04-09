namespace MyUserContol
{
    public partial class PersonRecordUserControl : UserControl
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }

        public PersonRecordUserControl()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            IDTextBox.Text = ID;
            NameTextBox.Text = FirstName;
            SecondNameTextBox.Text = LastName;
            ThirdNameTextBox.Text = MiddleName;
            AgeTextBox.Text = Age.ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            using (var editDialog = new PersonRecordEditDialog(ID, FirstName, LastName, MiddleName, Age))
            {
                if (editDialog.ShowDialog() == DialogResult.OK)
                {
                    int currentAge = Age;

                    ID = editDialog.ID;
                    FirstName = editDialog.FirstName;
                    LastName = editDialog.LastName;
                    MiddleName = editDialog.MiddleName;
                    Age = editDialog.Age;

                    UpdateData();

                    int ageDifference = Age - currentAge;

                    MainForm mainForm = this.ParentForm as MainForm;
                    if (mainForm != null)
                    {
                        mainForm.totalAge += ageDifference;
                        mainForm.SumAgeTextBox.Text = mainForm.totalAge.ToString();
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.totalRecords--;

                mainForm.AllRecordsTextBox.Text = mainForm.totalRecords.ToString();
            }


            if (int.TryParse(AgeTextBox.Text, out int age))
            {
                mainForm.totalAge -= age;

                mainForm.SumAgeTextBox.Text = mainForm.totalAge.ToString();
            }

            Parent.Controls.Remove(this);
            Dispose();
        }
    }
}
