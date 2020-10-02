using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        //has trunk
        public Car()
        {

        }

        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            //throw new NotImplementedException();)
            Console.WriteLine("this car in drive");
        }

       



    }
}
