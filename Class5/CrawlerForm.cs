using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class5
{
    public partial class CrawlerForm : Form
    {
        private Crawler crawler;

        public CrawlerForm()
        {
            InitializeComponent();
        }

        private void Crawl_Btn_Click(object sender, EventArgs e)
        {
            crawler = new Crawler(Url_TB.Text);
            crawlerBindingSource.DataSource = crawler.ValidUrlList;
            crawlerBindingSource1.DataSource = crawler.InvallidUrList;
            crawler.CrawlinglEvent = this.CrawlingEvent;
            new Thread(crawler.Crawl).Start();
        }

        public void CrawlingEvent(string url)
        {
            if (Url_DVG.InvokeRequired)
            {
                Action action = RefreshDGV;
                this.Invoke(action);
            }
        }

        public void RefreshDGV()
        {
             crawlerBindingSource.ResetBindings(false);
             crawlerBindingSource1.ResetBindings(false);
        }
    }
}
