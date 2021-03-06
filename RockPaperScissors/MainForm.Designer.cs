﻿namespace RockPaperScissors
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rock = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Label_Player_Choice = new System.Windows.Forms.Label();
            this.Paper = new System.Windows.Forms.Button();
            this.Label_AI_Choice = new System.Windows.Forms.Label();
            this.Label_Result = new System.Windows.Forms.Label();
            this.Label_Score_Win = new System.Windows.Forms.Label();
            this.Label_Score_Draw = new System.Windows.Forms.Label();
            this.Label_Score_Lose = new System.Windows.Forms.Label();
            this.CopyRight = new System.Windows.Forms.Label();
            this.Picture_Player = new System.Windows.Forms.PictureBox();
            this.Picture_AI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_AI)).BeginInit();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(16, 293);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(75, 23);
            this.Rock.TabIndex = 0;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(502, 293);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(75, 23);
            this.Scissors.TabIndex = 2;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Label_Player_Choice
            // 
            this.Label_Player_Choice.AutoSize = true;
            this.Label_Player_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Player_Choice.Location = new System.Drawing.Point(342, 251);
            this.Label_Player_Choice.Name = "Label_Player_Choice";
            this.Label_Player_Choice.Size = new System.Drawing.Size(92, 20);
            this.Label_Player_Choice.TabIndex = 3;
            this.Label_Player_Choice.Text = "YourChoice";
            this.Label_Player_Choice.Click += new System.EventHandler(this.Label_Player_Choice_Click);
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(260, 293);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(75, 23);
            this.Paper.TabIndex = 4;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Label_AI_Choice
            // 
            this.Label_AI_Choice.AutoSize = true;
            this.Label_AI_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_AI_Choice.Location = new System.Drawing.Point(342, 13);
            this.Label_AI_Choice.Name = "Label_AI_Choice";
            this.Label_AI_Choice.Size = new System.Drawing.Size(93, 20);
            this.Label_AI_Choice.TabIndex = 5;
            this.Label_AI_Choice.Text = "TheirChoice";
            this.Label_AI_Choice.Click += new System.EventHandler(this.Label_AI_Choice_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Result.Location = new System.Drawing.Point(256, 134);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(55, 20);
            this.Label_Result.TabIndex = 6;
            this.Label_Result.Text = "Result";
            // 
            // Label_Score_Win
            // 
            this.Label_Score_Win.AutoSize = true;
            this.Label_Score_Win.Location = new System.Drawing.Point(499, 108);
            this.Label_Score_Win.Name = "Label_Score_Win";
            this.Label_Score_Win.Size = new System.Drawing.Size(26, 13);
            this.Label_Score_Win.TabIndex = 7;
            this.Label_Score_Win.Text = "Win";
            this.Label_Score_Win.Click += new System.EventHandler(this.Label_Score_Win_Click);
            // 
            // Label_Score_Draw
            // 
            this.Label_Score_Draw.AutoSize = true;
            this.Label_Score_Draw.Location = new System.Drawing.Point(499, 161);
            this.Label_Score_Draw.Name = "Label_Score_Draw";
            this.Label_Score_Draw.Size = new System.Drawing.Size(32, 13);
            this.Label_Score_Draw.TabIndex = 8;
            this.Label_Score_Draw.Text = "Draw";
            this.Label_Score_Draw.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Score_Lose
            // 
            this.Label_Score_Lose.AutoSize = true;
            this.Label_Score_Lose.Location = new System.Drawing.Point(499, 134);
            this.Label_Score_Lose.Name = "Label_Score_Lose";
            this.Label_Score_Lose.Size = new System.Drawing.Size(30, 13);
            this.Label_Score_Lose.TabIndex = 9;
            this.Label_Score_Lose.Text = "Lose";
            // 
            // CopyRight
            // 
            this.CopyRight.AutoSize = true;
            this.CopyRight.Location = new System.Drawing.Point(13, 13);
            this.CopyRight.Name = "CopyRight";
            this.CopyRight.Size = new System.Drawing.Size(62, 13);
            this.CopyRight.TabIndex = 10;
            this.CopyRight.Text = "HahaTTpro";
            this.CopyRight.Click += new System.EventHandler(this.CopyRight_Click);
            // 
            // Picture_Player
            // 
            this.Picture_Player.Location = new System.Drawing.Point(260, 221);
            this.Picture_Player.Name = "Picture_Player";
            this.Picture_Player.Size = new System.Drawing.Size(50, 50);
            this.Picture_Player.TabIndex = 11;
            this.Picture_Player.TabStop = false;
            // 
            // Picture_AI
            // 
            this.Picture_AI.Location = new System.Drawing.Point(260, 13);
            this.Picture_AI.Name = "Picture_AI";
            this.Picture_AI.Size = new System.Drawing.Size(50, 50);
            this.Picture_AI.TabIndex = 12;
            this.Picture_AI.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 328);
            this.Controls.Add(this.Picture_AI);
            this.Controls.Add(this.Picture_Player);
            this.Controls.Add(this.CopyRight);
            this.Controls.Add(this.Label_Score_Lose);
            this.Controls.Add(this.Label_Score_Draw);
            this.Controls.Add(this.Label_Score_Win);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Label_AI_Choice);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Label_Player_Choice);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
            this.Name = "MainForm";
            this.Text = "Rock-paper-scissors v1.00";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_AI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Scissors;
        public System.Windows.Forms.Label Label_Player_Choice;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Label Label_AI_Choice;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.Label Label_Score_Win;
        private System.Windows.Forms.Label Label_Score_Draw;
        private System.Windows.Forms.Label Label_Score_Lose;
        private System.Windows.Forms.Label CopyRight;
        private System.Windows.Forms.PictureBox Picture_Player;
        private System.Windows.Forms.PictureBox Picture_AI;
    }
}

