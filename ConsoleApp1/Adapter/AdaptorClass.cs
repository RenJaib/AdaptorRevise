using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Adapter
{
    public class AdapterClass : ILegacyClass
    {
        private OurNewClass _ourNewClass;
        public AdapterClass(OurNewClass ourNewClass)
        {
            _ourNewClass = ourNewClass;
        }

        public void DoWork()
        {
            _ourNewClass.DoNewWork();
        }

    }
}
