using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Models
{
    public class MyModel
    {
        Random rnd = new Random();

        public int num1 = 0;
        public int num2 = 0;

        public void RandomizeI()
        {
            num1 = Math.Abs(rnd.Next() % 10);
            num2 = Math.Abs(rnd.Next() % 10);
        }
        public MyModel()
        {
            RandomizeI();
        }

        public int Add()
        {
            return num1 + num2;
        }
        public int Sub()
        {
            return num1 - num2;
        }
        public int Mult()
        {
            return num1 * num2;
        }
        public string Div()
        {
            if (num2 == 0)
            {
                return "Devide by zero";
            }
            else 
            {
                string str = (num1 / num2).ToString();
                return str; 
            }
        }
    }
}
