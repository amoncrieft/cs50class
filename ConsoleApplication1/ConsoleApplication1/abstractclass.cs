using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class vehicle
    {
        public string type;
        public int maxriders;
        public string fueltype;
        public abstract void start();
        public abstract void stop();
    }

    class car : vehicle
    {
        override public void start()
            { Console.WriteLine("start"); }

        override public void stop()
            { Console.WriteLine("stop"); }

    }
    class chopper : vehicle
    {

    }
    class bike : vehicle
    {

    }
}
