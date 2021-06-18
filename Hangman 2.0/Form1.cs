using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_2._0
{
    public partial class Form1 : Form
    {

        private Bitmap[] stickman = { Hangman_2._0.Properties.Resources.stickman1, Hangman_2._0.Properties.Resources.stickman2, Hangman_2._0.Properties.Resources.stickman3, Hangman_2._0.Properties.Resources.stickman4, Hangman_2._0.Properties.Resources.stickman5, Hangman_2._0.Properties.Resources.stickman6, Hangman_2._0.Properties.Resources.stickman7
        , Hangman_2._0.Properties.Resources.stickman8, Hangman_2._0.Properties.Resources.stickman9, Hangman_2._0.Properties.Resources.stickman10};
        int guessLetter = 0;

        private string[] words = { "Arigato ", "Yoi tsuitachi", "konnichiwakonnichiwa", "gomen nasai", "sumimasen"
                                   ," hon" ,"beddo " ," tanjōby" ," tokei" ," namae" ,"kirei" ,"kuroi " ," shiroi" ," eigo" ," daigaku"  };
        private string[] meanig = {"Hint :Thank you ", "Hint :Good day ", "Hint :Hello hello", "Hint :Sorry", "Hint :Excuse me","Book "
                                   ,"Hint :  Bed"," Hint :Birthday","Hint : Watch, clock"," Hint :Name"," Hint :Beautiful","  Hint :Black"," Hint :White"," Hint :English"," Hint :University"

        };

        string displayWord;
        Random rdm = new Random();

        private void showWord() {

            int rmWord = rdm.Next(0, words.Length);
            displayWord= words[rmWord];
            string hint = meanig[rmWord];
            lbl1.Text = hint;

            string fillIn = "";
            for (int i = 0; i < displayWord.Length; i++) {

                fillIn += "_"+" ";
            }
            lblWord.Text = fillIn;

        }


        public Form1()
        {
            InitializeComponent();
        }












        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button btn = new Button();

           

            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else {
                lbl1.Text = "The Japanese Word was  "+displayWord+"  Please try again ";
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + ". Please try again ";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "Wrong Guess, Please try again";
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again "; ;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            guessLetter++;
            if (guessLetter < 10)
            {
                picBx.Image = stickman[guessLetter];
            }
            else
            {
                lbl1.Text = "The Japanese Word was  " + displayWord + "  Please try again ";
                //MessageBox.Show("the Japanese"+displayWord);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 menu = new Form3();
            menu.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            showWord();
            guessLetter = 0;
            picBx.Image = stickman[0];
        }
    }
}
