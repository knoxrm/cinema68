namespace Cinema68.Boundary
{
    partial class BuyTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicketForm));
            this.BuyTicketHeader = new System.Windows.Forms.Label();
            this.MovieNameOnCheckOut = new System.Windows.Forms.Label();
            this.MovieTimeOnCheckout = new System.Windows.Forms.Label();
            this.NoOfTicketsLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.NameOnCardLabel = new System.Windows.Forms.Label();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.ExpDateLabel = new System.Windows.Forms.Label();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.NoOfTickets = new System.Windows.Forms.NumericUpDown();
            this.TaxValue = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalValue = new System.Windows.Forms.Label();
            this.MakePaymentButton = new System.Windows.Forms.Button();
            this.CardNameField = new System.Windows.Forms.TextBox();
            this.CardNumberField = new System.Windows.Forms.TextBox();
            this.ExpDateField = new System.Windows.Forms.TextBox();
            this.CVVField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyTicketHeader
            // 
            this.BuyTicketHeader.AutoSize = true;
            this.BuyTicketHeader.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyTicketHeader.Location = new System.Drawing.Point(268, 9);
            this.BuyTicketHeader.Name = "BuyTicketHeader";
            this.BuyTicketHeader.Size = new System.Drawing.Size(231, 48);
            this.BuyTicketHeader.TabIndex = 0;
            this.BuyTicketHeader.Text = "Check Out";
            // 
            // MovieNameOnCheckOut
            // 
            this.MovieNameOnCheckOut.AutoSize = true;
            this.MovieNameOnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameOnCheckOut.Location = new System.Drawing.Point(194, 104);
            this.MovieNameOnCheckOut.Name = "MovieNameOnCheckOut";
            this.MovieNameOnCheckOut.Size = new System.Drawing.Size(58, 20);
            this.MovieNameOnCheckOut.TabIndex = 1;
            this.MovieNameOnCheckOut.Text = "Movie:";
            // 
            // MovieTimeOnCheckout
            // 
            this.MovieTimeOnCheckout.AutoSize = true;
            this.MovieTimeOnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTimeOnCheckout.Location = new System.Drawing.Point(493, 104);
            this.MovieTimeOnCheckout.Name = "MovieTimeOnCheckout";
            this.MovieTimeOnCheckout.Size = new System.Drawing.Size(56, 20);
            this.MovieTimeOnCheckout.TabIndex = 2;
            this.MovieTimeOnCheckout.Text = "Time: ";
            this.MovieTimeOnCheckout.Click += new System.EventHandler(this.label2_Click);
            // 
            // NoOfTicketsLabel
            // 
            this.NoOfTicketsLabel.AutoSize = true;
            this.NoOfTicketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfTicketsLabel.Location = new System.Drawing.Point(65, 160);
            this.NoOfTicketsLabel.Name = "NoOfTicketsLabel";
            this.NoOfTicketsLabel.Size = new System.Drawing.Size(146, 20);
            this.NoOfTicketsLabel.TabIndex = 3;
            this.NoOfTicketsLabel.Text = "Number of Tickets";
            this.NoOfTicketsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(69, 199);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLabel.Size = new System.Drawing.Size(46, 20);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.Click += new System.EventHandler(this.TotalLabel_Click);
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(65, 240);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(54, 20);
            this.TaxLabel.TabIndex = 5;
            this.TaxLabel.Text = "Taxes";
            // 
            // NameOnCardLabel
            // 
            this.NameOnCardLabel.AutoSize = true;
            this.NameOnCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOnCardLabel.Location = new System.Drawing.Point(65, 344);
            this.NameOnCardLabel.Name = "NameOnCardLabel";
            this.NameOnCardLabel.Size = new System.Drawing.Size(126, 20);
            this.NameOnCardLabel.TabIndex = 6;
            this.NameOnCardLabel.Text = "Name On Card:";
            this.NameOnCardLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(65, 374);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(114, 20);
            this.CardNumberLabel.TabIndex = 7;
            this.CardNumberLabel.Text = "Card Number:";
            // 
            // ExpDateLabel
            // 
            this.ExpDateLabel.AutoSize = true;
            this.ExpDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDateLabel.Location = new System.Drawing.Point(65, 404);
            this.ExpDateLabel.Name = "ExpDateLabel";
            this.ExpDateLabel.Size = new System.Drawing.Size(129, 20);
            this.ExpDateLabel.TabIndex = 8;
            this.ExpDateLabel.Text = "Expiration Date:";
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.Location = new System.Drawing.Point(65, 435);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(112, 20);
            this.CVVLabel.TabIndex = 9;
            this.CVVLabel.Text = "CVV Number:";
            // 
            // NoOfTickets
            // 
            this.NoOfTickets.Location = new System.Drawing.Point(218, 160);
            this.NoOfTickets.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NoOfTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NoOfTickets.Name = "NoOfTickets";
            this.NoOfTickets.Size = new System.Drawing.Size(54, 22);
            this.NoOfTickets.TabIndex = 10;
            this.NoOfTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TaxValue
            // 
            this.TaxValue.AutoSize = true;
            this.TaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxValue.Location = new System.Drawing.Point(153, 240);
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Size = new System.Drawing.Size(0, 20);
            this.TaxValue.TabIndex = 12;
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalValue.Location = new System.Drawing.Point(153, 199);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(0, 20);
            this.TotalValue.TabIndex = 13;
            this.TotalValue.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(65, 272);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(97, 20);
            this.GrandTotalLabel.TabIndex = 14;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // GrandTotalValue
            // 
            this.GrandTotalValue.AutoSize = true;
            this.GrandTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalValue.Location = new System.Drawing.Point(211, 272);
            this.GrandTotalValue.Name = "GrandTotalValue";
            this.GrandTotalValue.Size = new System.Drawing.Size(0, 20);
            this.GrandTotalValue.TabIndex = 15;
            // 
            // MakePaymentButton
            // 
            this.MakePaymentButton.Location = new System.Drawing.Point(69, 483);
            this.MakePaymentButton.Name = "MakePaymentButton";
            this.MakePaymentButton.Size = new System.Drawing.Size(122, 41);
            this.MakePaymentButton.TabIndex = 16;
            this.MakePaymentButton.Text = "Make Payment";
            this.MakePaymentButton.UseVisualStyleBackColor = true;
            // 
            // CardNameField
            // 
            this.CardNameField.Location = new System.Drawing.Point(195, 345);
            this.CardNameField.Name = "CardNameField";
            this.CardNameField.Size = new System.Drawing.Size(166, 22);
            this.CardNameField.TabIndex = 17;
            // 
            // CardNumberField
            // 
            this.CardNumberField.Location = new System.Drawing.Point(183, 375);
            this.CardNumberField.Name = "CardNumberField";
            this.CardNumberField.Size = new System.Drawing.Size(166, 22);
            this.CardNumberField.TabIndex = 18;
            // 
            // ExpDateField
            // 
            this.ExpDateField.Location = new System.Drawing.Point(198, 407);
            this.ExpDateField.Name = "ExpDateField";
            this.ExpDateField.Size = new System.Drawing.Size(166, 22);
            this.ExpDateField.TabIndex = 19;
            this.ExpDateField.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CVVField
            // 
            this.CVVField.Location = new System.Drawing.Point(178, 435);
            this.CVVField.Name = "CVVField";
            this.CVVField.Size = new System.Drawing.Size(183, 22);
            this.CVVField.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 213);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CVVField);
            this.Controls.Add(this.ExpDateField);
            this.Controls.Add(this.CardNumberField);
            this.Controls.Add(this.CardNameField);
            this.Controls.Add(this.MakePaymentButton);
            this.Controls.Add(this.GrandTotalValue);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.TotalValue);
            this.Controls.Add(this.TaxValue);
            this.Controls.Add(this.NoOfTickets);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.ExpDateLabel);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.NameOnCardLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.NoOfTicketsLabel);
            this.Controls.Add(this.MovieTimeOnCheckout);
            this.Controls.Add(this.MovieNameOnCheckOut);
            this.Controls.Add(this.BuyTicketHeader);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            this.Load += new System.EventHandler(this.BuyTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoOfTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuyTicketHeader;
        private System.Windows.Forms.Label MovieNameOnCheckOut;
        private System.Windows.Forms.Label MovieTimeOnCheckout;
        private System.Windows.Forms.Label NoOfTicketsLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label NameOnCardLabel;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label ExpDateLabel;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.NumericUpDown NoOfTickets;
        private System.Windows.Forms.Label TaxValue;
        private System.Windows.Forms.Label TotalValue;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label GrandTotalValue;
        private System.Windows.Forms.Button MakePaymentButton;
        private System.Windows.Forms.TextBox CardNameField;
        private System.Windows.Forms.TextBox CardNumberField;
        private System.Windows.Forms.TextBox ExpDateField;
        private System.Windows.Forms.TextBox CVVField;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}