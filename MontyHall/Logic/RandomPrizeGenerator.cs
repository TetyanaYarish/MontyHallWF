﻿using System;
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
        public void ReturnAllPrizes()
        { 
            var prize1=YourPrize();
           
        }
 
        public string YourPrize()//Function, which return randomly prize from list of prizes
        {
            int num = listOfPrizes.Count();
            //if (num < 1)
            //{
            //    throw new Exception("We dont have more prizes. ");
            //}
            string value = listOfPrizes[new Random().Next(0, num)];
            listOfPrizes.Remove(value);//remove prize from list of prizes

            return value;
        }
      
        public string ReturnYourPrize(string prize)
        {
            return prize;
        }
    }
}
