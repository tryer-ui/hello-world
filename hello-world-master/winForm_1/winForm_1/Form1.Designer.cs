﻿namespace winForm_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_SupName = new System.Windows.Forms.ComboBox();
            this.text_InvID = new System.Windows.Forms.TextBox();
            this.date_InvDate = new System.Windows.Forms.DateTimePicker();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.text_Note = new System.Windows.Forms.TextBox();
            this.addInvoice_Button = new System.Windows.Forms.Button();
            this.showReport_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1634, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(285, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "הכנס שם ספק:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1634, 588);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(358, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "הכנס מס\' חשבונית:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1634, 729);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(384, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "בחר תאריך חשבונית:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1634, 863);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(223, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "הכנס מחיר:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1634, 1008);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(146, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "הערות:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1100, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(521, 67);
            this.label6.TabIndex = 5;
            this.label6.Text = "הוספת חשבונית חדשה";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_SupName
            // 
            this.combo_SupName.AllowDrop = true;
            this.combo_SupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_SupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_SupName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_SupName.FormattingEnabled = true;
            this.combo_SupName.Items.AddRange(new object[] {
            "123",
            "חיטה ושעורה",
            "יאללפ",
            "SomeEng21",
            "sdf אבג rew לךח 231 פפפ"});
            this.combo_SupName.Location = new System.Drawing.Point(952, 460);
            this.combo_SupName.Margin = new System.Windows.Forms.Padding(6);
            this.combo_SupName.Name = "combo_SupName";
            this.combo_SupName.Size = new System.Drawing.Size(598, 63);
            this.combo_SupName.TabIndex = 6;
            this.combo_SupName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // text_InvID
            // 
            this.text_InvID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_InvID.Location = new System.Drawing.Point(952, 583);
            this.text_InvID.Margin = new System.Windows.Forms.Padding(6);
            this.text_InvID.Name = "text_InvID";
            this.text_InvID.Size = new System.Drawing.Size(598, 63);
            this.text_InvID.TabIndex = 7;
            this.text_InvID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // date_InvDate
            // 
            this.date_InvDate.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_InvDate.Location = new System.Drawing.Point(1082, 740);
            this.date_InvDate.Margin = new System.Windows.Forms.Padding(6);
            this.date_InvDate.Name = "date_InvDate";
            this.date_InvDate.Size = new System.Drawing.Size(468, 31);
            this.date_InvDate.TabIndex = 8;
            // 
            // text_Price
            // 
            this.text_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Price.Location = new System.Drawing.Point(1082, 858);
            this.text_Price.Margin = new System.Windows.Forms.Padding(6);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(468, 63);
            this.text_Price.TabIndex = 9;
            // 
            // text_Note
            // 
            this.text_Note.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Note.Location = new System.Drawing.Point(1082, 1002);
            this.text_Note.Margin = new System.Windows.Forms.Padding(6);
            this.text_Note.Name = "text_Note";
            this.text_Note.Size = new System.Drawing.Size(468, 63);
            this.text_Note.TabIndex = 10;
            // 
            // addInvoice_Button
            // 
            this.addInvoice_Button.BackColor = System.Drawing.Color.Lavender;
            this.addInvoice_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addInvoice_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addInvoice_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvoice_Button.ForeColor = System.Drawing.Color.Red;
            this.addInvoice_Button.Location = new System.Drawing.Point(1426, 1187);
            this.addInvoice_Button.Margin = new System.Windows.Forms.Padding(6);
            this.addInvoice_Button.Name = "addInvoice_Button";
            this.addInvoice_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addInvoice_Button.Size = new System.Drawing.Size(448, 163);
            this.addInvoice_Button.TabIndex = 11;
            this.addInvoice_Button.Text = "הוסף חשבונית";
            this.addInvoice_Button.UseVisualStyleBackColor = false;
            this.addInvoice_Button.Click += new System.EventHandler(this.addInvoice_Button_Click);
            // 
            // showReport_Button
            // 
            this.showReport_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.showReport_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showReport_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showReport_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showReport_Button.ForeColor = System.Drawing.Color.Black;
            this.showReport_Button.Location = new System.Drawing.Point(196, 1217);
            this.showReport_Button.Margin = new System.Windows.Forms.Padding(6);
            this.showReport_Button.Name = "showReport_Button";
            this.showReport_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showReport_Button.Size = new System.Drawing.Size(444, 133);
            this.showReport_Button.TabIndex = 12;
            this.showReport_Button.Text = "הצג דו\"ח חודשי";
            this.showReport_Button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(952, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1274, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(498, 62);
            this.label7.TabIndex = 14;
            this.label7.Text = "מערכת לניהול חשבוניות";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2736, 1460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showReport_Button);
            this.Controls.Add(this.addInvoice_Button);
            this.Controls.Add(this.text_Note);
            this.Controls.Add(this.text_Price);
            this.Controls.Add(this.date_InvDate);
            this.Controls.Add(this.text_InvID);
            this.Controls.Add(this.combo_SupName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_SupName;
        private System.Windows.Forms.TextBox text_InvID;
        private System.Windows.Forms.DateTimePicker date_InvDate;
        private System.Windows.Forms.TextBox text_Price;
        private System.Windows.Forms.TextBox text_Note;
        private System.Windows.Forms.Button addInvoice_Button;
        private System.Windows.Forms.Button showReport_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}
