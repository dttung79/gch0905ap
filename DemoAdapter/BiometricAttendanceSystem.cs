using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public class BiometricAttendanceSystem
    {
        public void TakeAttendance()
        {
            // show system time
            Console.WriteLine("System time: " + DateTime.Now.ToString());

            // ask user to chooce type of attendance machine
            Console.WriteLine("Please choose type of attendance machine: ");
            Console.WriteLine("1. FingerPrint Machine");
            Console.WriteLine("2. Face Machine");
            Console.WriteLine("3. Swipe Machine");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());            

            // create attendance machine corresponding to user choice
            BiometricMachine machine = null;
            if (choice == 1) machine = new FingerPrintMachine();
            else if (choice == 2) machine = new FaceMachine();
            else if (choice == 3) machine = new AttendanceAdapter(new AttendanceMachine());
            else if (choice == 4) return;
            else Console.WriteLine("Invalid choice!");

            // call method Detect() on attendance machine
            if (machine != null) machine.Detect();
        }

        public void Detect(BiometricMachine machine)
        {
            System.Console.WriteLine("Starting to detect ...");
            machine.Detect();
            System.Console.WriteLine("Detection completed ...");
        }
    }
}