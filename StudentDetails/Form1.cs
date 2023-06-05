using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentManagementDetails.BL;
using StudentManagementDetails.Entities;
using System.Data;

namespace Details
{

    public partial class Form1 : Form
    {
        StudentManagementEnitity student = new StudentManagementEnitity();
        StudentManagementService service = new StudentManagementService();

        DataTable dt = new DataTable();
        private SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "data source=TRNE17-RAGULR; database=StudentDetails; uid=sa; password=O4D185XdQ!aY;";
            con = new SqlConnection(connectionString);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            while (true)
            {

                if (service.IsValidName(Studentfnbox.Text) == true)
                {
                    student.studentFirstName = Studentfnbox.Text;

                    break;
                }
                else
                {
                    MessageBox.Show("Enter the valid Name");

                }
            }
            Studentfnbox.Text = String.Empty;
            student.studentLastName = Studentlnbox.Text;
            Studentlnbox.Text = String.Empty;
            string gender = "";
            if (StudentMale.Checked == true)
            {
                gender = "Male";
                StudentMale.Checked = false;
            }

            if (StudentFemaleRadio.Checked == true)
            {
                gender = "Female";
                StudentFemaleRadio.Checked = false;
            }
            student.studentGender = gender;

            if (service.IsValidDOB(StudentDOBbox.Text) == true)
            {
                student.studentDateOfBirth = Convert.ToDateTime(StudentDOBbox.Text);
            }
            else
            {
                ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Invalid Date Of Birth");
            }

            student.studentAddress = StudentAddbox.Text;
            StudentAddbox.Text = String.Empty;
            student.studentPhoneNumber = StudentPhBox.Text;
            StudentPhBox.Text = String.Empty;
            student.studentEmailId = StudentEmailIdbox.Text;
            StudentEmailIdbox.Text = String.Empty;

            if ((service.AddStuentDetails(student) == true))
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Some Error Occurred");
            }

        }

        private void Studentfnbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            var list = StudentManagementService.GetLists();
            if (list != null)
            {
                this.Visible = false;
                Form2 form2 = new Form2();
                form2.Show();
                form2.Display(list);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Studentlnbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StudentAddbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}