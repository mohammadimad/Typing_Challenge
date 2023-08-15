using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typingchallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string QuizzLevel;
        private void Form1_Load(object sender, EventArgs e)
        {
            cbQuestionLevel.SelectedIndex = 0;
        }

        
           

        private void button1_Click(object sender, EventArgs e)
        {
            QuizzLevel = cbQuestionLevel.Text;
            Form frm10 = new frmProcessChallenge(QuizzLevel);
            this.Hide();
            frm10.ShowDialog();
            this.Close();
        }
    }
}
