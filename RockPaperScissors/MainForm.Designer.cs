namespace RockPaperScissors
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
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(12, 227);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(75, 23);
            this.Rock.TabIndex = 0;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(323, 227);
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
            this.Label_Player_Choice.Location = new System.Drawing.Point(156, 178);
            this.Label_Player_Choice.Name = "Label_Player_Choice";
            this.Label_Player_Choice.Size = new System.Drawing.Size(92, 20);
            this.Label_Player_Choice.TabIndex = 3;
            this.Label_Player_Choice.Text = "YourChoice";
            this.Label_Player_Choice.Click += new System.EventHandler(this.Label_Player_Choice_Click);
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(159, 227);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(75, 23);
            this.Paper.TabIndex = 4;
            this.Paper.Text = "button1";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Label_AI_Choice
            // 
            this.Label_AI_Choice.AutoSize = true;
            this.Label_AI_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_AI_Choice.Location = new System.Drawing.Point(160, 22);
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
            this.Label_Result.Location = new System.Drawing.Point(159, 102);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(55, 20);
            this.Label_Result.TabIndex = 6;
            this.Label_Result.Text = "Result";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Label_AI_Choice);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Label_Player_Choice);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
            this.Name = "MainForm";
            this.Text = "Rock-paper-scissors";
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
    }
}

