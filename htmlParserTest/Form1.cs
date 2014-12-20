using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.IO;

namespace htmlParserTest
{
    public partial class Form1 : Form
    {
        private int Savepage = 1;
        private List<string> content = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int NowPage = 0;
            try
            {
                state.Text = "";
                Savepage = 1;
                content = new List<string>();
                if (Regex.IsMatch(web.Text, @"^[0-9]{7,7}?$+") && Regex.IsMatch(howPage.Text, @"^[1-9]$"))
                {
                    HtmlWeb webClient = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = webClient.Load(@"http://ck101.com/thread-" + web.Text + @"-1-1.html");
                    //HtmlNode node = doc.GetElementbyId("pgt");
                    string TotalPage = doc.DocumentNode.SelectSingleNode(@"/html[1]/body[1]/div[9]/div[5]/div[1]/table[1]/tr[1]/td[1]/div[1]/div[1]/a[10]").InnerText;
                    if (TotalPage.Contains("... "))
                    {
                        TotalPage = TotalPage.Replace("... ", "");
                    }
                    for (NowPage = Convert.ToInt32(startPage.Text); NowPage <= Convert.ToByte( TotalPage); NowPage++)
                    {
                        catchContent(webClient, NowPage, Convert.ToByte(TotalPage));
                    }
                    state.Text += "Done\r\n";
                }
                else
                {
                    MessageBox.Show("Format Error \r\n請輸入小說編號 \r\n例如: http://ck101.com/thread-3051239-1-1.html \r\n3051239為小說編號");
                }
            }
            catch (HtmlWebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void catchContent( HtmlWeb webClient, int NowPage, int TotalPage)
        {
            try
            {
                state.Text += "Now in Page" + NowPage + "\r\n";
                HtmlAgilityPack.HtmlDocument doc = webClient.Load(@"http://ck101.com/thread-" + web.Text + @"-" + NowPage + "-1.html");
                string name = doc.DocumentNode.SelectSingleNode(@"//hgroup/h1[@id='thread_subject']").InnerText;
                name = name.Remove(name.IndexOf("作者"));
                HtmlNodeCollection contentCollection = doc.DocumentNode.SelectNodes(@"//td[@class='t_f']");
                //var ListDiv = Browser.Divs.Filter(Find.ByClass("t_fsz"));
                foreach (HtmlNode node in contentCollection)
                {
                    string nodeContent = node.InnerText.Replace("&nbsp;", " ");
                    content.Add(nodeContent);
                }
                if (NowPage % Convert.ToInt32(howPage.Text) == 0)
                {
                    writeText(name, NowPage);
                    content = new List<string>();
                }
                else if (NowPage == TotalPage)
                {
                    writeText(name, NowPage);
                }
            }
            catch (HtmlWebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeText(string TextName, int NowPage)
        {
            string CurrentPath = System.Environment.CurrentDirectory;
            state.Text += "Save in Page" + NowPage + "\r\n";
            TextName = CurrentPath + @"\" + TextName;
            DirectoryInfo DB1 = new DirectoryInfo(TextName);
            if (!DB1.Exists)
            {
                DB1.Create();
            }
            StreamWriter sw = new StreamWriter(TextName + @"\" + Savepage + ".txt");
            Savepage++;
            foreach (string text in content)
            {
                sw.WriteLine(text);
            }
            sw.Close();
        }
    }
}
