using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EzilankSever.Core;
namespace EzilankSever
{
    public partial class Form1 : Form
    {
        private CoreLoader _coreloader;
        private DateTime dt;
        public Form1()
        {
            InitializeComponent();
            //this.Controls.Add(this.panel1);
            //panel1.Hide();
            //Control.CheckForIllegalCrossThreadCalls = false;
            
        }
        public delegate void InvokeDelegate();
        private void initTime()
        {
            System.Timers.Timer t = new System.Timers.Timer(1000);
            t.AutoReset = true;
            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
            t.Enabled = true;
        }

        public void updateLabelTime()
        {
            dt = DateTime.Now;
            label1.Text = dt.ToString();
        }
        public void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            label1.BeginInvoke(new InvokeDelegate(updateLabelTime));
            //throw new NotImplementedException();
        }
        private void initCL()
        {
            _coreloader = new CoreLoader();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void initPanel1()
        {
            DBConnect dbc = new DBConnect();
            Console.WriteLine("dbcLoad");
            DataSet DS = new DataSet();
            dbc.getAdapter().Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initTime();
            initCL();
            //initPanel1();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
