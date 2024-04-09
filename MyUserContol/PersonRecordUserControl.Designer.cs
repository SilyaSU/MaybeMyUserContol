namespace MyUserContol
{
    partial class PersonRecordUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            PersonRecordID = new Label();
            IDTextBox = new TextBox();
            SecondNameTextBox = new TextBox();
            PersonRecordSecondName = new Label();
            NameTextBox = new TextBox();
            PersonRecordName = new Label();
            ThirdNameTextBox = new TextBox();
            PersonRecordThirdName = new Label();
            AgeTextBox = new TextBox();
            PersonRecordAge = new Label();
            ChangeButton = new Button();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // PersonRecordID
            // 
            PersonRecordID.AutoSize = true;
            PersonRecordID.Location = new Point(19, 13);
            PersonRecordID.Name = "PersonRecordID";
            PersonRecordID.Size = new Size(18, 15);
            PersonRecordID.TabIndex = 0;
            PersonRecordID.Text = "ID";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(19, 44);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(36, 23);
            IDTextBox.TabIndex = 1;
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Location = new Point(59, 44);
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.ReadOnly = true;
            SecondNameTextBox.Size = new Size(149, 23);
            SecondNameTextBox.TabIndex = 3;
            // 
            // PersonRecordSecondName
            // 
            PersonRecordSecondName.AutoSize = true;
            PersonRecordSecondName.Location = new Point(59, 13);
            PersonRecordSecondName.Name = "PersonRecordSecondName";
            PersonRecordSecondName.Size = new Size(58, 15);
            PersonRecordSecondName.TabIndex = 2;
            PersonRecordSecondName.Text = "Фамилия";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(214, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(136, 23);
            NameTextBox.TabIndex = 5;
            // 
            // PersonRecordName
            // 
            PersonRecordName.AutoSize = true;
            PersonRecordName.Location = new Point(214, 13);
            PersonRecordName.Name = "PersonRecordName";
            PersonRecordName.Size = new Size(31, 15);
            PersonRecordName.TabIndex = 4;
            PersonRecordName.Text = "Имя";
            // 
            // ThirdNameTextBox
            // 
            ThirdNameTextBox.Location = new Point(356, 44);
            ThirdNameTextBox.Name = "ThirdNameTextBox";
            ThirdNameTextBox.ReadOnly = true;
            ThirdNameTextBox.Size = new Size(142, 23);
            ThirdNameTextBox.TabIndex = 7;
            // 
            // PersonRecordThirdName
            // 
            PersonRecordThirdName.AutoSize = true;
            PersonRecordThirdName.Location = new Point(356, 13);
            PersonRecordThirdName.Name = "PersonRecordThirdName";
            PersonRecordThirdName.Size = new Size(58, 15);
            PersonRecordThirdName.TabIndex = 6;
            PersonRecordThirdName.Text = "Отчество";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(504, 44);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(47, 23);
            AgeTextBox.TabIndex = 9;
            // 
            // PersonRecordAge
            // 
            PersonRecordAge.AutoSize = true;
            PersonRecordAge.Location = new Point(504, 13);
            PersonRecordAge.Name = "PersonRecordAge";
            PersonRecordAge.Size = new Size(26, 15);
            PersonRecordAge.TabIndex = 8;
            PersonRecordAge.Text = "Лет";
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(564, 13);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(89, 23);
            ChangeButton.TabIndex = 10;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(564, 42);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(89, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // PersonRecordUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(ChangeButton);
            Controls.Add(AgeTextBox);
            Controls.Add(PersonRecordAge);
            Controls.Add(ThirdNameTextBox);
            Controls.Add(PersonRecordThirdName);
            Controls.Add(NameTextBox);
            Controls.Add(PersonRecordName);
            Controls.Add(SecondNameTextBox);
            Controls.Add(PersonRecordSecondName);
            Controls.Add(IDTextBox);
            Controls.Add(PersonRecordID);
            Name = "PersonRecordUserControl";
            Size = new Size(672, 87);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonRecordID;
        private TextBox IDTextBox;
        private TextBox SecondNameTextBox;
        private Label PersonRecordSecondName;
        private TextBox NameTextBox;
        private Label PersonRecordName;
        private TextBox ThirdNameTextBox;
        private Label PersonRecordThirdName;
        private TextBox AgeTextBox;
        private Label PersonRecordAge;
        private Button ChangeButton;
        private Button DeleteButton;
    }
}
