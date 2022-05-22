using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Data_from_website
{
    public partial class Form1 : Form
    {
        class Program
        {
            static void Main(string[] args)
            {
                WebClient client = new WebClient();
                string html = client.DownloadString("http://onet.pl");
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                HtmlNode informationWWW = doc.GetElementbyId("boxRatings");
                if (informationWWW != null)
                {

                    Console.WriteLine(informationWWW.InnerText);
                }
                System.Console.ReadLine();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
