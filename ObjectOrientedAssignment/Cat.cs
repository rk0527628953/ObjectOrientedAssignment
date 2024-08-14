using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{ 
    internal class Cat:Animal,ILand
    {
    private int numberOfLegs;
        public Cat(int mood) : base(true,true,mood)
        {
             numberOfLegs = 4;
        }
        public override void SayHello()
        {
            Console.WriteLine("meow~");
        }
        public override void SayHello(int moodLevel)
        {
            if (moodLevel == MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr");
            }
            else if (moodLevel == MOOD_SCARE)
            {
                Console.WriteLine("hiss");
            }
        }
        //public override void SayHello()
        //{
        //    if (mood == mood_happy)
        //    {
        //        Console.WriteLine("Cat makes a purr, purr sound when in a good mood.");
        //    }
        //    else if (mood == mood_scare)
        //    {
        //        Console.WriteLine("Cat makes a hissing sound when frightened.");
        //    }
        //}
        public int GetNumberofLegs() => numberOfLegs;
        public override string ToString()
        {
            return mammals + " " + camivours + " " + mood + " " + numberOfLegs;
        }
    }
}
