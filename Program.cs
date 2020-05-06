using System;
using assignment3MongoDB.Models;
using assignment3MongoDB.Services;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace assignment3MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonService psdb = new PersonService();
            PostsServices podb = new PostsServices();
            PollServices pldb = new PollServices();
            CircleService ccdb = new CircleService();
            while (true)
            {
                Console.WriteLine("Enter User Name: ");

                string User = Console.ReadLine();

                UserMode(User);
            }
        }

        static void UserMode(string personName)
        {
            bool stay = true;

            do
            {
                Console.WriteLine("Options:\n" +
                                   "\t1. watch posts\n" +
                                   "\t2. create circle\n" +
                                   "\t3. create post\n" +
                                   "\t4. create poll\n" +
                                   "\t5. block User\n" +
                                   "\t0. exit User Mode\n");

                string choice = Console.ReadLine();

                if (choice == "1")
                {

                }
                if (choice == "2")
                {

                }
                if (choice == "3")
                {

                }
                if (choice == "4")
                {

                }
                if (choice == "5")
                {

                }
                if (choice == "0")
                {
                    stay = false;
                }
                else
                {
                    Console.WriteLine("invalid option. try again\n");
                }
            } while (stay == true);


        }
    }
}
