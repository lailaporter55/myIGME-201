﻿using System;
using System.Collections.Generic;

namespace PetApp
{
    interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
    }

    interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public Pet()
        {
        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();
    }

    public class Cat : Pet, ICat
    {
        public Cat()
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}: Yuck, I don't like that!");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name}: Where's that mouse...");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name}: purrrrrrrrrrrrrrrrrrrr...");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name}: Hiss!");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{Name}: Ha! I never do this");
        }
        public static void Evicted()
        {
            Console.WriteLine("{0}: AAAAAAAAAAAAAAAAAAAAAAH! Help me, I don't like the cold!", this.name); 
        }
        public static void EvictDog()
        {
            Pets pets = new Pets();
            List<Pet> pl = pets.petList;
            for (int i = 0; i < pl.Count; i++)
            {
                if (pl[i] is Cat)
                {
                    Dog dog = (Dog)pl[i];
                    pl.Find(dog);
                    dog.Evicted();
                    pl.Remove(dog);
                    Console.WriteLine("{0}: You will be a homeless furball, {1}", this.name, dog.Name);
                }
            }
        }
    }

    public class Dog : Pet, IDog
    {
        public string license;

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}: Yummy, I will eat anything!");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name}: Throw the ball, throw the ball!");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name}: Woof woof!");
        }

        public void NeedWalk()
        {
            Console.WriteLine($"{Name}: Woof woof, I need to go out.");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{Name}: Whimper, whimper, no vet!");
        }
        public static void EvictCat()
        {
            Pets pets = new Pets();
            List<Pet> pl = pets.petList; 
            for(int i=0;i< pl.Count; i++)
            {
                if (pl[i] is Dog)
                {
                    Cat cat = (Cat)pl[i];
                    pl.Find(cat);
                    cat.Evicted(); 
                    pl.Remove(cat);
                    Console.WriteLine("{0}: You will be a homeless furball, {1}", this.name, cat.Name);
                }
            }
        }
        public static void Evicted()
        {
            Console.WriteLine("{0}: AAAAAAAAAAAAAAAAAAAAAAH! Help me, I don't like the cold!", this.name);
        }
    }

    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
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
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
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
            get
            {
                return petList.Count;
            }
        }

        public void Add(Pet pet)
        {
            if (pet != null)
            {
                petList.Add(pet);
            }
        }

        public void Remove(Pet pet)
        {
            if (pet != null)
            {
                petList.Remove(pet);
            }
        }

        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }

    public class PetApp
    {
        static void Main(string[] args)
        {
            int i = 0;
            int petEl = 0;
            Pet thisPet = null;

            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            // seed the random number generator
            Random rand = new Random();

            Pets pets = new Pets();

            for (i = 0; i < 50; ++i)
            {

                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    Console.WriteLine();
                    if (rand.Next(1, 3) == 1)
                    {
                        // add a cat
                        cat = new Cat();
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Cat's Name => ");
                        cat.Name = Console.ReadLine();
                        Console.Write("Age => ");
                        cat.age = Convert.ToInt32(Console.ReadLine());

                        thisPet = cat;
                    }
                    else
                    {
                        // add a dog
                        string szLicense;
                        string szName;
                        int nAge;

                        Console.WriteLine("You bought a dog!");
                        Console.Write("Dog's Name => ");
                        szName = Console.ReadLine();
                        Console.Write("Age => ");
                        nAge = Convert.ToInt32(Console.ReadLine());
                        Console.Write("License => ");
                        szLicense = Console.ReadLine();

                        dog = new Dog(szLicense, szName, nAge);

                        thisPet = dog;
                    }

                    pets.Add(thisPet);
                }
                else
                {
                    petEl = rand.Next(0, pets.Count);

                    thisPet = pets[petEl];

                    if (thisPet == null)
                    {
                        continue;
                    }

                    if (thisPet.GetType() == typeof(Cat))
                    {
                        iCat = (ICat)thisPet;

                        int nAction = rand.Next(0, 4);
                        switch (nAction)
                        {
                            case 0:
                                iCat.Eat();
                                break;
                            case 1:
                                iCat.Play();
                                break;
                            case 2:
                                iCat.Purr();
                                break;
                            case 3:
                                iCat.Scratch();
                                break;
                        }
                    }
                    else
                    {
                        iDog = (IDog)thisPet;
                        int nAction = rand.Next(0, 5);

                        switch (nAction)
                        {
                            case 0:
                                iDog.Eat();
                                break;
                            case 1:
                                iDog.Play();
                                break;
                            case 2:
                                iDog.Bark();
                                break;
                            case 3:
                                iDog.NeedWalk();
                                break;
                            case 4:
                                iDog.GotoVet();
                                break;
                        }
                    }
                }
            }
            //evict cat
            Timer myTimer = new Timer(20000);
            myTimer.Elapsed += new ElapsedEventHandler(Dog.EvictCat);
            myTimer.Start();
            //evict dog
            Timer myTimer = new Timer(20000);
            myTimer.Elapsed += new ElapsedEventHandler(Cat.EvictDog);
            myTimer.Start();
        }
    }
}

