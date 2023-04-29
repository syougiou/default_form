using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// モーダルフォームとして開く
        /// 開いたフォームを閉じるまでは、他のフォームを操作することができないフォーム
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_button_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();

            //親フォームの中心に表示
            about.StartPosition = FormStartPosition.CenterParent;

            //モーダルフォーム
            about.ShowDialog(this);
            about.Dispose();
        }
    }
}
