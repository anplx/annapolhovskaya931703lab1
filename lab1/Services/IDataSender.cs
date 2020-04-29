using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Services
{
    public interface IDataSender
    {
        int SendNum1();
        int SendNum2();
        int SendAddR();
        int SendSubR();
        int SendMultR();
        string SendDivR();
    }
}
