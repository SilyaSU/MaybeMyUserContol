namespace MyUserContol
{
    public partial class MainForm : Form
    {

        public int totalRecords = 0;
        public int totalAge = 0;

        public MainForm()
        {
            InitializeComponent();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PersonRecordUserControl person = new PersonRecordUserControl();

            flowLayoutPanel.Controls.Add(person);

            totalRecords++;

            AllRecordsTextBox.Text = totalRecords.ToString();
        }
    }
}
