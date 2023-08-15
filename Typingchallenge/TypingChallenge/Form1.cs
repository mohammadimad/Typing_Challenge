using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbDiffcultySettings.SelectedIndex = 0;
        }

       
        private void btnStartChallenge_Click(object sender, EventArgs e)
        {
            TypingChallenge TypingChallenge = new TypingChallenge();
            TypingChallenge.lblDiffculty.Text = CbDiffcultySettings.Text;
            TypingChallenge.ShowDialog();
            TypingChallenge.Close();
        }

        private void CbDiffcultySettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
