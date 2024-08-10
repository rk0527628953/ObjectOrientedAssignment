using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    

    internal abstract class Animal
    {
        protected bool mammals;
        protected bool camivours;

        public const int mood_happy = 0;

        public const int mood_scare = 1;
        protected int mood;
        public Animal(bool mammals,bool camivours,int mood)
        {
            this.mammals = mammals;
            this.camivours = camivours;
            this.mood = mood;
        }
        public virtual void SayHello()
        {

        }
        public abstract void SayHello(int moodLevel);
       



        //public  void SayHello(int moodLevel);
        public bool IsMammals()=>mammals;
        public void SetMammals(bool value)
        {
            mammals = value;
        }
        public bool IsCarnivorous()=>camivours;
        public void SetCarnivorous(bool value)
        {
            camivours = value;
        }

    }
}
