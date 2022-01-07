using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(@"C:\web_driver\chromedriver_win32\", options); // jānomaina uz savu ChromeDriver vietu
            //driver = new ChromeDriver(@"D:\Doc\_Lekcijas\_My\Programmaturas Izstrades tehnologijas\Browser_drivers\", options); // Jūsus draiveru lokācija no lekcijām
            driver.Url = "https://www.ebay.com/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Search = textBox1.Text; /// definējam meklēšanas datus

            driver.SwitchTo().DefaultContent(); //drošībai pārejam uz pamata lapu un apejam daudzos iespējamos pop-up logus
            driver.FindElement(By.Id("gh-ac")).SendKeys(Search); //ierakstām meklējamo frāzi
            driver.FindElement(By.Id("gh-btn")).Click(); //nospiešam meklēšanas pogu

            string strUrl = driver.Url; //atrodam aktīvo hipersaiti
            textBox2.AppendText(strUrl); //ierakstam meklētā linka logā
            richTextBox1.AppendText(strUrl + "°\n"); //un pievienojam vēstures sarakstam
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back(); //atgriežamies vēsturē
            textBox1.Clear(); // notīram meklēšanas lauku
            textBox2.Clear(); // notīram linka lauku
        }
        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit(); //aizveram Chrome draiveri un pārlūku
        }


    }
}
