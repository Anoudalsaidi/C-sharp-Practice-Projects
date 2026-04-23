using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<student> students = new BindingList<student>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = students;
        }

        // ADD
        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student
            {
                Id = int.Parse(textBox1.Text),
                Name = textBox4.Text,
                Age = int.Parse(textBox3.Text),
                DEPARTMENT = textBox2.Text
            };

            students.Add(s);
        }

        // REMOVE
        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var student = students.FirstOrDefault(x => x.Id == id);

            if (student != null)
            {
                students.Remove(student);
            }
        }

        // SEARCH
        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var student = students.FirstOrDefault(x => x.Id == id);

            if (student != null)
            {
                dataGridView1.DataSource = new List<student> { student };
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

        // SHOW ALL
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = students;
        }
    }
}