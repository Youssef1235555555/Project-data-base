using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BackColor = Color.Gray  ;
            ////TransparencyKey = BackColor;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection oleDbcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Desktop\mekhemar\Data\loginDB.accdb");
            string query = "select * from tlog where username ='" + textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";
            OleDbDataAdapter olx = new OleDbDataAdapter(query, oleDbcon);
            DataTable dtbl = new DataTable();
            olx.Fill(dtbl);
            if (dtbl.Rows.Count == 0)
            {
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Check username and Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
