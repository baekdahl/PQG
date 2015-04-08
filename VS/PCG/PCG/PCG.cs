using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace PCG
{
    public partial class PCG : Form
    {
        public PCG()
        {
            InitializeComponent();
            _PCG = this;
        }

        public static PCG _PCG;

        public void update(string message)
        {
            rtb1.AppendText(message);
            MessageBox.Show(message);
        }

        private void PCG_Load(object sender, EventArgs e)
        {
            Knowledge Quest1 = new Knowledge(RandomNumberGenerator.NumberBetween(0, 4));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Knowledge Quest1 = new Knowledge(RandomNumberGenerator.NumberBetween(0, 4));

        }

        /// <summary>
        /// Used to keep the Rich Text Box (Text log) scrolling down automatically
        /// </summary>
        private void ScrollToBottomOfMessages()
        {
            rtb1.SelectionStart = rtb1.Text.Length;
            rtb1.ScrollToCaret();
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            ScrollToBottomOfMessages();
        }
    }
}
