using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    internal class Dog:Animal,ILand
    {
        private int numberOfLegs;
        public Dog(int mood):base(true,true,mood)
        {
            numberOfLegs = 4;
        }
        public override void SayHello()
        {
            Console.WriteLine("wagging their tails");
        }
        public override void SayHello(int moodLevel)
        {
            if (moodLevel == MOOD_HAPPY)
            {
                Console.WriteLine("bark loudly");
            }
            else if (moodLevel == MOOD_SCARE)
            {
                Console.WriteLine("whooping");
            }
        }
        //public override void SayHello()
        //{
        //    if (mood == mood_happy)
        //    {
        //        Console.WriteLine("Dog barks loudly when feeling comfortable.");
        //    }
        //    else if (mood == mood_scare)
        //    {
        //        Console.WriteLine("Dog makes a whooping sound when frightened.");
        //    }
        //}
        public int GetNumberofLegs()=> numberOfLegs;

        public override string ToString()
        {
            return mammals + " " + camivours + " " + mood + " " + numberOfLegs;
        }
    }
}
