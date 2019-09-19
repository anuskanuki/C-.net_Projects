using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendsSystem.Model;

namespace FriendsSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var friendsList = new List<Friends>();

            friendsList.Add(new Friends
            {
                Name = "Anuska",
                FriendshipTime = 3
            });

            friendsList.Add(new Friends
            {
                Name = "Filipe",
                FriendshipTime = 5
            });

            friendsList.Add(new Friends
            {
                Name = "Lucas",
                FriendshipTime = 8
            });


            friendsList.ForEach(i =>
            Console.WriteLine($"Name: {i.Name}, Friendship time: {i.FriendshipTime}"));

            Console.ReadKey();

        }

    }
}
