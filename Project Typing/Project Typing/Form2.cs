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

        private void lblChar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChar.Top += speed;
            if(lblChar.Top >= gamePanel.Height)
            {
                lblChar.Location = getNewPoint();
                counter++;
                
                if (counter == 3)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Game Over");

                }

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
                lblScore.Text = "Score:" + score;
                lblChar.Location = getNewPoint();
                lblChar.Text = GetRandomChar().ToString().ToUpper();
                if (score % 25 ==0)
                { 
                    if(speed < 5 * ((score / 25)+1))
                    {
                        speed = 5 * ((score / 25)+1);
                    }
                }
                    
                

            }
            else
            {
                score -= 5;
                lblScore.Text = "Score:" + score;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
