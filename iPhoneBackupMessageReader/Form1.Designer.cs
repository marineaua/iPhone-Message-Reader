namespace iPhoneBackupMessageReader
{
    partial class Form1
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
            this.btnDatabaseFileImport = new System.Windows.Forms.Button();
            this.btnConnectToDatabase = new System.Windows.Forms.Button();
            this.btnCloseConnection = new System.Windows.Forms.Button();
            this.textAreaMessages = new System.Windows.Forms.RichTextBox();
            this.btnShowMessages = new System.Windows.Forms.Button();
            this.btnFillContacts = new System.Windows.Forms.Button();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDatabaseFileImport
            // 
            this.btnDatabaseFileImport.Location = new System.Drawing.Point(12, 347);
            this.btnDatabaseFileImport.Name = "btnDatabaseFileImport";
            this.btnDatabaseFileImport.Size = new System.Drawing.Size(75, 23);
            this.btnDatabaseFileImport.TabIndex = 0;
            this.btnDatabaseFileImport.Text = "Import";
            this.btnDatabaseFileImport.UseVisualStyleBackColor = true;
            this.btnDatabaseFileImport.Click += new System.EventHandler(this.importData_Click);
            // 
            // btnConnectToDatabase
            // 
            this.btnConnectToDatabase.Location = new System.Drawing.Point(93, 347);
            this.btnConnectToDatabase.Name = "btnConnectToDatabase";
            this.btnConnectToDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnConnectToDatabase.TabIndex = 1;
            this.btnConnectToDatabase.Text = "Connect";
            this.btnConnectToDatabase.UseVisualStyleBackColor = true;
            this.btnConnectToDatabase.Click += new System.EventHandler(this.btnConnectToDatabase_Click);
            // 
            // btnCloseConnection
            // 
            this.btnCloseConnection.Location = new System.Drawing.Point(174, 347);
            this.btnCloseConnection.Name = "btnCloseConnection";
            this.btnCloseConnection.Size = new System.Drawing.Size(75, 23);
            this.btnCloseConnection.TabIndex = 2;
            this.btnCloseConnection.Text = "Close";
            this.btnCloseConnection.UseVisualStyleBackColor = true;
            this.btnCloseConnection.Click += new System.EventHandler(this.btnCloseConnection_Click);
            // 
            // textAreaMessages
            // 
            this.textAreaMessages.Location = new System.Drawing.Point(236, 12);
            this.textAreaMessages.Name = "textAreaMessages";
            this.textAreaMessages.Size = new System.Drawing.Size(527, 281);
            this.textAreaMessages.TabIndex = 3;
            this.textAreaMessages.Text = "";
            // 
            // btnShowMessages
            // 
            this.btnShowMessages.Location = new System.Drawing.Point(688, 347);
            this.btnShowMessages.Name = "btnShowMessages";
            this.btnShowMessages.Size = new System.Drawing.Size(75, 23);
            this.btnShowMessages.TabIndex = 4;
            this.btnShowMessages.Text = "Show";
            this.btnShowMessages.UseVisualStyleBackColor = true;
            this.btnShowMessages.Click += new System.EventHandler(this.btnShowMessages_Click);
            // 
            // btnFillContacts
            // 
            this.btnFillContacts.Location = new System.Drawing.Point(255, 347);
            this.btnFillContacts.Name = "btnFillContacts";
            this.btnFillContacts.Size = new System.Drawing.Size(75, 23);
            this.btnFillContacts.TabIndex = 5;
            this.btnFillContacts.Text = "Fill";
            this.btnFillContacts.UseVisualStyleBackColor = true;
            this.btnFillContacts.Click += new System.EventHandler(this.btnFillContacts_Click);
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(12, 12);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(218, 277);
            this.listBoxContacts.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 382);
            this.Controls.Add(this.listBoxContacts);
            this.Controls.Add(this.btnFillContacts);
            this.Controls.Add(this.btnShowMessages);
            this.Controls.Add(this.textAreaMessages);
            this.Controls.Add(this.btnCloseConnection);
            this.Controls.Add(this.btnConnectToDatabase);
            this.Controls.Add(this.btnDatabaseFileImport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatabaseFileImport;
        private System.Windows.Forms.Button btnConnectToDatabase;
        private System.Windows.Forms.Button btnCloseConnection;
        private System.Windows.Forms.RichTextBox textAreaMessages;
        private System.Windows.Forms.Button btnShowMessages;
        private System.Windows.Forms.Button btnFillContacts;
        private System.Windows.Forms.ListBox listBoxContacts;
    }
}

