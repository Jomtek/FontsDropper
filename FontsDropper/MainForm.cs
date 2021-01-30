using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontsDropper
{
    public partial class MainForm : Form
    {
        private IWebDriver _driver;

        public MainForm()
        {
            InitializeComponent();

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArgument("--window-position=-32000,-32000");

            _driver = new ChromeDriver(service, options);
        }

        private void ProcessBTN_Click(object sender, EventArgs e)
        {
            try
            {
                _driver.Navigate().GoToUrl(linkTB.Text);
            }
            catch (WebDriverException)
            {
                MessageBox.Show("Invalid link provided");
                return;
            }

            string objectName = linkTB.Text.Split('/').Last().Split('?')[0];

            IWebElement element = null;
            for (int i = 7; i < 26; i++)
            {
                try
                {
                    element = _driver.FindElement(By.CssSelector($".svg-inline--fa.fa-{objectName}.fa-w-{i}.fa-{sizeNUD.Value}x"));
                    break;
                }
                catch (NoSuchElementException)
                {
                    continue;
                }
            }

            if (element == null)
            {
                MessageBox.Show("Couldn't find any SVG matching link and size");
                return;
            }

            var innerHTML = element.FindElement(By.XPath("..")).GetAttribute("innerHTML");
            resultWB.DocumentText = Properties.Resources.htmlSkeleton.Replace("<SVG_HERE>", innerHTML);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var p in Process.GetProcessesByName("chromedriver")) p.Kill();
        }
    }
}
