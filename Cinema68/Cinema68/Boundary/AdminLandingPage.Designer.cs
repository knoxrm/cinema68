
namespace Cinema68.Boundary
{
    partial class AdminLandingPage
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
            this.HeaderAdmLandingPage = new System.Windows.Forms.Label();
            this.WelcomeAdm = new System.Windows.Forms.Label();
            this.LogOutButtonFromAdm = new System.Windows.Forms.LinkLabel();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderAdmLandingPage
            // 
            this.HeaderAdmLandingPage.AutoSize = true;
            this.HeaderAdmLandingPage.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderAdmLandingPage.Location = new System.Drawing.Point(12, 9);
            this.HeaderAdmLandingPage.Name = "HeaderAdmLandingPage";
            this.HeaderAdmLandingPage.Size = new System.Drawing.Size(209, 43);
            this.HeaderAdmLandingPage.TabIndex = 1;
            this.HeaderAdmLandingPage.Text = "Cinema68";
            this.HeaderAdmLandingPage.Click += new System.EventHandler(this.HeaderCustLandingPage_Click);
            // 
            // WelcomeAdm
            // 
            this.WelcomeAdm.AutoSize = true;
            this.WelcomeAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeAdm.Location = new System.Drawing.Point(512, 20);
            this.WelcomeAdm.Name = "WelcomeAdm";
            this.WelcomeAdm.Size = new System.Drawing.Size(167, 25);
            this.WelcomeAdm.TabIndex = 2;
            this.WelcomeAdm.Text = "Welcome, Admin!";
            this.WelcomeAdm.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogOutButtonFromAdm
            // 
            this.LogOutButtonFromAdm.AutoSize = true;
            this.LogOutButtonFromAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButtonFromAdm.Location = new System.Drawing.Point(711, 20);
            this.LogOutButtonFromAdm.Name = "LogOutButtonFromAdm";
            this.LogOutButtonFromAdm.Size = new System.Drawing.Size(77, 24);
            this.LogOutButtonFromAdm.TabIndex = 3;
            this.LogOutButtonFromAdm.TabStop = true;
            this.LogOutButtonFromAdm.Text = "Log Out";
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(393, 24);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(104, 23);
            this.AddMovieButton.TabIndex = 4;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.LogOutButtonFromAdm);
            this.Controls.Add(this.WelcomeAdm);
            this.Controls.Add(this.HeaderAdmLandingPage);
            this.Name = "AdminLandingPage";
            this.Text = "AdminLandingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderAdmLandingPage;
        private System.Windows.Forms.Label WelcomeAdm;
        private System.Windows.Forms.LinkLabel LogOutButtonFromAdm;
        private System.Windows.Forms.Button AddMovieButton;
    }
}