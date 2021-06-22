using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSurvey
{
    public partial class Question
    {

        int score;
        string number;
        string[] content;
        string[] article_List;
        string type;
        int articleC;
        string title;
        UserControl qus;

        public Point Location { get; internal set; }

        public Question()
        {

        }

        public Question(string number, string type, string title, int articleC, string[] article_List)
        {
            this.number = number;
            this.title = title;
            this.type = type;
            this.articleC = articleC;
            this.article_List = article_List;
        }

        public string GetNumber()
        {
            return this.number;
        }
        public void SetNumber(string n)
        {
            this.number = n;
        }

        public string GetTypes()
        {
            return this.type;
        }
        public void SetTypes(string n)
        {
            this.type = n;
        }

        public UserControl Getqus()
        {
            return this.qus;
        }
        public void Setqus(UserControl qus)
        {
            this.qus = qus;
        }

        public int Getcount()
        {
            return this.articleC;
        }       
        public void SetarticleC(int articleC)
        {
            this.articleC = articleC;
        }

        public string GetTitle()
        {
            return this.title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string[] Getarticle_List()
        {
            return this.article_List;
        }
        public void Setarticle_List(string[] article_List)
        {
            this.article_List = article_List;
        }

        public string BringType()
        {
            return this.type;
        }
        public void SetType(string type)
        {
            this.type = type;
        }

        public int Getscore()
        {
            return this.score;
        }
        public void SetScore(int score)
        {
            this.score = score;
        }
    }
}
