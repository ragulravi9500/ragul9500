namespace Details
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            updatename = new TextBox();
            updateemail = new TextBox();
            Submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 107);
            label1.Name = "label1";
            label1.Size = new Size(198, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter the StudentName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 188);
            label2.Name = "label2";
            label2.Size = new Size(217, 19);
            label2.TabIndex = 1;
            label2.Text = "Enter the StudentEmailId";
            // 
            // updatename
            // 
            updatename.Location = new Point(433, 104);
            updatename.Name = "updatename";
            updatename.Size = new Size(182, 23);
            updatename.TabIndex = 2;
            // 
            // updateemail
            // 
            updateemail.Location = new Point(433, 184);
            updateemail.Name = "updateemail";
            updateemail.Size = new Size(182, 23);
            updateemail.TabIndex = 3;
            // 
            // Submit
            // 
            Submit.Location = new Point(340, 333);
            Submit.Name = "Submit";
            Submit.Size = new Size(101, 40);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit);
            Controls.Add(updateemail);
            Controls.Add(updatename);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox updatename;
        private TextBox updateemail;
        private Button Submit;
    }
}