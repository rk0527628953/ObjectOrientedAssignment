using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    internal class Frog : Animal,IWater
    {
        private int numberOfLegs;
        public Frog(int mood) : base(false, false, mood)
        {
            numberOfLegs = 4;
        }
        public override void SayHello(int moodLevel)
        {
            if (moodLevel == MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack");
            }
            else if (moodLevel == MOOD_SCARE)
            {
                Console.WriteLine("plop into the water");
            }
        }
        //public override void SayHello()
        //{
        //    if (mood == mood_happy)
        //    {
        //        Console.WriteLine("Frog sings 'quack quack quack' on the shore when in a good mood.");
        //    }
        //    else if (mood == mood_scare)
        //    {
        //        Console.WriteLine("Frog plops into the water when frightened.");
        //    }
        //}
        public bool HasGills() => false;
        public bool HasLaysEggs() => true;
        public int GetNumberOfLegs() => numberOfLegs;
        public override string ToString()
        {
            return mammals + " " + camivours + " " + mood + " " + numberOfLegs;
        }
    }
}
