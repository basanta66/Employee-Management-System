using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=employeedb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void Employee_load(object sender, EventArgs e)
        {
            BindData();

        }
        void BindData()
        {
            SqlCommand cnn = new SqlCommand("Select * from emptab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);


            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;


        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1309, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(597, 38);
            label1.Name = "label1";
            label1.Size = new Size(207, 54);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 255);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1311, 475);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employees";
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(870, 320);
            button3.Name = "button3";
            button3.Size = new Size(118, 44);
            button3.TabIndex = 18;
            button3.Text = "New";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(1059, 320);
            button2.Name = "button2";
            button2.Size = new Size(127, 44);
            button2.TabIndex = 17;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(704, 320);
            button1.Name = "button1";
            button1.Size = new Size(116, 44);
            button1.TabIndex = 16;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(695, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 231);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(315, 435);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(204, 34);
            textBox7.TabIndex = 14;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(315, 372);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(204, 34);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(315, 292);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 34);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(315, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 34);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 34);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 34);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 34);
            textBox1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(48, 121);
            label9.Name = "label9";
            label9.Size = new Size(160, 28);
            label9.TabIndex = 7;
            label9.Text = "EmployeeName";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(57, 168);
            label8.Name = "label8";
            label8.Size = new Size(49, 28);
            label8.TabIndex = 6;
            label8.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(48, 230);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 5;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(48, 292);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 4;
            label6.Text = "Salary";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 359);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 3;
            label5.Text = "Dob";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 429);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 2;
            label4.Text = "Benefit";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 59);
            label2.Name = "label2";
            label2.Size = new Size(30, 28);
            label2.TabIndex = 0;
            label2.Text = "Id";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 582);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1308, 246);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Employee
            // 
            ClientSize = new Size(1215, 820);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Employee_Load_2;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void Employee_Load_1(object sender, EventArgs e)
        {
        }

        private void Employee_Load_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=employeedb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete emptab where id=@id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));



            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Deleted");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into emptab( id,employeename,age,email,salary,dob,benefit) values(@id,@employeename,@age,@email,@salary,@dob,@benefit)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@EmployeeName", (textBox2.Text));

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Email", (textBox4.Text));

            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox5.Text));

            cnn.Parameters.AddWithValue("@Dob", DateTime.Parse(textBox6.Text));

            cnn.Parameters.AddWithValue("@Benefit", (textBox7.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
