using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    public class MyTask
    {
        private ILegacyClass _obj;

        public MyTask(ILegacyClass obj)
        {
            _obj = obj;
        }

        public void DoSomething()
        {
            _obj.DoWork();
        }
    }
}
