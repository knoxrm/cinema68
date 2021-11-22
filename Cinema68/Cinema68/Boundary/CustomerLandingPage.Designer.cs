using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
//using Cinema68.Control;
namespace Cinema68.Boundary
{
    partial class CustomerLandingPage : Form
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
            this.HeaderCustLandingPage = new System.Windows.Forms.Label();
            this.WelcomeCust = new System.Windows.Forms.Label();
            this.LogOutButtonFromCust = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // HeaderCustLandingPage
            // 
            this.HeaderCustLandingPage.AutoSize = true;
            this.HeaderCustLandingPage.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderCustLandingPage.Location = new System.Drawing.Point(9, 8);
            this.HeaderCustLandingPage.Name = "HeaderCustLandingPage";
            this.HeaderCustLandingPage.Size = new System.Drawing.Size(209, 43);
            this.HeaderCustLandingPage.TabIndex = 0;
            this.HeaderCustLandingPage.Text = "Cinema68";
            // 
            // WelcomeCust
            // 
            this.WelcomeCust.AutoSize = true;
            this.WelcomeCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeCust.Location = new System.Drawing.Point(615, 19);
            this.WelcomeCust.Name = "WelcomeCust";
            this.WelcomeCust.Size = new System.Drawing.Size(196, 25);
            this.WelcomeCust.TabIndex = 1;
            this.WelcomeCust.Text = "Welcome, Customer!";
            this.WelcomeCust.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogOutButtonFromCust
            // 
            this.LogOutButtonFromCust.AutoSize = true;
            this.LogOutButtonFromCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButtonFromCust.Location = new System.Drawing.Point(827, 17);
            this.LogOutButtonFromCust.Name = "LogOutButtonFromCust";
            this.LogOutButtonFromCust.Size = new System.Drawing.Size(77, 24);
            this.LogOutButtonFromCust.TabIndex = 2;
            this.LogOutButtonFromCust.TabStop = true;
            this.LogOutButtonFromCust.Text = "Log Out";
            // 
            // CustomerLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 499);
            this.Controls.Add(this.LogOutButtonFromCust);
            this.Controls.Add(this.WelcomeCust);
            this.Controls.Add(this.HeaderCustLandingPage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerLandingPage";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.LandingPage_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void LoadDataFromDB()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.db");
            m_dbConnection.Open();

            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Movie", conn); 
                DataSet ds = new DataSet();
                sda.Fill(ds);

                //listView1.BeginUpdate();
                //foreach (DataRow row in ds.Tables[0].Rows)
                //{
                //    ListViewItem lvi = new ListViewItem();
                //    lvi.Text = row["ID"].ToString();
                //    lvi.SubItems.Add(row["movie_name"].ToString());
                //    lvi.SubItems.Add(row["movie_rating"].ToString());
                //    listView1.Items.Add(lvi);
                //}
                //this.listView1.EndUpdate();
            }

            m_dbConnection.Close();
        }

        private void LandingPage_Load(object sender, System.EventArgs e)
        {
            LoadDataFromDB();
        }

        private Label HeaderCustLandingPage;
        private Label WelcomeCust;
        private LinkLabel LogOutButtonFromCust;
    }
}