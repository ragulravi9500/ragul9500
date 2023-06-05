namespace Details
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            Studentfnbox = new TextBox();
            Studentlnbox = new TextBox();
            StudentAddbox = new TextBox();
            StudentPhBox = new TextBox();
            StudentEmailIdbox = new TextBox();
            StudentMale = new RadioButton();
            StudentFemaleRadio = new RadioButton();
            label7 = new Label();
            StudentDOBbox = new TextBox();
            View = new Button();
            imageList1 = new ImageList(components);
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 87);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 0;
            label1.Text = "StudentFirstName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(430, 89);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 1;
            label2.Text = "StudentLastName";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 142);
            label3.Name = "label3";
            label3.Size = new Size(132, 19);
            label3.TabIndex = 2;
            label3.Text = "StudentGender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 213);
            label4.Name = "label4";
            label4.Size = new Size(139, 19);
            label4.TabIndex = 3;
            label4.Text = "StudentAddress";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 326);
            label5.Name = "label5";
            label5.Size = new Size(190, 19);
            label5.TabIndex = 4;
            label5.Text = "StudentPhoneNumber";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(454, 326);
            label6.Name = "label6";
            label6.Size = new Size(137, 19);
            label6.TabIndex = 5;
            label6.Text = "StudentEmailId";
            // 
            // button1
            // 
            button1.Location = new Point(86, 449);
            button1.Name = "button1";
            button1.Size = new Size(107, 45);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Studentfnbox
            // 
            Studentfnbox.Location = new Point(195, 85);
            Studentfnbox.Name = "Studentfnbox";
            Studentfnbox.Size = new Size(195, 23);
            Studentfnbox.TabIndex = 7;
            Studentfnbox.TextChanged += Studentfnbox_TextChanged;
            // 
            // Studentlnbox
            // 
            Studentlnbox.Location = new Point(618, 85);
            Studentlnbox.Name = "Studentlnbox";
            Studentlnbox.Size = new Size(195, 23);
            Studentlnbox.TabIndex = 8;
            Studentlnbox.TextChanged += Studentlnbox_TextChanged;
            // 
            // StudentAddbox
            // 
            StudentAddbox.Location = new Point(195, 212);
            StudentAddbox.Multiline = true;
            StudentAddbox.Name = "StudentAddbox";
            StudentAddbox.Size = new Size(258, 85);
            StudentAddbox.TabIndex = 9;
            StudentAddbox.TextChanged += StudentAddbox_TextChanged;
            // 
            // StudentPhBox
            // 
            StudentPhBox.Location = new Point(230, 323);
            StudentPhBox.Multiline = true;
            StudentPhBox.Name = "StudentPhBox";
            StudentPhBox.Size = new Size(210, 22);
            StudentPhBox.TabIndex = 10;
            // 
            // StudentEmailIdbox
            // 
            StudentEmailIdbox.Location = new Point(618, 322);
            StudentEmailIdbox.Name = "StudentEmailIdbox";
            StudentEmailIdbox.Size = new Size(195, 23);
            StudentEmailIdbox.TabIndex = 11;
            // 
            // StudentMale
            // 
            StudentMale.AutoSize = true;
            StudentMale.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentMale.Location = new Point(189, 143);
            StudentMale.Name = "StudentMale";
            StudentMale.Size = new Size(69, 22);
            StudentMale.TabIndex = 12;
            StudentMale.TabStop = true;
            StudentMale.Text = "Male";
            StudentMale.UseVisualStyleBackColor = true;
            // 
            // StudentFemaleRadio
            // 
            StudentFemaleRadio.AutoSize = true;
            StudentFemaleRadio.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentFemaleRadio.Location = new Point(273, 143);
            StudentFemaleRadio.Name = "StudentFemaleRadio";
            StudentFemaleRadio.Size = new Size(88, 22);
            StudentFemaleRadio.TabIndex = 13;
            StudentFemaleRadio.TabStop = true;
            StudentFemaleRadio.Text = "Female";
            StudentFemaleRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(430, 144);
            label7.Name = "label7";
            label7.Size = new Size(173, 19);
            label7.TabIndex = 14;
            label7.Text = "StudentDateOfBirth";
            label7.Click += label7_Click;
            // 
            // StudentDOBbox
            // 
            StudentDOBbox.Location = new Point(618, 142);
            StudentDOBbox.Name = "StudentDOBbox";
            StudentDOBbox.Size = new Size(195, 23);
            StudentDOBbox.TabIndex = 15;
            // 
            // View
            // 
            View.Location = new Point(665, 450);
            View.Name = "View";
            View.Size = new Size(123, 45);
            View.TabIndex = 16;
            View.Text = "View StudentDetails";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(160, 10);
            label8.Name = "label8";
            label8.Size = new Size(544, 44);
            label8.TabIndex = 17;
            label8.Text = "KRCT COLLEGE OF ENGINEERING";
            // 
            // button2
            // 
            button2.Location = new Point(265, 448);
            button2.Name = "button2";
            button2.Size = new Size(107, 45);
            button2.TabIndex = 18;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(475, 450);
            button3.Name = "button3";
            button3.Size = new Size(107, 45);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(873, 605);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(View);
            Controls.Add(StudentDOBbox);
            Controls.Add(label7);
            Controls.Add(StudentFemaleRadio);
            Controls.Add(StudentMale);
            Controls.Add(StudentEmailIdbox);
            Controls.Add(StudentPhBox);
            Controls.Add(StudentAddbox);
            Controls.Add(Studentlnbox);
            Controls.Add(Studentfnbox);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Padding = new Padding(1);
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox Studentfnbox;
        private TextBox Studentlnbox;
        private TextBox StudentAddbox;
        private TextBox StudentPhBox;
        private TextBox StudentEmailIdbox;
        private RadioButton StudentMale;
        private RadioButton StudentFemaleRadio;
        private Label label7;
        private TextBox StudentDOBbox;
        private Button View;
        private ImageList imageList1;
        private Label label8;
        private Button button2;
        private Button button3;
    }
}