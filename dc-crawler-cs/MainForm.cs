/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

using dc_crawler_cs.DCInside;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            ColumnSorter.InitListView(ArticleList);

            ServicePointManager.DefaultConnectionLimit = 1048576;
            Task.Run(() => InitGalleryListAsync());
        }

        #region 초기화

        SortedDictionary<string, GalleryList.DCGallery> gallery_list;
        private async void InitGalleryListAsync()
        {
            gallery_list = await DCInside.GalleryList.GetGalleryListAsync();
            this.Post(() =>
            {
                foreach (var gallery in gallery_list)
                {
                    GalleryList.AutoCompleteCustomSource.Add($"{gallery.Key} ({gallery.Value.identification})");
                    GalleryList.Items.Add($"{gallery.Key} ({gallery.Value.identification})");
                }
            });
        }

        #endregion

        #region 게시글 로드

        List<Gallery.DCMapStructure> articles;
        Queue queue;
        
        private void DownloadCallback(string url, string result)
        {
            this.Post(() =>
            {
                StatusBar.Value += 1;
                StatusText.Text = $"다운로드: {url}";
                articles.AddRange(Gallery.ParseGalleryArticles(result));

                if (StatusBar.Value == StatusBar.Maximum)
                {
                    articles.Sort((a, b) => Convert.ToInt32(b.notice).CompareTo(Convert.ToInt32(a.notice)));

                    List<ListViewItem> lvil = new List<ListViewItem>();
                    foreach (var item in articles)
                    {
                        lvil.Add(new ListViewItem(new string[]
                        {
                            item.notice,
                            Common.ReplaceEntity(item.title),
                            item.author,
                            item.dates.ToString("yyyy-MM-dd tt hh:mm:ss"),
                            item.comments.ToString(),
                            item.clicks.ToString(),
                            item.star.ToString()
                        }));
                        if (item.level == 1)
                            lvil.Last().BackColor = Color.LightGray;
                        else if (item.level == 2)
                            lvil.Last().BackColor = Color.LightGoldenrodYellow;
                    }
                    ArticleList.Items.Clear();
                    ArticleList.Items.AddRange(lvil.ToArray());
                }
            });
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            string gallery_name = GalleryList.Text.Split('(')[0].TrimEnd();
            
            if (!gallery_list.ContainsKey(gallery_name))
            {
                MessageBox.Show("존재하지 않는 갤러리입니다!", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StatusBar.Value = 0;
            StatusBar.Maximum = (int)(numLastPage.Value - numStartPage.Value + 1);

            articles = new List<Gallery.DCMapStructure>();

            queue = new Queue(DownloadCallback);

            for (int i = (int)(numStartPage.Value); i <= (int)(numLastPage.Value); i++)
            {
                queue.Add(Gallery.GetGalleryUrl(gallery_list[gallery_name].identification, i.ToString()));
            }
        }

        private void ArticleList_DoubleClick(object sender, EventArgs e)
        {
            if (ArticleList.SelectedItems.Count > 0)
            {
                string gallery_name = GalleryList.Text.Split('(')[0].TrimEnd();

                Process.Start($"http://gall.dcinside.com/board/view/?id={gallery_list[gallery_name].identification}&no={ArticleList.SelectedItems[0].Text}");
            }
        }

        #endregion

        #region 글작성

        IWebDriver driver;

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (driver == null)
            {
                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(chromeDriverService, new ChromeOptions());
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.dcinside.com/";
            driver.FindElement(By.Name("user_id")).SendKeys(tbId.Text);
            driver.FindElement(By.Name("password")).SendKeys(tbPW.Text);
            driver.FindElement(By.Id("login_ok")).Click();
        }

        private void bWriteEnd_Click(object sender, EventArgs e)
        {
            WriteTimer.Stop();
        }

        private void bWriteStart_Click(object sender, EventArgs e)
        {
            WriteTimer.Start();
        }

        private void WriteTimer_Tick(object sender, EventArgs e)
        {
            string gallery_name = GalleryList.Text.Split('(')[0].TrimEnd();
            driver.Url = "http://gall.dcinside.com/board/write/?id=" + gallery_list[gallery_name].identification;

            driver.FindElement(By.Name("subject")).SendKeys($"글쓰기 테스트 ㅇㅅㅇ");
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='tx_canvas_wysiwyg']")));
            driver.FindElement(By.TagName("body")).SendKeys("자동 글쓰기 테스트 중입니다.");
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.XPath("//input[@src='http://nstatic.dcinside.com/dgn/gallery/images/btn_save.gif']")).Click();
        }

        #endregion

    }

}
