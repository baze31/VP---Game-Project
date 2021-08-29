
namespace Project_Typing
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lblChar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLives = new System.Windows.Forms.Label();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Black;
            this.gamePanel.Controls.Add(this.lblChar);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamePanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(800, 383);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // lblChar
            // 
            this.lblChar.BackColor = System.Drawing.Color.Yellow;
            this.lblChar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChar.ForeColor = System.Drawing.Color.Red;
            this.lblChar.Location = new System.Drawing.Point(370, 71);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(35, 34);
            this.lblChar.TabIndex = 0;
            this.lblChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChar.Click += new System.EventHandler(this.lblChar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 47);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(681, 402);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 21);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Location = new System.Drawing.Point(549, 407);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(72, 15);
            this.lblLives.TabIndex = 1;
            this.lblLives.Text = "Lives: O O O";
            this.lblLives.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gamePanel);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Type for your life";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.gamePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblLives;
    }
}

