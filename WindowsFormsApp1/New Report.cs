using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class New_Report : Form
    {
        DataTable table = new DataTable("Complain_table");
        int index;
        public New_Report()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 main=new Form1();
            main.Show();
            
        }

        private void New_Report_Load(object sender, EventArgs e)
        {
            table.Columns.Add("cnic",Type.GetType("System.String"));
            table.Columns.Add("name", Type.GetType("System.String"));
            table.Columns.Add("email", Type.GetType("System.String"));
            table.Columns.Add("comp_title", Type.GetType("System.String"));
            table.Columns.Add("comp_details", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,richTextBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index]; 
            textBox1.Text=row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox3.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[0].Value.ToString();
            richTextBox1.Text = row.Cells[0].Value.ToString();

        }

        private void Up_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[index];
            row.Cells[0].Value = textBox1.Text;
            row.Cells[1].Value = textBox2.Text;
            row.Cells[2].Value = textBox3.Text;
            row.Cells[3].Value = textBox4.Text;
            row.Cells[4].Value = richTextBox1.Text;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index= dataGridView1.CurrentCell.RowIndex;dataGridView1.Rows.RemoveAt(index);   
        }
    }
}
