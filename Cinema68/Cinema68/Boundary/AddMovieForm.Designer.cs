namespace Cinema68.Boundary
{
    partial class AddMovieForm
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
            this.HeaderAddMovie = new System.Windows.Forms.Label();
            this.TitleField = new System.Windows.Forms.RichTextBox();
            this.GenreField = new System.Windows.Forms.TextBox();
            this.ReleaseDateField = new System.Windows.Forms.DateTimePicker();
            this.HrsField = new System.Windows.Forms.NumericUpDown();
            this.MinsField = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.DirectorField = new System.Windows.Forms.TextBox();
            this.TimesList = new System.Windows.Forms.ListBox();
            this.ScheduleDateField = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MoviePosterBox = new System.Windows.Forms.PictureBox();
            this.UploadPosterButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.HrsLabel = new System.Windows.Forms.Label();
            this.MinsLabel = new System.Windows.Forms.Label();
            this.SecLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.SynopsisLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RatingField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HrsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderAddMovie
            // 
            this.HeaderAddMovie.AutoSize = true;
            this.HeaderAddMovie.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderAddMovie.Location = new System.Drawing.Point(11, 11);
            this.HeaderAddMovie.Name = "HeaderAddMovie";
            this.HeaderAddMovie.Size = new System.Drawing.Size(290, 27);
            this.HeaderAddMovie.TabIndex = 0;
            this.HeaderAddMovie.Text = "Please enter movie details";
            // 
            // TitleField
            // 
            this.TitleField.Location = new System.Drawing.Point(77, 66);
            this.TitleField.MaxLength = 50;
            this.TitleField.Name = "TitleField";
            this.TitleField.Size = new System.Drawing.Size(263, 26);
            this.TitleField.TabIndex = 1;
            this.TitleField.Text = "";
            this.TitleField.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // GenreField
            // 
            this.GenreField.Location = new System.Drawing.Point(222, 122);
            this.GenreField.Name = "GenreField";
            this.GenreField.Size = new System.Drawing.Size(118, 22);
            this.GenreField.TabIndex = 3;
            this.GenreField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ReleaseDateField
            // 
            this.ReleaseDateField.Location = new System.Drawing.Point(77, 174);
            this.ReleaseDateField.Name = "ReleaseDateField";
            this.ReleaseDateField.Size = new System.Drawing.Size(263, 22);
            this.ReleaseDateField.TabIndex = 4;
            // 
            // HrsField
            // 
            this.HrsField.Location = new System.Drawing.Point(77, 234);
            this.HrsField.Name = "HrsField";
            this.HrsField.Size = new System.Drawing.Size(66, 22);
            this.HrsField.TabIndex = 5;
            this.HrsField.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // MinsField
            // 
            this.MinsField.Location = new System.Drawing.Point(174, 234);
            this.MinsField.Name = "MinsField";
            this.MinsField.Size = new System.Drawing.Size(68, 22);
            this.MinsField.TabIndex = 6;
            this.MinsField.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(289, 234);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown4.TabIndex = 7;
            // 
            // DirectorField
            // 
            this.DirectorField.Location = new System.Drawing.Point(77, 284);
            this.DirectorField.Name = "DirectorField";
            this.DirectorField.Size = new System.Drawing.Size(195, 22);
            this.DirectorField.TabIndex = 8;
            // 
            // TimesList
            // 
            this.TimesList.FormattingEnabled = true;
            this.TimesList.ItemHeight = 16;
            this.TimesList.Location = new System.Drawing.Point(260, 332);
            this.TimesList.Name = "TimesList";
            this.TimesList.Size = new System.Drawing.Size(109, 84);
            this.TimesList.TabIndex = 9;
            this.TimesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ScheduleDateField
            // 
            this.ScheduleDateField.Location = new System.Drawing.Point(16, 332);
            this.ScheduleDateField.Name = "ScheduleDateField";
            this.ScheduleDateField.Size = new System.Drawing.Size(226, 22);
            this.ScheduleDateField.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(401, 66);
            this.richTextBox1.MaxLength = 150;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 142);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // MoviePosterBox
            // 
            this.MoviePosterBox.Location = new System.Drawing.Point(521, 234);
            this.MoviePosterBox.Name = "MoviePosterBox";
            this.MoviePosterBox.Size = new System.Drawing.Size(133, 112);
            this.MoviePosterBox.TabIndex = 12;
            this.MoviePosterBox.TabStop = false;
            // 
            // UploadPosterButton
            // 
            this.UploadPosterButton.Location = new System.Drawing.Point(521, 364);
            this.UploadPosterButton.Name = "UploadPosterButton";
            this.UploadPosterButton.Size = new System.Drawing.Size(133, 23);
            this.UploadPosterButton.TabIndex = 13;
            this.UploadPosterButton.Text = "Upload Photo";
            this.UploadPosterButton.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(74, 47);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 16);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Title";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(74, 103);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(46, 16);
            this.RatingLabel.TabIndex = 15;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(219, 103);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(44, 16);
            this.GenreLabel.TabIndex = 16;
            this.GenreLabel.Text = "Genre";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(74, 215);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(57, 16);
            this.DurationLabel.TabIndex = 17;
            this.DurationLabel.Text = "Duration";
            // 
            // HrsLabel
            // 
            this.HrsLabel.AutoSize = true;
            this.HrsLabel.Location = new System.Drawing.Point(146, 236);
            this.HrsLabel.Name = "HrsLabel";
            this.HrsLabel.Size = new System.Drawing.Size(28, 16);
            this.HrsLabel.TabIndex = 18;
            this.HrsLabel.Text = "Hrs";
            this.HrsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MinsLabel
            // 
            this.MinsLabel.AutoSize = true;
            this.MinsLabel.Location = new System.Drawing.Point(248, 236);
            this.MinsLabel.Name = "MinsLabel";
            this.MinsLabel.Size = new System.Drawing.Size(35, 16);
            this.MinsLabel.TabIndex = 19;
            this.MinsLabel.Text = "Mins";
            this.MinsLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SecLabel
            // 
            this.SecLabel.AutoSize = true;
            this.SecLabel.Location = new System.Drawing.Point(364, 236);
            this.SecLabel.Name = "SecLabel";
            this.SecLabel.Size = new System.Drawing.Size(38, 16);
            this.SecLabel.TabIndex = 20;
            this.SecLabel.Text = "Secs";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Location = new System.Drawing.Point(73, 265);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(54, 16);
            this.DirectorLabel.TabIndex = 21;
            this.DirectorLabel.Text = "Director";
            this.DirectorLabel.Click += new System.EventHandler(this.DirectorLabel_Click);
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ScheduleLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.ScheduleLabel.Location = new System.Drawing.Point(79, 313);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(64, 16);
            this.ScheduleLabel.TabIndex = 22;
            this.ScheduleLabel.Text = "Schedule";
            // 
            // SynopsisLabel
            // 
            this.SynopsisLabel.AutoSize = true;
            this.SynopsisLabel.Location = new System.Drawing.Point(400, 40);
            this.SynopsisLabel.Name = "SynopsisLabel";
            this.SynopsisLabel.Size = new System.Drawing.Size(63, 16);
            this.SynopsisLabel.TabIndex = 23;
            this.SynopsisLabel.Text = "Synopsis";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(149, 436);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(151, 35);
            this.SubmitButton.TabIndex = 24;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RatingField
            // 
            this.RatingField.Location = new System.Drawing.Point(77, 122);
            this.RatingField.Name = "RatingField";
            this.RatingField.Size = new System.Drawing.Size(118, 22);
            this.RatingField.TabIndex = 25;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.RatingField);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SynopsisLabel);
            this.Controls.Add(this.ScheduleLabel);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.SecLabel);
            this.Controls.Add(this.MinsLabel);
            this.Controls.Add(this.HrsLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.UploadPosterButton);
            this.Controls.Add(this.MoviePosterBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ScheduleDateField);
            this.Controls.Add(this.TimesList);
            this.Controls.Add(this.DirectorField);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.MinsField);
            this.Controls.Add(this.HrsField);
            this.Controls.Add(this.ReleaseDateField);
            this.Controls.Add(this.GenreField);
            this.Controls.Add(this.TitleField);
            this.Controls.Add(this.HeaderAddMovie);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.HrsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderAddMovie;
        private System.Windows.Forms.RichTextBox TitleField;
        private System.Windows.Forms.TextBox GenreField;
        private System.Windows.Forms.DateTimePicker ReleaseDateField;
        private System.Windows.Forms.NumericUpDown HrsField;
        private System.Windows.Forms.NumericUpDown MinsField;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.TextBox DirectorField;
        private System.Windows.Forms.ListBox TimesList;
        private System.Windows.Forms.DateTimePicker ScheduleDateField;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox MoviePosterBox;
        private System.Windows.Forms.Button UploadPosterButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label HrsLabel;
        private System.Windows.Forms.Label MinsLabel;
        private System.Windows.Forms.Label SecLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label ScheduleLabel;
        private System.Windows.Forms.Label SynopsisLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox RatingField;
    }
}