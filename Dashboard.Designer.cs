
namespace DapperPractice
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.lastNameInsertText = new System.Windows.Forms.TextBox();
            this.firstNameInsertText = new System.Windows.Forms.TextBox();
            this.emailAddressInsertText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsertText = new System.Windows.Forms.TextBox();
            this.firstNameInsertLabel = new System.Windows.Forms.Label();
            this.LastNameInsertLabel = new System.Windows.Forms.Label();
            this.EmailAddressInsertLabel = new System.Windows.Forms.Label();
            this.PhoneNumberInsertLabel = new System.Windows.Forms.Label();
            this.InsertRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 15;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(38, 221);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(213, 169);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.AccessibleName = "LastNameTxt";
            this.LastNameTxt.Location = new System.Drawing.Point(127, 64);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(124, 23);
            this.LastNameTxt.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(58, 72);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(63, 121);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(152, 35);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lastNameInsertText
            // 
            this.lastNameInsertText.AccessibleName = "LastNameTxt";
            this.lastNameInsertText.Location = new System.Drawing.Point(555, 253);
            this.lastNameInsertText.Name = "lastNameInsertText";
            this.lastNameInsertText.Size = new System.Drawing.Size(185, 23);
            this.lastNameInsertText.TabIndex = 4;
            // 
            // firstNameInsertText
            // 
            this.firstNameInsertText.AccessibleName = "LastNameTxt";
            this.firstNameInsertText.Location = new System.Drawing.Point(555, 214);
            this.firstNameInsertText.Name = "firstNameInsertText";
            this.firstNameInsertText.Size = new System.Drawing.Size(185, 23);
            this.firstNameInsertText.TabIndex = 5;
            // 
            // emailAddressInsertText
            // 
            this.emailAddressInsertText.AccessibleName = "LastNameTxt";
            this.emailAddressInsertText.Location = new System.Drawing.Point(555, 296);
            this.emailAddressInsertText.Name = "emailAddressInsertText";
            this.emailAddressInsertText.Size = new System.Drawing.Size(185, 23);
            this.emailAddressInsertText.TabIndex = 6;
            // 
            // phoneNumberInsertText
            // 
            this.phoneNumberInsertText.AccessibleName = "LastNameTxt";
            this.phoneNumberInsertText.Location = new System.Drawing.Point(555, 334);
            this.phoneNumberInsertText.Name = "phoneNumberInsertText";
            this.phoneNumberInsertText.Size = new System.Drawing.Size(185, 23);
            this.phoneNumberInsertText.TabIndex = 7;
            // 
            // firstNameInsertLabel
            // 
            this.firstNameInsertLabel.AutoSize = true;
            this.firstNameInsertLabel.Location = new System.Drawing.Point(460, 221);
            this.firstNameInsertLabel.Name = "firstNameInsertLabel";
            this.firstNameInsertLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameInsertLabel.TabIndex = 8;
            this.firstNameInsertLabel.Text = "First Name";
            // 
            // LastNameInsertLabel
            // 
            this.LastNameInsertLabel.AutoSize = true;
            this.LastNameInsertLabel.Location = new System.Drawing.Point(460, 261);
            this.LastNameInsertLabel.Name = "LastNameInsertLabel";
            this.LastNameInsertLabel.Size = new System.Drawing.Size(63, 15);
            this.LastNameInsertLabel.TabIndex = 9;
            this.LastNameInsertLabel.Text = "Last Name";
            // 
            // EmailAddressInsertLabel
            // 
            this.EmailAddressInsertLabel.AutoSize = true;
            this.EmailAddressInsertLabel.Location = new System.Drawing.Point(460, 304);
            this.EmailAddressInsertLabel.Name = "EmailAddressInsertLabel";
            this.EmailAddressInsertLabel.Size = new System.Drawing.Size(81, 15);
            this.EmailAddressInsertLabel.TabIndex = 10;
            this.EmailAddressInsertLabel.Text = "Email Address";
            // 
            // PhoneNumberInsertLabel
            // 
            this.PhoneNumberInsertLabel.AutoSize = true;
            this.PhoneNumberInsertLabel.Location = new System.Drawing.Point(460, 337);
            this.PhoneNumberInsertLabel.Name = "PhoneNumberInsertLabel";
            this.PhoneNumberInsertLabel.Size = new System.Drawing.Size(88, 15);
            this.PhoneNumberInsertLabel.TabIndex = 11;
            this.PhoneNumberInsertLabel.Text = "Phone Number";
            // 
            // InsertRecord
            // 
            this.InsertRecord.Location = new System.Drawing.Point(460, 378);
            this.InsertRecord.Name = "InsertRecord";
            this.InsertRecord.Size = new System.Drawing.Size(279, 43);
            this.InsertRecord.TabIndex = 12;
            this.InsertRecord.Text = "Insert";
            this.InsertRecord.UseVisualStyleBackColor = true;
            this.InsertRecord.Click += new System.EventHandler(this.insertRecord_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertRecord);
            this.Controls.Add(this.PhoneNumberInsertLabel);
            this.Controls.Add(this.EmailAddressInsertLabel);
            this.Controls.Add(this.LastNameInsertLabel);
            this.Controls.Add(this.firstNameInsertLabel);
            this.Controls.Add(this.phoneNumberInsertText);
            this.Controls.Add(this.emailAddressInsertText);
            this.Controls.Add(this.firstNameInsertText);
            this.Controls.Add(this.lastNameInsertText);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Name = "Dashboard";
            this.Text = "FormUI";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox lastNameInsertText;
        private System.Windows.Forms.TextBox firstNameInsertText;
        private System.Windows.Forms.TextBox emailAddressInsertText;
        private System.Windows.Forms.TextBox phoneNumberInsertText;
        private System.Windows.Forms.Label firstNameInsertLabel;
        private System.Windows.Forms.Label LastNameInsertLabel;
        private System.Windows.Forms.Label EmailAddressInsertLabel;
        private System.Windows.Forms.Label PhoneNumberInsertLabel;
        private System.Windows.Forms.Label PhoneInsertLabel;
        private System.Windows.Forms.Button InsertRecord;
    }
}

