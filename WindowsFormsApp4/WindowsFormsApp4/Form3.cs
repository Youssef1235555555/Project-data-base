using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            string name = tname.Text;
            string mobile = tmob.Text;
            string age = tage.Text;
            string gender = tgen.Text;
            string qulification = tqul .Text;
            string status = tstat.Text;
            string city = tcity.Text;
            listView1.Items.Add(id).SubItems.Add(name);
            listView2.Items.Add(mobile).SubItems.Add(age);
            listView3.Items.Add(gender ).SubItems.Add(qulification  );
            listView4.Items.Add(status ).SubItems.Add(city );



        }

        private void button2_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tname.Text = "";
            tmob.Text = "";
            tage.Text = "";
            tgen.Text = "";
            tstat.Text = "";
            tcity.Text = "";
            tqul.Text = "";

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
