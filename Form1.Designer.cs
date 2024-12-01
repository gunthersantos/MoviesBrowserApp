namespace MovieAPI
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.WatchListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchTextBox.Location = new System.Drawing.Point(124, 117);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(322, 45);
            this.SearchTextBox.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search_btn.Location = new System.Drawing.Point(124, 200);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(162, 48);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add_btn.Location = new System.Drawing.Point(930, 261);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(275, 135);
            this.Add_btn.TabIndex = 7;
            this.Add_btn.Text = "Add to Watch List";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // MovieListBox
            // 
            this.MovieListBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieListBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 37;
            this.MovieListBox.Location = new System.Drawing.Point(124, 261);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(322, 337);
            this.MovieListBox.TabIndex = 8;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // WatchListBox
            // 
            this.WatchListBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchListBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.WatchListBox.FormattingEnabled = true;
            this.WatchListBox.ItemHeight = 37;
            this.WatchListBox.Location = new System.Drawing.Point(595, 261);
            this.WatchListBox.Name = "WatchListBox";
            this.WatchListBox.Size = new System.Drawing.Size(286, 337);
            this.WatchListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1476, 810);
            this.Controls.Add(this.WatchListBox);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.ListBox WatchListBox;
    }
}

