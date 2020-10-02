using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle: Vehicle
    {
        public bool HasSideCart { get; set; };
        public override void DriveAbstract()
        {
            //throw new NotImplementedException();)
            Console.WriteLine("this car in drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($" this {GetType().Name} is a drive {GetType().BaseType.Name}");
        }
    }

   
}
