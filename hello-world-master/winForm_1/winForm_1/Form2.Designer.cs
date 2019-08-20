namespace winForm_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supName_textBox = new System.Windows.Forms.TextBox();
            this.SupCategory_combobox = new System.Windows.Forms.ComboBox();
            this.supMail_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supContact_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.supPhone_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addInvoice_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(876, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(498, 62);
            this.label7.TabIndex = 15;
            this.label7.Text = "מערכת לניהול חשבוניות";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(893, 404);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(402, 67);
            this.label6.TabIndex = 18;
            this.label6.Text = "הוספת ספק חדש";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1427, 620);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(350, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "בחר קטגורית ספק:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1427, 511);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(285, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "הכנס שם ספק:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // supName_textBox
            // 
            this.supName_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supName_textBox.Location = new System.Drawing.Point(745, 503);
            this.supName_textBox.Margin = new System.Windows.Forms.Padding(6);
            this.supName_textBox.Name = "supName_textBox";
            this.supName_textBox.Size = new System.Drawing.Size(598, 63);
            this.supName_textBox.TabIndex = 21;
            // 
            // SupCategory_combobox
            // 
            this.SupCategory_combobox.AllowDrop = true;
            this.SupCategory_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SupCategory_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupCategory_combobox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupCategory_combobox.FormattingEnabled = true;
            this.SupCategory_combobox.Items.AddRange(new object[] {
            "123",
            "חיטה ושעורה",
            "יאללפ",
            "SomeEng21",
            "sdf אבג rew לךח 231 פפפ"});
            this.SupCategory_combobox.Location = new System.Drawing.Point(745, 620);
            this.SupCategory_combobox.Margin = new System.Windows.Forms.Padding(6);
            this.SupCategory_combobox.Name = "SupCategory_combobox";
            this.SupCategory_combobox.Size = new System.Drawing.Size(598, 63);
            this.SupCategory_combobox.TabIndex = 22;
            // 
            // supMail_textBox
            // 
            this.supMail_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supMail_textBox.Location = new System.Drawing.Point(875, 725);
            this.supMail_textBox.Margin = new System.Windows.Forms.Padding(6);
            this.supMail_textBox.Name = "supMail_textBox";
            this.supMail_textBox.Size = new System.Drawing.Size(468, 63);
            this.supMail_textBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1427, 730);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(207, 55);
            this.label4.TabIndex = 23;
            this.label4.Text = "הכנס מייל:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supContact_textBox
            // 
            this.supContact_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supContact_textBox.Location = new System.Drawing.Point(876, 838);
            this.supContact_textBox.Margin = new System.Windows.Forms.Padding(6);
            this.supContact_textBox.Name = "supContact_textBox";
            this.supContact_textBox.Size = new System.Drawing.Size(468, 63);
            this.supContact_textBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1428, 843);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(294, 55);
            this.label3.TabIndex = 25;
            this.label3.Text = "הכנס איש קשר:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supPhone_textBox
            // 
            this.supPhone_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supPhone_textBox.Location = new System.Drawing.Point(876, 944);
            this.supPhone_textBox.Margin = new System.Windows.Forms.Padding(6);
            this.supPhone_textBox.Name = "supPhone_textBox";
            this.supPhone_textBox.Size = new System.Drawing.Size(468, 63);
            this.supPhone_textBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1428, 949);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(231, 55);
            this.label5.TabIndex = 27;
            this.label5.Text = "הכנס טלפון:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addInvoice_Button
            // 
            this.addInvoice_Button.BackColor = System.Drawing.Color.Lavender;
            this.addInvoice_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addInvoice_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addInvoice_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvoice_Button.ForeColor = System.Drawing.Color.Red;
            this.addInvoice_Button.Location = new System.Drawing.Point(288, 885);
            this.addInvoice_Button.Margin = new System.Windows.Forms.Padding(6);
            this.addInvoice_Button.Name = "addInvoice_Button";
            this.addInvoice_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addInvoice_Button.Size = new System.Drawing.Size(448, 163);
            this.addInvoice_Button.TabIndex = 29;
            this.addInvoice_Button.Text = "הוסף ספק";
            this.addInvoice_Button.UseVisualStyleBackColor = false;
            this.addInvoice_Button.Click += new System.EventHandler(this.addInvoice_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_Button.Location = new System.Drawing.Point(64, 944);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(151, 86);
            this.exit_Button.TabIndex = 30;
            this.exit_Button.Text = "סגור חלון";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 1085);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.addInvoice_Button);
            this.Controls.Add(this.supPhone_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.supContact_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supMail_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupCategory_combobox);
            this.Controls.Add(this.supName_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supName_textBox;
        private System.Windows.Forms.ComboBox SupCategory_combobox;
        private System.Windows.Forms.TextBox supMail_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supContact_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supPhone_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addInvoice_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}