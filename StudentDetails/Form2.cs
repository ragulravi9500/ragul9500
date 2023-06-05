using StudentManagementDetails.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Details
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void  Display(List<StudentDetailsList> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentId");
            dt.Columns.Add("StudentFirstName");
            dt.Columns.Add("StudentLastName");
            dt.Columns.Add("StudentGender");
            dt.Columns.Add("StudentDateOfBirth");
            dt.Columns.Add("StudentAddress");
            dt.Columns.Add("StudentPhoneNumber");
            dt.Columns.Add("StudentEmailId");
            foreach (var data in list)
            {
                DataRow row = dt.NewRow();
                row[0] = data.studentId;
                row[1] = data.studentFirstName;
                row[2] = data.studentLastName;
                row[3] = data.studentGender;
                row[4] = data.studentDateOfBirth;
                row[5] = data.studentAddress;
                row[6] = data.studentPhoneNumber;
                row[7] = data.studentEmailId;
                dt.Rows.Add(row);

            }
            dataGridView1.DataSource = dt;
        }
    }
}
