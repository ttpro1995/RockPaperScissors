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

            

        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            MainEngine engine = new MainEngine();
            theResult result = engine.OneTwoThree(3);
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            MainEngine engine = new MainEngine();
            theResult result = engine.OneTwoThree(2);
        }
    }
}
