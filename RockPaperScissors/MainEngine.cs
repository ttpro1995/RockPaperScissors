using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct theResult
{
    //1 rock
    //2 paper
    //3 scissors
   public int me;
   public int they;
   public int win;//1 win -1 lose 0 draw
   public string PlayerChoice;
   public string AIChoice;

}

namespace RockPaperScissors
{
    class MainEngine
    {
        
        theResult result;
  
        public theResult OneTwoThree(int mychoice)
        {
            RandomPassword.Random AI = new RandomPassword.Random();
            theResult result = new theResult();
            result.me = mychoice;
            result.they = AI.random_integer(1, 3);
            
            //rock
            if (result.me==1)
            {
                if (result.they == 1)//rock
                    result.win = 0;

                if (result.they==2)//papar
                    result.win = -1;

                if (result.they == 3)//scissors
                    result.win = 1;
            }


            //paper
            if (result.me == 2)
            {
                if (result.they == 1)//rock
                    result.win = 1;

                if (result.they == 2)//papar
                    result.win = 0;

                if (result.they == 3)//scissors
                    result.win = -1;
            }


            //scissors
            if (result.me == 3)
            {
                if (result.they == 1)//rock
                    result.win = -1;

                if (result.they == 2)//papar
                    result.win = 1;

                if (result.they == 3)//scissors
                    result.win = 0;
            }


            return result;
        }





    }
}
