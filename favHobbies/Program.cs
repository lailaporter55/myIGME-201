using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace favHobbies
{
    internal class Program
    {
        public interface IDance
        {
            void Turn();
            void Balance(int seconds);
            void Jump(); 
        }
        public abstract class Dance
        {
            private string shoeType;
            public string musicType; 

            public virtual string WhatShoeType(string shoeType)
            {
                    return this.shoeType;
                
            }
            public abstract void GoToClass();
            public abstract void LeaveClass();

        }
        public class Ballet : Dance, IDance
        {
            public int pirouettes;
            public int blisters;


            public Ballet(int pirouettes, int blisters) 
            { 
                this.pirouettes = pirouettes;
                this.blisters = blisters;   
            } 

            public void Balance(int seconds)
            {
                Console.WriteLine("the ballerina ballances for {0}", seconds); 
            }

            public override void GoToClass()
            {
                Console.WriteLine("Arrived to ballet class");
            }

            public void Jump()
            {
                Console.WriteLine("the ballerina does petit alegro in the center");
            }

            public override void LeaveClass()
            {
                Console.WriteLine("Leaving ballet class");
            }

            public void Turn()
            {
                Console.WriteLine("the ballerina does {0} pirouettes from fifth.", this.pirouettes);
            }
        }
        public class Tap : Dance, IDance
        {
            public int taps;
            public bool heelOrToe; //true is heel, false if toe
            public Tap(int taps, bool heelOrToe)
            {
                this.taps = taps;
                this.heelOrToe = heelOrToe;
            }

            public void Balance(int seconds)
            {
                Console.WriteLine("the tap dancer ballances for {0}", seconds);
            }

            public override void GoToClass()
            {
                Console.WriteLine("Arrived to tap class");
            }

            public void Jump()
            {
                Console.WriteLine("The tap dancer does triple wings");
            }

            public override void LeaveClass()
            {
                Console.WriteLine("Leaving tap class");
            }

            public void Turn()
            {
                if(!this.heelOrToe)
                {
                    Console.WriteLine("the tap dancer turns on the ball of their feet.");
                }
                else
                {
                    Console.WriteLine("You cannot turn on your heel");
                }
            }
        }
        static void MyMethod(object obj)
        {
            if (obj is Ballet ballet)
            {
                ballet.Jump(); 
            }
            if (obj is Tap tap) 
            {
                tap.Turn();
            }
            
        }
        static void Main(string[] args)
        {
            Ballet ballet = new Ballet(5, 20);
            Tap tap = new Tap(15, false);
            MyMethod(ballet);
            MyMethod(tap); 
        }
    }
}
