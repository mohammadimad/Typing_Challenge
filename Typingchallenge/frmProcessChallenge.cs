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
    public partial class frmProcessChallenge : Form
    {
        public frmProcessChallenge(string QuestionLevel)
        {
            InitializeComponent();
            _QuestionLevel = QuestionLevel;
        }
        enum enQuestionLevel { Easy = 0, Medium = 1, Hard = 2 };
        enQuestionLevel QuestionLevel;
        string[] RandomStrings = new string[15];
        string _QuestionLevel;
        int Counter = 0;
        private void frmProcessChallenge_Load(object sender, EventArgs e)
        {
            AssignArrayValues();
            txtdefult.Text = RandomStrings[Rand.Next(0, 14)];
            lblStatus.Text = "In Progress";
            GetQuestionLevel();
            ChangeCounterByDiffcultySettings();
            ChangeCounter();
        }
        Random Rand = new Random();
        void AssignArrayValues()
        {
            RandomStrings[0] = "Long Gaming Is Not Good For Your Health, Please Stop Gaming And Learn Some Programming.";
            RandomStrings[1] = "Making Programs On Desktop,Web and Mobile Is Good Thing For Getting Money After Learning Programming Basics.";
            RandomStrings[2] = "Can You Please Enter Your Name ? You Can't Because You Must Type This Words As It Is And Don't Change Any Word...";
            RandomStrings[3] = ".Net platform Is a great platform built by Microsoft; for making Diffrent Apps Like Mobile,Desktop,Web and IOT.";
            RandomStrings[4] = ".Net Xamarin Is a Platform for making cross-platform mobile apps using C# and it's a great Language for anything.";
            RandomStrings[5] = "Elephants are very big,very cute Animals and you can see them in the jungle or the Zoo. just go see them...";
            RandomStrings[6] = "Lions Are Very Dangerous,Big,Fast Animals and it's Name is the king of the jungle. stay aware of Lions becuase they can kill you.";
            RandomStrings[7] = "Climbing Mountains is great sport , but you must learn it first and be good at it then you can climb mountains.";
            RandomStrings[8] = "Riding Horses is great sport , but you must learn it first and be good at it then you can ride horses like western cowboys.";
            RandomStrings[9] = "Playing push-ups can make you very strong sport, you can start by playing 5 push-ups daily then add to it one every day.";
            RandomStrings[10] = "Just start learn programming with ProgrammingAdvices.Com because it's a very good site for learning programming.";
            RandomStrings[11] = "You can start programming with a med level language like C++ to start Learn The Basics like Functional Programming,OOP";
            RandomStrings[12] = "it's not good : starting programming with very modern language like python or javascript becuase they have large libraries.";
            RandomStrings[13] = "Sports are very good for you'r health i suggest playing sports on Gym or in you'r home and don't be lasy.";
            RandomStrings[14] = "You Can Start Learning Android Apps Development Using Kotlin or Java with Android Studio and MvvM.";
        }
        void ChangeCounterByDiffcultySettings()
        {
            switch (QuestionLevel)
            {
                case enQuestionLevel.Easy:
                   
                    Counter = 45;
                    lblLevel.Text = "Easy";
                    break;
                case enQuestionLevel.Medium:
                   
                    Counter = 35;
                    lblLevel.Text = "Medium";
                    break;
                case enQuestionLevel.Hard:
                    lblLevel.Text = "Hard";
                    Counter = 20;
                    break;
                default:
                    lblLevel.Text = "Easy";
                    Counter = 20;           
                    break;
            }
        }
        void ChangeCounter()
        {
            ChangeCounterByDiffcultySettings();
            lbltimer.Text = Counter.ToString();
        }
        void ChangeTimer()
        {
            Counter--;
            lbltimer.Text = Counter.ToString();
        }
        void RestartChallenge()
        {
            txtdefult.Text = RandomStrings[Rand.Next(0, 14)];
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

        void GetQuestionLevel()
        {
            if (_QuestionLevel == "Easy")
                QuestionLevel = enQuestionLevel.Easy;
            else if (_QuestionLevel == "Medium")
                QuestionLevel = enQuestionLevel.Medium;
            else
                QuestionLevel = enQuestionLevel.Hard;
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
            if (IsCounterEqualToZero())
            {

                lbltimer.Text = "0";
                timer1.Enabled = false;
                txtwrite.Enabled = false;
                ChangeColor();
                MessageBox.Show("Lose!", "Challenge Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart.Enabled = false;
            }
        }
        bool IsCounterEqualToZero()
        {
            return Counter == 0;
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
