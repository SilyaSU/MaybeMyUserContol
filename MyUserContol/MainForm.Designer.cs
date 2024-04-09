namespace MyUserContol
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            AllRecords = new Label();
            AgeSum = new Label();
            AllRecordsTextBox = new TextBox();
            SumAgeTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 35);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(140, 56);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(12, 110);
            flowLayoutPanel.MaximumSize = new Size(700, 330);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(699, 330);
            flowLayoutPanel.TabIndex = 1;
            flowLayoutPanel.WrapContents = false;
            // 
            // AllRecords
            // 
            AllRecords.AutoSize = true;
            AllRecords.Location = new Point(285, 20);
            AllRecords.Name = "AllRecords";
            AllRecords.Size = new Size(88, 15);
            AllRecords.TabIndex = 2;
            AllRecords.Text = "Всего записей:";
            // 
            // AgeSum
            // 
            AgeSum.AutoSize = true;
            AgeSum.Location = new Point(285, 76);
            AgeSum.Name = "AgeSum";
            AgeSum.Size = new Size(62, 15);
            AgeSum.TabIndex = 3;
            AgeSum.Text = "Всего лет:";
            // 
            // AllRecordsTextBox
            // 
            AllRecordsTextBox.Location = new Point(379, 12);
            AllRecordsTextBox.Name = "AllRecordsTextBox";
            AllRecordsTextBox.ReadOnly = true;
            AllRecordsTextBox.Size = new Size(100, 23);
            AllRecordsTextBox.TabIndex = 4;
            // 
            // SumAgeTextBox
            // 
            SumAgeTextBox.Location = new Point(353, 68);
            SumAgeTextBox.Name = "SumAgeTextBox";
            SumAgeTextBox.ReadOnly = true;
            SumAgeTextBox.Size = new Size(100, 23);
            SumAgeTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(SumAgeTextBox);
            Controls.Add(AllRecordsTextBox);
            Controls.Add(AgeSum);
            Controls.Add(AllRecords);
            Controls.Add(flowLayoutPanel);
            Controls.Add(AddButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private FlowLayoutPanel flowLayoutPanel;
        private Label AllRecords;
        private Label AgeSum;
        public TextBox AllRecordsTextBox;
        public TextBox SumAgeTextBox;
    }
}