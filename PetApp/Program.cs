using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Cat(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public override void Eat()
        {
            Console.WriteLine("{0} eats a lot of food, their favorite is lasagna!", this.Name);
            throw new NotImplementedException();
        }

        public override void GotoVet()
        {
            Console.WriteLine("{0} hates going to the vet!", this.Name);
            throw new NotImplementedException();
        }

        public override void Play()
        {
            Console.WriteLine("{0} plays with the cardboard box! {0} has a lot of other toys but their favorite is the box.", this.Name);
            throw new NotImplementedException();
        }

        public void Purr()
        {
            Console.WriteLine("{0} purrs a lot, this is a very happy cat.", this.Name);
            throw new NotImplementedException();
        }

        public void Scratch()
        {
            Console.WriteLine("{0} scratches when they have to go to the vet!!", this.Name);
            throw new NotImplementedException();
        }
    }
    public class Dog : Pet, IDog
    {
        public Dog(string sName, string sLicense, int age)
        {
            this.Name = sName;
            string license = sLicense; 
            this.age = age;
        }
        public void Bark()
        {
            Console.WriteLine("{0} barks a lot esspecially at the mailman.", this.Name);
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            Console.WriteLine("{0} eats a lot of food, their favorite is tacos!", this.Name);
            throw new NotImplementedException();
        }

        public override void GotoVet()
        {
            Console.WriteLine("{0} needs to go to the vet for fleas, but they hate it. ", this.Name);
            throw new NotImplementedException();
        }

        public void NeedWalk()
        {
            Console.WriteLine("{0} says 'BARK BARK BARK' which translates to 'I NEED WALK'",this.Name);
            throw new NotImplementedException();
        }

        public override void Play()
        {
            Console.WriteLine("{0} LOVES to play with their favorite toy, rope");
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //create variables for the pets and interfaces
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null; 
            IDog iDog = null;
            ICat iCat = null;

            string name = null;
            string license = null;
            int age = 0;

            //create the list of pets
            Pets pets = new Pets();

            //create the random number generator
            Random rand = new Random();

            for (int i = 0; i < 50; i++) 
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        //add a dog
                        
                        Console.WriteLine("You bought a dog!");
                        Console.WriteLine("What would you like to name your dog?");
                        name = Console.ReadLine();
                        Console.WriteLine("What is your dogs license");
                        license = Console.ReadLine();
                        Console.WriteLine("How old is your dog?");
                        string sAge = Console.ReadLine();
                        age = Int32.Parse(sAge);

                        dog = new Dog(name, license, age);
                        pets.Add(dog);

                    }
                    else
                    {
                        //add a cat
                        
                        Console.WriteLine("You bought a cat!");
                        Console.WriteLine("What would you like to name your cat?");
                        name = Console.ReadLine();
                        Console.WriteLine("How old is your cat?");
                        string sAge = Console.ReadLine();
                        age = Int32.Parse(sAge);

                        cat = new Cat(name, age);
                        pets.Add(cat);
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(1, pets.Count)];
                    Console.WriteLine("You bought a {0}!", thisPet.GetType());

                    //prompt user for dog's name, age, and license id

                    //if no pets are in the list return null for thisPet
                    if(pets.Count == 0)
                    {
                        thisPet = null;
                        continue;
                    }
                    //else if a valid pet was returned, set interface variable to thisPet based of thisPet.GetType()
                    //and randomly call one of the member methods of the interface
                    else
                    {
                        if(thisPet.GetType() == typeof(Cat))
                        {
                            
                            iCat.Equals(thisPet);
                            if(rand.Next(1,6) == 1)
                            {
                                cat.Eat();
                            }
                            else if (rand.Next(1, 6) == 2)
                            {
                                cat.Play();
                            }
                            else if (rand.Next(1, 6) == 3)
                            {
                                cat.GotoVet();
                            }
                            else if (rand.Next(1, 6) == 4)
                            {
                                cat.Purr(); 
                            }
                            else if (rand.Next(1, 6) == 5)
                            {
                                cat.Scratch();
                            }
                        }
                        if(thisPet.GetType() == typeof(Dog)){
                            iDog.Equals(thisPet);
                            if (rand.Next(1, 6) == 1)
                            {
                                dog.Eat();
                            }
                            else if (rand.Next(1, 6) == 2)
                            {
                                dog.Play();
                            }
                            else if (rand.Next(1, 6) == 3)
                            {
                                dog.GotoVet();
                            }
                            else if (rand.Next(1, 6) == 4)
                            {
                                dog.Bark();
                            }
                            else if (rand.Next(1, 6) == 5)
                            {
                                dog.NeedWalk();
                            }
                        }
                    }
                    
                }

            }

        }
    }
}
