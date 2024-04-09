namespace MyUserContol
{
    partial class PersonRecordEditDialog
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
            AgeTextBox = new TextBox();
            PersonRecordAge = new Label();
            NameTextBox = new TextBox();
            PersonRecordName = new Label();
            SecondNameTextBox = new TextBox();
            PersonRecordSecondName = new Label();
            IDTextBox = new TextBox();
            PersonRecordID = new Label();
            ThirdNameTextBox = new TextBox();
            PersonRecordThirdName = new Label();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(12, 286);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(58, 23);
            AgeTextBox.TabIndex = 19;
            // 
            // PersonRecordAge
            // 
            PersonRecordAge.AutoSize = true;
            PersonRecordAge.Location = new Point(12, 255);
            PersonRecordAge.Name = "PersonRecordAge";
            PersonRecordAge.Size = new Size(26, 15);
            PersonRecordAge.TabIndex = 18;
            PersonRecordAge.Text = "Лет";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 167);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(155, 23);
            NameTextBox.TabIndex = 15;
            // 
            // PersonRecordName
            // 
            PersonRecordName.AutoSize = true;
            PersonRecordName.Location = new Point(12, 136);
            PersonRecordName.Name = "PersonRecordName";
            PersonRecordName.Size = new Size(31, 15);
            PersonRecordName.TabIndex = 14;
            PersonRecordName.Text = "Имя";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Location = new Point(12, 104);
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(155, 23);
            SecondNameTextBox.TabIndex = 13;
            // 
            // PersonRecordSecondName
            // 
            PersonRecordSecondName.AutoSize = true;
            PersonRecordSecondName.Location = new Point(12, 73);
            PersonRecordSecondName.Name = "PersonRecordSecondName";
            PersonRecordSecondName.Size = new Size(58, 15);
            PersonRecordSecondName.TabIndex = 12;
            PersonRecordSecondName.Text = "Фамилия";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(12, 40);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(58, 23);
            IDTextBox.TabIndex = 11;
            // 
            // PersonRecordID
            // 
            PersonRecordID.AutoSize = true;
            PersonRecordID.Location = new Point(12, 9);
            PersonRecordID.Name = "PersonRecordID";
            PersonRecordID.Size = new Size(18, 15);
            PersonRecordID.TabIndex = 10;
            PersonRecordID.Text = "ID";
            // 
            // ThirdNameTextBox
            // 
            ThirdNameTextBox.Location = new Point(12, 229);
            ThirdNameTextBox.Name = "ThirdNameTextBox";
            ThirdNameTextBox.Size = new Size(155, 23);
            ThirdNameTextBox.TabIndex = 27;
            // 
            // PersonRecordThirdName
            // 
            PersonRecordThirdName.AutoSize = true;
            PersonRecordThirdName.Location = new Point(12, 198);
            PersonRecordThirdName.Name = "PersonRecordThirdName";
            PersonRecordThirdName.Size = new Size(58, 15);
            PersonRecordThirdName.TabIndex = 26;
            PersonRecordThirdName.Text = "Отчество";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 330);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(155, 34);
            SaveButton.TabIndex = 28;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // PersonRecordEditDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 401);
            Controls.Add(SaveButton);
            Controls.Add(ThirdNameTextBox);
            Controls.Add(PersonRecordThirdName);
            Controls.Add(AgeTextBox);
            Controls.Add(PersonRecordAge);
            Controls.Add(NameTextBox);
            Controls.Add(PersonRecordName);
            Controls.Add(SecondNameTextBox);
            Controls.Add(PersonRecordSecondName);
            Controls.Add(IDTextBox);
            Controls.Add(PersonRecordID);
            Name = "PersonRecordEditDialog";
            Text = "PersonRecordEditDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AgeTextBox;
        private Label PersonRecordAge;
        private TextBox NameTextBox;
        private Label PersonRecordName;
        private TextBox SecondNameTextBox;
        private Label PersonRecordSecondName;
        private TextBox IDTextBox;
        private Label PersonRecordID;
        private TextBox ThirdNameTextBox;
        private Label PersonRecordThirdName;
        private Button SaveButton;
    }
}