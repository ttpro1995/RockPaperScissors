using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RandomPassword
{
    class Random
    {
       public Random()
        {
            int seedtemp1 = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            int seedtemp2 = DateTime.Now.Millisecond;
            seed = (seedtemp1 * seedtemp2) % SEED_MAX;

            reseed();
            reseed();
            reseed();
            reseed();
            reseed();
        }

        private int seed;
        private const int multiplier = 47;
        private const int add_on = 998;
        private const int SEED_MAX = 2147483647;
        private int reseed()
        {

            seed = (seed * multiplier + add_on);
            seed= seed % SEED_MAX;
            return seed;
        }

        public double random_real()
        {
            double max = SEED_MAX;
            double temp = reseed();
            if (temp < 0) temp = temp + max;
            double ret = temp / max;
            return ret;
        }

        
        public int random_integer(int low, int high)
        {
	        if (low > high) return random_integer(high, low);
	        else return ((int)((high - low + 1) *random_real())) + low;
        }



    }
}
