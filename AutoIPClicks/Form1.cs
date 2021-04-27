using KAutoHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;


namespace AutoIPClicks
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbUrl.Focus();
            ckbShopacc.Checked = false;
           
        }
        ChromeDriver chromeDriver;
        //chromeDriver.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
        //chromeDriver.ExecuteScript("window.scrollBy(document.body.scrollHeight,0)");
        //chromeDriver.FindElementByClassName("header__link").Click();
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (CheckInfor())
            {
                int count = (int)nbrTimes.Value;

                for (int i = 0; i < count; i++)
                {
                    if (ckbShopacc.Checked)
                    {
                        ShopAccGame();
                        for (int j = i; j < count - 1; j++)
                        {
                            Loop(chromeDriver);
                        }
                        chromeDriver.Quit();
                        break;
                    }
                    else
                    {
                        YourWeb(txbUrl.Text);
                    }
                }
            }
        }

        private void ShopAccGame()
        {
            string urlshopacc = "https://localhost:44333";
            txbUrl.Text = urlshopacc;
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions opt3 = SetProfile();
             chromeDriver = new ChromeDriver(chromeDriverService, opt3);
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Url = txbUrl.Text;
            chromeDriver.Navigate();

            //open whoer.net
            CheckIP(chromeDriver);
            //IWebElement body = chromeDriver.FindElement(By.TagName("body"));
            //body.SendKeys(Keys.Control + "o");
            //chromeDriver.Keyboard.PressKey(Keys.Control);
            //chromeDriver.Keyboard.PressKey("o");

            //Actions action = new Actions(chromeDriver);
            //action.SendKeys(Keys.Control + "o").;
            // action.SendKeys(chromeDriver.FindElement(By.XPath("//body")), Keys.Control + "o").Build().Perform();


            
        }

        private void CheckIP(ChromeDriver chromeDriver)
        {
            string myip = "https://whoer.net/";
            SendKeys.SendWait("^t");
            chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.Last());
            chromeDriver.Navigate().GoToUrl(myip);
            chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.First());
            ActInShopAcc(chromeDriver);
            chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.Last());
            //chromeDriver.ExecuteScript("window.scrollBy(0,1500)");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            FirstVPN(chromeDriver);
            //Loop(chromeDriver);

            //Thread.Sleep(TimeSpan.FromSeconds(8));
            //Loop(chromeDriver);

            // var button = chromeDriver.FindElementByXPath("/html/body/div/div[3]/div/div[2]/div/div[3]/div[1]/div[1]");
            // button.Click();
            //chromeDriver.Quit();
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            // action.SendKeys("abc").Perform();
            //action.Build();
            // Hola(chromeDriver);
        }

        private void Hola(ChromeDriver a)
        {
            //Use shortkey "Alt + H" to click Hola extention in a toolbar
            Actions action = new Actions(a);
           // action.(OpenQA.Selenium.Keys.Control + "a");

        }


        private void Scroll(ChromeDriver chromeDriver)
        {
            chromeDriver.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            chromeDriver.ExecuteScript("window.scrollBy(500,700)");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            chromeDriver.ExecuteScript("window.scrollBy(700,900)");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            chromeDriver.ExecuteScript("window.scrollBy(900,-2000)");
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        private void ActInShopAcc(ChromeDriver chromeDriver)
        {
            Scroll(chromeDriver);

            var button = chromeDriver.FindElementByXPath("/html/body/header/ul[1]/li[2]/a/div");
            button.Click();
            Scroll(chromeDriver);

            var button2 = chromeDriver.FindElementByXPath("/html/body/div/header/ul[2]/li[2]/a");
            button2.Click();
            //Scroll(chromeDriver);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            chromeDriver.Navigate().Back();
            Thread.Sleep(TimeSpan.FromSeconds(1.5));

        }
        private bool CheckInfor()
        {
            if (string.IsNullOrWhiteSpace(txbUrl.Text))
            {
                MessageBox.Show("Please enter the link of Websites !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUrl.Focus();
                return false;
            }
            else
            {
                if (nbrTimes.Value == 0)
                {
                    MessageBox.Show("Please enter the number of the times!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nbrTimes.Focus();
                    return false;
                }
            }
            return true;
        }

        private ChromeOptions SetProfile()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddExtensions("holavpn.crx");
            options.AddArgument("--user-data-dir=C:/Users/ADMIN/AppData/Local/Google/Chrome/User Data/Profile 2");
            //options.AddArgument("--profile-directory=\"System Profile\"");
            return options;
        }
        private ChromeDriver ReturnChromeDriver(ChromeDriver a)
        {
            ChromeDriver b = a;
            return b;
        }
        private void YourWeb(string a)
        {
            try
            {
                string url = a;
                string myip = "https://whoer.net/";
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeDriver chromeDriver = new ChromeDriver(chromeDriverService,SetProfile());
                chromeDriver.Manage().Window.Maximize();
                chromeDriver.Url = url;
                chromeDriver.Navigate();
                Scroll(chromeDriver);

                //SendKeys.SendWait("^t");
                //chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.Last());
                //chromeDriver.Navigate().GoToUrl(myip);
                //chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.First());
                //chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.Last());
                //Thread.Sleep(TimeSpan.FromSeconds(2));
                //Scroll(chromeDriver);
                Thread.Sleep(TimeSpan.FromSeconds(4));
                // MoWebbrowser();
                //var button = chromeDriver.FindElementByXPath("/html/body/div/div[3]/div/div[2]/div/div[3]/div[1]/div[1]/div[1]");
                //button.Click();
                 chromeDriver.Quit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ckbShopacc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShopacc.Checked)
            {
                txbUrl.Text = "https://localhost:44333";
                txbUrl.Enabled = false;
                nbrTimes.Focus();
            }
            else
            {
                txbUrl.Enabled = true;
                txbUrl.Clear();
                txbUrl.Focus();
            }
        }
        private void ClickHola()
        {
            int x = 1420;
            int y = 50;
            AutoControl.MouseClick(x, y);
        }

        private void ClickFlagVN()
        {
            int x = 1250;
            int y = 350;
            AutoControl.MouseClick(x, y);
        }

        private void ClickOnOff()
        {
            int x = 1400;
            int y = 100;
            AutoControl.MouseClick(x, y);
        }

        private void FirstVPN(ChromeDriver a)
        {
            ClickHola();
            Thread.Sleep(1000);
            ClickFlagVN();
            Thread.Sleep(5000);
            a.Navigate().Refresh();
            Thread.Sleep(10000);
            //ClickHola();
            Thread.Sleep(1000);
            ClickOnOff();
            Thread.Sleep(10000);
        }
        private void Loop(ChromeDriver a)
        {
           ClickOnOff();
            Thread.Sleep(5000);
            a.Navigate().Refresh();
            Thread.Sleep(10000);
           // ClickHola();
            Thread.Sleep(1000);
            ClickOnOff();
            Thread.Sleep(3000);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHttp.Checked)
            {
                txbUrl.Text += ckbHttp.Text;
            }
        }

        private void ckb3w_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb3w.Checked)
            {
                txbUrl.Text += ckb3w.Text;
            }
        }

        private void ckbcom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbcom.Checked)
            {
                txbUrl.Text += ckbcom.Text;
            }
        }

        private void cknnet_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbnet.Checked)
            {
                txbUrl.Text += ckbnet.Text;
            }
        }
    }
}
