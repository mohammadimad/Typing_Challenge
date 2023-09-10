using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace Typingchallenge
{
    public partial class frmProcessChallenge : Form
    {
        Class1 class1 = new Class1();
        public frmProcessChallenge(string QuestionLevel)
        {
            InitializeComponent();
            class1._QuestionLevel = QuestionLevel;
        }
        
       
        private void frmProcessChallenge_Load(object sender, EventArgs e)
        {
            
            class1.AssignArrayValues();   
            txtdefult.Text = class1.RandomStrings[class1.Rand.Next(0, 14)];
            lblStatus.Text = "In Progress";
           
            class1.GetQuestionLevel();
            ChangeCounterByDiffcultySettings();
            ChangeCounter();
        }
        void ChangeCounterByDiffcultySettings()
        {
            switch (class1.QuestionLevel)
            {
                case Class1.enQuestionLevel.Easy:

                    class1.Counter = 45;
                    lblLevel.Text = "Easy";
                    break;
                case Class1.enQuestionLevel.Medium:

                    class1.Counter = 35;
                    lblLevel.Text = "Medium";
                    break;
                case Class1.enQuestionLevel.Hard:
                    lblLevel.Text = "Hard";
                    class1.Counter = 20;
                    break;
                default:
                    lblLevel.Text = "Easy";
                    class1.Counter = 20;           
                    break;
            }
        }
        void ChangeCounter()
        {
            ChangeCounterByDiffcultySettings();
            lbltimer.Text = class1.Counter.ToString();
        }
        void ChangeTimer()
        {
            class1.Counter--;
            lbltimer.Text = class1.Counter.ToString();
        }
        void RestartChallenge()
        {
            txtdefult.Text = class1.RandomStrings[class1.Rand.Next(0, 14)];
            txtwrite.Text = String.Empty;
            txtwrite.Enabled = false;
            lblStatus.Text = "In Progress";
            lblStatus.ForeColor = Color.Black;
            btnStart.Enabled = true;
            ChangeCounter();
        }

        bool CheckTextChallenge()
        {
            // if TxtChallenge index i not equal to txtwords index i then return false and so on ;
            for (byte i = 0; i < txtwrite.Text.Length; i++)
            {
                if (!(txtwrite.Text[i] == txtdefult.Text[i]))
                    return false;
            }

            // if all Chars(TextChallenge) equal to all Chars(TextWords (index 0 To index TextChallange.Text)) the return false and so on on every
            // event changed

            return true;
        }
        void ShowGameOver()
        {
            timer1.Enabled = false;
            //panelOptions.Enabled = false;
            txtwrite.Enabled = false;
            MessageBox.Show("Lose", "Challenge Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        
       
        void StartChallenge()
        {
            txtwrite.Enabled = true;
            txtwrite.Focus();
            timer1.Enabled = true;
        }
        void ChangeColor(bool IsEqualTo = false)
        {
            if (IsEqualTo)
            {
                txtwrite.ForeColor = Color.Green;
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Equal";
            }
            else
            {
                txtwrite.ForeColor = Color.Red;
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Not Equal!";
            }
        }
        void WinChallenge()
        {
            timer1.Enabled = false;
            btnStart.Enabled = false;
            MessageBox.Show("You've Win The Challenge.", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtwrite.Enabled = false;
        }

        void CheckTimer()
        {
            if (class1.IsCounterEqualToZero())
            {

                lbltimer.Text = "0";
                timer1.Enabled = false;
                txtwrite.Enabled = false;
                ChangeColor();
                MessageBox.Show("Lose!", "Challenge Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart.Enabled = false;
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen penWhite = new Pen(color);
            penWhite.Width = 5;
            penWhite.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            penWhite.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            e.Graphics.DrawRectangle(penWhite, 4, 7, 513, 154);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen penWhite = new Pen(color);
            penWhite.Width = 5;
            penWhite.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            penWhite.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            e.Graphics.DrawRectangle(penWhite, 4, 7, 513, 154);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeTimer();
            CheckTimer();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartChallenge();
        }
        bool CheckTextChallengeLength()
        {
            return txtwrite.Text.Length == txtdefult.Text.Length;
        }

        private void txtwrite_TextChanged(object sender, EventArgs e)
        {
            // every TextChallenge text Changed Event will walk in for loop and compare if all equal then 
            if (CheckTextChallenge())
            {
                // then check if TxtWords.Length Equal to TxtChallenge.Length this will be considerd to be a win 

                if (CheckTextChallengeLength())
                {
                    // change color to green and show win message box 
                    ChangeColor(true);
                    WinChallenge();
                }
                else
                    // equal but not Lengths are equal change color to green will be considerd 
                    // all chars in TextWords and TextChallenge To TextChallenge.Text Equal To Each Other 
                    // Then its Equal But not Win (to Win The Two Lengths Of Textboxes Must Be Equal To EachOther And All Chars)

                    ChangeColor(true);
            }
            else

                ChangeColor();
        }

        private void btnRestratGame_Click(object sender, EventArgs e)
        {
            RestartChallenge();
            
        }

        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            Form frm10 = new Form1();
            this.Hide();
            frm10.ShowDialog();
            this.Close();
        }
    }
}
