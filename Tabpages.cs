using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSurvey
{
    public class Tabpages
    {
        TabPage TabPage;
        int QCount;
        string Qtitle;
       public Tabpages(int Qcount)
        {
            
            QCount = 0;
        }
        public TabPage getTabpage()
        {
            return TabPage;
        }
        public int GetQcount()
        {
            return QCount;
        }
        public void SetOneQcount()
        {
            this.QCount += 1;
        }
        public string GetQtitle()
        {
            return Qtitle;
        }
        public void SetTitle(string title)
        {
            this.Qtitle = title;
        }
        public TabPage makeTabpage(int idx)
        {
            string pageName = string.Format("page{0}", idx);
            this.TabPage = new TabPage(pageName);
            //this.TabPage.Size = new Size(593, 793);
            return TabPage;
        }
    }
}
