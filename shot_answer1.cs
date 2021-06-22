using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSurvey
{
    public partial class shot_answer1 : UserControl
    {
        string data;
        

        public shot_answer1()
        {
            InitializeComponent();
        }

        public void SettingControl(string title, string number, string[] article_List)
        {
            label1.Text = number;
            label2.Text = title;
            radioButton1.Text = article_List[0];
            radioButton2.Text = article_List[1];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.data = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.data = radioButton2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
