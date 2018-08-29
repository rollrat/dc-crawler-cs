/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace dc_crawler_cs
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Text += Version.Text;
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.dcinside.com/";
            driver.FindElement(By.Name("user_id")).SendKeys("qscsq1");
            driver.FindElement(By.Name("password")).SendKeys("guswns1");
            driver.FindElement(By.Id("login_ok")).Click();

            for (int i = 0; i < 10; i++)
            {
                driver.Url = "http://gall.dcinside.com/board/write/?id=ani1_new1";
                driver.FindElement(By.Name("subject")).SendKeys($"글쓰기 테스트 {i} ㅇㅅㅇ");
                driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='tx_canvas_wysiwyg']")));
                driver.FindElement(By.TagName("body")).SendKeys("자동 글쓰기 테스트 중입니다.");
                driver.SwitchTo().DefaultContent();
                driver.FindElement(By.XPath("//input[@src='http://nstatic.dcinside.com/dgn/gallery/images/btn_save.gif']")).Click();
                Thread.Sleep(1000);
            }
        }
    }
}
