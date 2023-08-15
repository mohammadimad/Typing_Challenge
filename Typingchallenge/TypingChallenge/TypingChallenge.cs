using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TypingChallenge
{
    public partial class TypingChallenge : Form
    {
        public TypingChallenge()
        {
            InitializeComponent();
        }

        // array with random strings  
        string[] RandomStrings = new string[15];
        // counter 
        int Counter = 0;
        // rand function 
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

        // when program starts or restart challenge this code will excueted
        void ChangeCounterByDiffcultySettings()
        {
            if (lblDiffculty.Text == "Easy")
                Counter = 45;
            else if (lblDiffculty.Text == "Meduim")
                Counter = 35;
            else 
                Counter = 20;
        }

        void ChangeCounter()
        {
            ChangeCounterByDiffcultySettings();
            lblTimer.Text = Counter.ToString();
        }
      
        // every second the counter--
        void ChangeTimer()
        {
            Counter--;
            lblTimer.Text = Counter.ToString();
        }

        // restart challenge 
        void RestartChallenge()
        {
            TxtWords.Text = RandomStrings[Rand.Next(0, 14)];
            TxtChallenge.Text = String.Empty;
            lblStatus.Text = "In Progress";
            lblStatus.ForeColor = Color.Black;
            btnStart.Enabled = true;
            ChangeCounter();
        }

        // start challenge will make timer enabled and txtchallenge will be enabled and focus
        void StartChallenge()
        {
            TxtChallenge.Enabled = true;
            TxtChallenge.Focus();
            timer1.Enabled = true;
        }


        bool IsCounterEqualToZero()
        {
            return Counter == 0;
        }

        // if timer(counter) == 0 then challenge lost
        void CheckTimer()
        {
            if(IsCounterEqualToZero())
            {

                lblTimer.Text = "0";
                timer1.Enabled = false;
                TxtChallenge.Enabled = false;
                ChangeColor();
                MessageBox.Show("Lose!", "Challenge Over",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnStart.Enabled = false;
            }
        }
        // with every load we assign values and random string in Wordstxt
        private void TypingChallenge_Load(object sender, EventArgs e)
        {
            
            AssignArrayValues();
            TxtWords.Text = RandomStrings[Rand.Next(0, 14)];
            ChangeCounter();
        }

        // close the form and return to main screen
        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartChallenge();
        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartChallenge();
        }

        // after every second in program this event will call and we will change timer then check timer in every event called
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeTimer();
            CheckTimer();
        }

        // check all text in TxtWords and Compare Them to TxtChallenge;
        bool CheckTextChallenge()
        {
            // if TxtChallenge index i not equal to txtwords index i then return false and so on ;
            for(byte i = 0;i<TxtChallenge.Text.Length;i++)
            {
                if (!(TxtChallenge.Text[i] == TxtWords.Text[i]))
                    return false;
            }

            // if all Chars(TextChallenge) equal to all Chars(TextWords (index 0 To index TextChallange.Text)) the return false and so on on every
            // event changed

            return true;
        }

        bool CheckTextChallengeLength()
        {
            return TxtChallenge.Text.Length == TxtWords.Text.Length;
        }

        void ChangeColor(bool IsEqualTo = false)
        {
            if(IsEqualTo)
            {
                TxtChallenge.ForeColor = Color.Green;
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Equal";
            }
            else
            {
                TxtChallenge.ForeColor = Color.Red;
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Not Equal!";
            }
        }

        void WinChallenge()
        {
            timer1.Enabled = false;
            btnStart.Enabled = false;
            MessageBox.Show("You've Win The Challenge.", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtChallenge.Enabled = false;
        }
        private void TxtChallenge_TextChanged(object sender, EventArgs e)
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
    }
}
