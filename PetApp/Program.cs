using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public Pet this[int PetEL]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[PetEL];
                }
                catch
                {
                    returnVal = null;
                }
                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (PetEL < petList.Count)
                {
                    // update the existing value at that index
                    petList[PetEL] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }
    public int Count
        {
            get { return petList.Count;}
        }
        public void Add(Pet pet)
        {
            petList.Add(pet);
        }
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }
        public void RemoveAt(int petEL) 
        {
            petList.RemoveAt(petEL);
        }
        

    } 
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr(); 
    }
    public abstract class Pet
    {
        private string name;
        public int age;

        public Pet()
        {

        }
        public Pet(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get;
            set;
        }
        

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

    }
    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet(); 
    }
    public class Cat : Pet, ICat
    {

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GotoVet()
        {
            throw new NotImplementedException();
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public void Purr()
        {
            throw new NotImplementedException();
        }

        public void Scratch()
        {
            throw new NotImplementedException();
        }
    }
    public class Dog : Pet, IDog
    {
        public void Bark()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GotoVet()
        {
            throw new NotImplementedException();
        }

        public void NeedWalk()
        {
            throw new NotImplementedException();
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfaces and classes
            

        }
    }
}
