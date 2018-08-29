/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

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
    }
}
