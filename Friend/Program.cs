using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend
{
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy = new Friend();
            friend.name = "Jules";
            friend.greeting = "Hey bestie Jules";
            friend.birthdate = DateTime.Parse("2002-12-30");
            friend.address = "AXID house, Rochester, NY, 14623"; 

            enemy = friend;
            enemy.greeting = "Boo Jules";
            enemy.address = "Return to sender. Address Unknown";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}
