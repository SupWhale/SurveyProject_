using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSurvey
{

    public partial class Form1 : Form
    {
        Question q1 = new Question();
        UserControl us;
        int tablecount = 0;
        public Tabpages[] Tabpages;
        TabControl tc = new TabControl();

        public bool notact = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tablecount = Int32.Parse(textBox1.Text);
            Tabpages = new Tabpages[tablecount];
        }
        int count = 0;

        //탭페이지 넘김 부분
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                count--;
                tabControl1.SelectedTab = Tabpages[count].getTabpage();
                label1.Text = count.ToString();
            } catch (Exception)
            {
                MessageBox.Show("제일 첫번째 페이지 입니다!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                tabControl1.SelectedTab = Tabpages[count].getTabpage();
                label1.Text = count.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("제일 마지막 페이지 입니다.");
            }
        }

        //탭페이지 관리 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            if (tablecount.Equals(0))
                MessageBox.Show("텍스트 박스에 테이블의 갯수를 입력해주세요");
            else
                Tabpage_Load(sender, e);
        }
        private void Tabpage_Load(object sender, EventArgs e)
        {
            for (int idx = 1; idx <= tablecount; idx++)
            {
                Tabpages tp = new Tabpages(0);
                Tabpages[idx - 1] = tp;
                tabControl1.TabPages.Add(tp.makeTabpage(idx));
            }
        }
        //데이터 베이스 관리 부분
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                using (MySqlConnection connection =
                    new MySqlConnection("Server=localhost;Port=3306;Database=survey;Uid=root;Pwd="))
                    try
                    {
                        connection.Open();
                        string sql = "SELECT * FROM object_servey";
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        MySqlDataReader table = cmd.ExecuteReader();

                        while (table.Read())
                        {
                            Console.WriteLine("{0} {1} {2}", table["Q_count"], table["Q_number"], table["Title"]);
                        }
                        Console.WriteLine("DB 연결 성공!");
                        table.Close();
                    } catch (Exception ex)
                    {
                        Console.WriteLine("셀렉트 실패!");
                        Console.WriteLine(ex.ToString());
                    }
            }
        }

    
    private void AddtabPage(UserControl us)
    {
        if (Tabpages[count].GetQcount() == 6)
        {
            MessageBox.Show("No");
        }
        else if (Tabpages[count].GetQcount() >= 3 &&
           Tabpages[count].GetQcount() < 6)
        {
            us.Location = new System.Drawing.Point(430, 50 + (Tabpages[count].GetQcount() * 200));
            Tabpages[count].getTabpage().Controls.Add(us);
        }
        else
        {
            us.Location = new System.Drawing.Point(30, 50 + Tabpages[count].GetQcount() * 200);
            Tabpages[count].getTabpage().Controls.Add(us);
        }
    }

        private void Number_SelectBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Ttitle_SelectBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Type_SelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //q1.Setqus(new shot_answer1());
        }

        private void Count_SelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q1.SetNumber(Number_SelectBox.Text);
            q1.SetTitle(Ttitle_SelectBox.Text);
            q1.SetTypes(Type_SelectBox.Text);
            q1.SetarticleC(Int32.Parse(Count_SelectBox.Text));
            string[] bb = CountList_SelectBox.Text.Split(new char[] { ',' });
            q1.Setarticle_List(bb);
        }

        private void CountList_SelectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Content_SelcetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Question_PushButton_Click(object sender, EventArgs e)
        {
           
            if (q1.BringType().Equals("단답형"))
            {
                Console.WriteLine(q1.BringType());
                shot_answer1 sh1 = new shot_answer1();
                sh1.SettingControl(q1.GetTitle(), q1.GetNumber(), q1.Getarticle_List());
                AddtabPage(sh1);
               /* if (Tabpages[count].GetQcount() == 6)
                {
                    MessageBox.Show("No");
                }
                else if (Tabpages[count].GetQcount() >= 3 &&
                   Tabpages[count].GetQcount() < 6)
                {
                    sh1.Location = new System.Drawing.Point(430, 50 + (Tabpages[count].GetQcount() * 200));
                    Tabpages[count].getTabpage().Controls.Add(sh1);
                }
                else
                {
                    sh1.Location = new System.Drawing.Point(30, 50 + Tabpages[count].GetQcount() * 200);
                    Tabpages[count].getTabpage().Controls.Add(sh1);
                }*/
            }
            
        }
    }
}


//https://blog.minjae.kr/173