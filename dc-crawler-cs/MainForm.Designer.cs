namespace dc_crawler_cs
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MainTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Label3 = new System.Windows.Forms.Label();
            this.numLastPage = new System.Windows.Forms.NumericUpDown();
            this.numStartPage = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ArticleList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bLoad = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.GalleryList = new System.Windows.Forms.ComboBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.bWriteStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbPW = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.WriteTimer = new System.Windows.Forms.Timer(this.components);
            this.bWriteEnd = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLastPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(678, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(468, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Copyright (C) 2018. DCInside Programming Gallery Union. All Rights Reserved.";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.metroTabPage1);
            this.MainTab.Controls.Add(this.metroTabPage2);
            this.MainTab.Location = new System.Drawing.Point(10, 59);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1136, 551);
            this.MainTab.Style = MetroFramework.MetroColorStyle.Green;
            this.MainTab.TabIndex = 4;
            this.MainTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MainTab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.Label3);
            this.metroTabPage1.Controls.Add(this.numLastPage);
            this.metroTabPage1.Controls.Add(this.numStartPage);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.ArticleList);
            this.metroTabPage1.Controls.Add(this.bLoad);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.GalleryList);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 3;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1128, 509);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "게시글";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(540, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(15, 15);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "~";
            // 
            // numLastPage
            // 
            this.numLastPage.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.numLastPage.Location = new System.Drawing.Point(561, 12);
            this.numLastPage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLastPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLastPage.Name = "numLastPage";
            this.numLastPage.Size = new System.Drawing.Size(83, 25);
            this.numLastPage.TabIndex = 23;
            this.numLastPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numStartPage
            // 
            this.numStartPage.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.numStartPage.Location = new System.Drawing.Point(451, 12);
            this.numStartPage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numStartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartPage.Name = "numStartPage";
            this.numStartPage.Size = new System.Drawing.Size(83, 25);
            this.numStartPage.TabIndex = 22;
            this.numStartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(365, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 25);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "페이지 : ";
            // 
            // ArticleList
            // 
            this.ArticleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ArticleList.FullRowSelect = true;
            this.ArticleList.GridLines = true;
            this.ArticleList.Location = new System.Drawing.Point(9, 44);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(1110, 425);
            this.ArticleList.TabIndex = 20;
            this.ArticleList.UseCompatibleStateImageBehavior = false;
            this.ArticleList.View = System.Windows.Forms.View.Details;
            this.ArticleList.DoubleClick += new System.EventHandler(this.ArticleList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "고유번호";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제목";
            this.columnHeader2.Width = 521;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "작성자";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "날짜";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 176;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "댓글";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "조회수";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "추천";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bLoad.Location = new System.Drawing.Point(957, 13);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(162, 25);
            this.bLoad.TabIndex = 19;
            this.bLoad.Text = "불러오기";
            this.bLoad.UseSelectable = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(9, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "갤러리 : ";
            // 
            // GalleryList
            // 
            this.GalleryList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.GalleryList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.GalleryList.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.GalleryList.FormattingEnabled = true;
            this.GalleryList.Location = new System.Drawing.Point(94, 13);
            this.GalleryList.Name = "GalleryList";
            this.GalleryList.Size = new System.Drawing.Size(237, 25);
            this.GalleryList.TabIndex = 16;
            this.GalleryList.Text = "HIT";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.bWriteEnd);
            this.metroTabPage2.Controls.Add(this.bWriteStart);
            this.metroTabPage2.Controls.Add(this.richTextBox1);
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.bLogin);
            this.metroTabPage2.Controls.Add(this.tbPW);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.tbId);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 6;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1128, 509);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "글작성";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // bWriteStart
            // 
            this.bWriteStart.Location = new System.Drawing.Point(721, 161);
            this.bWriteStart.Name = "bWriteStart";
            this.bWriteStart.Size = new System.Drawing.Size(198, 43);
            this.bWriteStart.TabIndex = 27;
            this.bWriteStart.Text = "시작";
            this.bWriteStart.UseVisualStyleBackColor = true;
            this.bWriteStart.Click += new System.EventHandler(this.bWriteStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(152, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(468, 199);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(152, 138);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(468, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTextBox1.TabIndex = 25;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(86, 161);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 25);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "내용 : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(86, 136);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 25);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "제목 : ";
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(721, 45);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(198, 43);
            this.bLogin.TabIndex = 22;
            this.bLogin.Text = "로그인";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbPW
            // 
            this.tbPW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbPW.CustomButton.Image = null;
            this.tbPW.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.tbPW.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPW.CustomButton.Name = "";
            this.tbPW.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.tbPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPW.CustomButton.TabIndex = 1;
            this.tbPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPW.CustomButton.UseSelectable = true;
            this.tbPW.CustomButton.Visible = false;
            this.tbPW.Lines = new string[0];
            this.tbPW.Location = new System.Drawing.Point(152, 72);
            this.tbPW.MaxLength = 32767;
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '\0';
            this.tbPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPW.SelectedText = "";
            this.tbPW.SelectionLength = 0;
            this.tbPW.SelectionStart = 0;
            this.tbPW.ShortcutsEnabled = true;
            this.tbPW.Size = new System.Drawing.Size(468, 23);
            this.tbPW.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbPW.TabIndex = 21;
            this.tbPW.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPW.UseSelectable = true;
            this.tbPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(50, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 25);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "비밀번호 : ";
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbId.CustomButton.Image = null;
            this.tbId.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.tbId.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbId.CustomButton.Name = "";
            this.tbId.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.tbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbId.CustomButton.TabIndex = 1;
            this.tbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbId.CustomButton.UseSelectable = true;
            this.tbId.CustomButton.Visible = false;
            this.tbId.Lines = new string[0];
            this.tbId.Location = new System.Drawing.Point(152, 37);
            this.tbId.MaxLength = 32767;
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbId.SelectedText = "";
            this.tbId.SelectionLength = 0;
            this.tbId.SelectionStart = 0;
            this.tbId.ShortcutsEnabled = true;
            this.tbId.Size = new System.Drawing.Size(468, 23);
            this.tbId.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbId.TabIndex = 19;
            this.tbId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbId.UseSelectable = true;
            this.tbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(68, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 25);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "아이디 : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusBar,
            this.StatusText});
            this.statusStrip1.Location = new System.Drawing.Point(20, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1116, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "상태:";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(34, 17);
            this.StatusText.Text = "ㅡ,ㅡ";
            // 
            // WriteTimer
            // 
            this.WriteTimer.Interval = 30000;
            this.WriteTimer.Tick += new System.EventHandler(this.WriteTimer_Tick);
            // 
            // bWriteEnd
            // 
            this.bWriteEnd.Location = new System.Drawing.Point(721, 243);
            this.bWriteEnd.Name = "bWriteEnd";
            this.bWriteEnd.Size = new System.Drawing.Size(198, 43);
            this.bWriteEnd.TabIndex = 28;
            this.bWriteEnd.Text = "끝";
            this.bWriteEnd.UseVisualStyleBackColor = true;
            this.bWriteEnd.Click += new System.EventHandler(this.bWriteEnd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 616);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1156, 616);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 25);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "DC Crawler ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLastPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        internal System.Windows.Forms.ComboBox GalleryList;
        private MetroFramework.Controls.MetroButton bLoad;
        private System.Windows.Forms.ListView ArticleList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown numLastPage;
        internal System.Windows.Forms.NumericUpDown numStartPage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button bLogin;
        private MetroFramework.Controls.MetroTextBox tbPW;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbId;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Timer WriteTimer;
        private System.Windows.Forms.Button bWriteStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button bWriteEnd;
    }
}

