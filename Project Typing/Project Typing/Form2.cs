using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Typing
{
    public partial class Form2 : Form
    {
        int score = 0;
        int counter = 0;
        int speed = 5;
        public Form2()
        {
            InitializeComponent();
            gameTimer.Start();
            lblChar.Location = getNewPoint();
            lblChar.Text = GetRandomChar().ToString().ToUpper();
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void game_over()
        {
            this.Hide();
            Form f1 = new Form1();
            f1.ShowDialog();
        }
        private void lblChar_Click(object sender, EventArgs e)
        {

        }
        private void handleFail()
        {
            if (score - 5 >= 0)
            {
                score -= 5;
            }
            lblScore.Text = "Score: " + score;
            counter++;
            switch (counter)
            {
                case 1:
                    lblLives.Text = "Lives: O O X";
                    break;
                case 2:
                    lblLives.Text = "Lives: O X X";
                    break;
                case 3:
                    lblLives.Text = "Lives: X X X";
                    gameTimer.Stop();
                    string message = "Score: " + score;
                    if (score > Globals.high_score)
                    {
                        Globals.high_score = score;
                        message = "New High Score: " + score;
                        Globals.save_file();
                    }
                    string title = "Game Over";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        game_over();

                    }
                    break;
            }
            lblChar.Location = getNewPoint();
            lblChar.Text = GetRandomChar().ToString().ToUpper();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChar.Top += speed;
            if(lblChar.Top >= gamePanel.Height)
            {
                handleFail();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        Random xlocation = new Random();
        private Point getNewPoint()
        {
            int x = xlocation.Next(0, gamePanel.Width-lblChar.Width);
            return new Point(x, 0);
        }
        Random RandomChar = new Random();
        private char GetRandomChar()
        {
            return (char)RandomChar.Next(97, 123);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userPressKey = e.KeyChar;
            if(lblChar.Text == userPressKey.ToString().ToUpper())
            {
                score += 5;
                lblScore.Text = "Score: " + score;
                lblChar.Location = getNewPoint();
                lblChar.Text = GetRandomChar().ToString().ToUpper();
                if (score % 25 ==0)
                { 
                    if(speed < 2 * ((score / 25)+1))
                    {
                        speed = 2 * ((score / 25)+1);
                    }
                }
            }
            else
            {
                handleFail();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
