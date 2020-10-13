namespace FileSearcher
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_FolderName = new System.Windows.Forms.TextBox();
            this.txt_ResutBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_wordToSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_FolderName
            // 
            this.txt_FolderName.Location = new System.Drawing.Point(31, 27);
            this.txt_FolderName.Name = "txt_FolderName";
            this.txt_FolderName.Size = new System.Drawing.Size(716, 23);
            this.txt_FolderName.TabIndex = 1;
            this.txt_FolderName.Text = "C:\\Users\\f.freij\\Desktop\\SearcherProject\\Master";
            // 
            // txt_ResutBox
            // 
            this.txt_ResutBox.Location = new System.Drawing.Point(31, 116);
            this.txt_ResutBox.Multiline = true;
            this.txt_ResutBox.Name = "txt_ResutBox";
            this.txt_ResutBox.ReadOnly = true;
            this.txt_ResutBox.Size = new System.Drawing.Size(866, 378);
            this.txt_ResutBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Path";
            // 
            // txt_wordToSearch
            // 
            this.txt_wordToSearch.Location = new System.Drawing.Point(166, 56);
            this.txt_wordToSearch.Name = "txt_wordToSearch";
            this.txt_wordToSearch.Size = new System.Drawing.Size(581, 23);
            this.txt_wordToSearch.TabIndex = 1;
            this.txt_wordToSearch.Text = "hi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search word parameter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(753, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_wordToSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ResutBox);
            this.Controls.Add(this.txt_FolderName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search in files ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_FolderName;
        private System.Windows.Forms.TextBox txt_ResutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_wordToSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

