using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public abstract class BiometricMachine
    {
        public abstract void Detect();
    }

    public class FingerPrintMachine : BiometricMachine
    {
        public override void Detect()
        {
            Console.WriteLine("Please put your index finger on the sensor ...");
            Console.ReadLine();
            Console.WriteLine("Scanning finger print ...");
            Console.ReadLine();
            Console.WriteLine("Finger scan successfully ...");
            Console.ReadLine();
            Console.WriteLine("Welcome employee ... Have a great day!");
        }
    }

    public class FaceMachine : BiometricMachine
    {
        public override void Detect()
        {
            Console.WriteLine("Please look direct to the sensor ...");
            Console.ReadLine();
            Console.WriteLine("Scanning face ...");
            Console.ReadLine();
            Console.WriteLine("Face scan successfully ...");
            Console.ReadLine();
            Console.WriteLine("Welcome employee ... Have a great day!");
        }
    }

    public class AttendanceAdapter : BiometricMachine
    {
        public AttendanceMachine Machine
        {
            get; set;
        }

        public AttendanceAdapter(AttendanceMachine machine)
        {
            Machine = machine;
        }

        public override void Detect()
        {
            Machine.Swipe();
        }
    }
}