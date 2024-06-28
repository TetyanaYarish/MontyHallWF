using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class RandomPrizeGenerator
    {
        public List<string> listOfPrizes = new List<string>{ "Luxury car", "Goat", "Goat" };

        public RandomPrizeGenerator()
        {

        }

 
        public string YourPrize()//Function, which return randomly prize from list of prizes
        {
            int num = listOfPrizes.Count();
         
            string value = listOfPrizes[new Random().Next(0, num)];
            listOfPrizes.Remove(value);//remove prize from list of prizes

            return value;
        }
      
      
    }
}
