using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EzilankSever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            Console.WriteLine("dbcLoad");
            DataSet DS = new DataSet();
            dbc.getAdapter().Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void worldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
