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
        public bool Mammals
        {
            get { return mammals; }
        }
        protected bool camivours;
        public bool Camivours
        {
            get { return camivours; }
        }

        public const int MOOD_HAPPY = 0;

        public const int MOOD_SCARE = 1;
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
