namespace Tester
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
            this.btnTest = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCreateXML = new System.Windows.Forms.Button();
            this.btnDumpToDatabase = new System.Windows.Forms.Button();
            this.btnDumpDataToDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(22, 64);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Go!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 105);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // btnCreateXML
            // 
            this.btnCreateXML.Location = new System.Drawing.Point(21, 12);
            this.btnCreateXML.Name = "btnCreateXML";
            this.btnCreateXML.Size = new System.Drawing.Size(75, 23);
            this.btnCreateXML.TabIndex = 2;
            this.btnCreateXML.Text = "Create XML";
            this.btnCreateXML.UseVisualStyleBackColor = true;
            this.btnCreateXML.Click += new System.EventHandler(this.btnCreateXML_Click);
            // 
            // btnDumpToDatabase
            // 
            this.btnDumpToDatabase.Location = new System.Drawing.Point(21, 121);
            this.btnDumpToDatabase.Name = "btnDumpToDatabase";
            this.btnDumpToDatabase.Size = new System.Drawing.Size(120, 23);
            this.btnDumpToDatabase.TabIndex = 3;
            this.btnDumpToDatabase.Text = "Create Db Schema";
            this.btnDumpToDatabase.UseVisualStyleBackColor = true;
            this.btnDumpToDatabase.Click += new System.EventHandler(this.btnCreateDatabaseSchema_Click);
            // 
            // btnDumpDataToDb
            // 
            this.btnDumpDataToDb.Location = new System.Drawing.Point(22, 176);
            this.btnDumpDataToDb.Name = "btnDumpDataToDb";
            this.btnDumpDataToDb.Size = new System.Drawing.Size(119, 23);
            this.btnDumpDataToDb.TabIndex = 4;
            this.btnDumpDataToDb.Text = "Dump Data to Db";
            this.btnDumpDataToDb.UseVisualStyleBackColor = true;
            this.btnDumpDataToDb.Click += new System.EventHandler(this.btnDumpDataToDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 211);
            this.Controls.Add(this.btnDumpDataToDb);
            this.Controls.Add(this.btnDumpToDatabase);
            this.Controls.Add(this.btnCreateXML);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCreateXML;
        private System.Windows.Forms.Button btnDumpToDatabase;
        private System.Windows.Forms.Button btnDumpDataToDb;
    }
}

