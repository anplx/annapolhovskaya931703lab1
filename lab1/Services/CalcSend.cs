using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab1.Models;

namespace lab1.Services
{
    public class CalcSend : IDataSender
    {
        private MyModel myModel = new MyModel();
        public int SendNum1()
        {
            return myModel.num1;
        }
        public int SendNum2()
        {
            return myModel.num2;
        }
        public int SendAddR()
        {
            return myModel.Add();
        }
        public int SendSubR()
        {
            return myModel.Sub();
        }
        public int SendMultR()
        {
            return myModel.Mult();
        }
        public string SendDivR()
        {
            return myModel.Div();
        }
    }
}
