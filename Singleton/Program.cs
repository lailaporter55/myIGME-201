using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   
        public interface ILoader
        {
            void LoadJSON(string json);
            void ReadJSON(string[] jsonInfo); 
        }
    class Singleton : ILoader
    {
        private static Singleton instance = new Singleton();
        public static Singleton GetInstance()
        {
            return instance;
        }

        public void LoadJSON(string json)
        {
            throw new NotImplementedException();
        }

        public void ReadJSON(string[] jsonInfo)
        {
            foreach (string line in jsonInfo)
            {
                Console.WriteLine(line);
            }
        }
    }
        public class Player
    {
        private static Player instance;
        private Player() { }
        public static Player Instance
        {
            get 
            {
                if ((instance == null))
                {
                    instance = new Player();
                }
                return instance;
            }    
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
            string[] jsonArray; 
            Singleton sig = Singleton.GetInstance();
            ILoader iLoader = sig;
            iLoader.LoadJSON("json1.json");
            iLoader.ReadJSON(jsonArray);
            
            }
        }
            
}
