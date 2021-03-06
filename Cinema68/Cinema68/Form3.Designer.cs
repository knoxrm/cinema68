using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
namespace Cinema68
{
    partial class Form3 : Form
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(173, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(450, 273);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private void LoadDataFromDB()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.db");
            m_dbConnection.Open();

            using (SQLiteConnection conn = new SQLiteConnection(m_dbConnection))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Movie", conn); // MyTable (ID varchar(20), Name varchar(50) ,Score int)
                DataSet ds = new DataSet();
                sda.Fill(ds);

                listView1.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = row["ID"].ToString();
                    lvi.SubItems.Add(row["movie_name"].ToString());
                    lvi.SubItems.Add(row["movie_rating"].ToString());
                    listView1.Items.Add(lvi);
                }
                this.listView1.EndUpdate();
            }

            m_dbConnection.Close();
        }

        private void listView1_Load(object sender, System.EventArgs e)
        {
            LoadDataFromDB();
        }

        private System.Windows.Forms.ListView listView1;
    }
}