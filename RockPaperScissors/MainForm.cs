using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Player_Choice_Click(object sender, EventArgs e)
        {
            
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            MainEngine engine = new MainEngine();
          theResult result=  engine.OneTwoThree(1);

          Label_Player_Choice.Text = result.PlayerChoice;
          Label_AI_Choice.Text = result.AIChoice;
            Label_Result.Text = result.ju;
            Image player_choice_img = Image.FromFile(result.PlayerChoice + ".png");
            Picture_Player.Image = player_choice_img;
            Image AI_choice_img = Image.FromFile(result.AIChoice + ".png");
            Picture_AI.Image = AI_choice_img;
          updateScore(engine.getScore());
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            MainEngine engine = new MainEngine();
            theResult result = engine.OneTwoThree(3);
            Label_Player_Choice.Text = result.PlayerChoice;
            Label_AI_Choice.Text = result.AIChoice;
            Label_Result.Text = result.ju;
            Image player_choice_img = Image.FromFile(result.PlayerChoice + ".png");
            Picture_Player.Image = player_choice_img;
            Image AI_choice_img = Image.FromFile(result.AIChoice + ".png");
            Picture_AI.Image = AI_choice_img;

            updateScore(engine.getScore());
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            MainEngine engine = new MainEngine();
            theResult result = engine.OneTwoThree(2);
            Label_Player_Choice.Text = result.PlayerChoice;
            Label_AI_Choice.Text = result.AIChoice;
            Label_Result.Text = result.ju;
            Image player_choice_img = Image.FromFile(result.PlayerChoice + ".png");
            Picture_Player.Image = player_choice_img;
            Image AI_choice_img = Image.FromFile(result.AIChoice + ".png");
            Picture_AI.Image = AI_choice_img;
            updateScore(engine.getScore());

        }

        private void updateScore(Score currentScore)
        {
            string sc_win = "Win "+ currentScore.win.ToString();
            string sc_draw = "Lose " + currentScore.lose.ToString(); ;
            string sc_lose = "Draw " + currentScore.draw.ToString(); ;

            Label_Score_Win.Text = sc_win;
            Label_Score_Draw.Text = sc_draw;
            Label_Score_Lose.Text = sc_lose;
        }

        private void Label_AI_Choice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Score_Win_Click(object sender, EventArgs e)
        {

        }

        private void CopyRight_Click(object sender, EventArgs e)
        {
            CopyRight.Text = "HahaTTpro 6-Nov-2014";
        }
    }
}
