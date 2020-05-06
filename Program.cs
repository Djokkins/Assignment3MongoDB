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

                while (true)
                {
                    try
                    {
                        var personTest = psdb.GetName(User);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e + "User Name doesn't exist");
                        Console.WriteLine("Enter User Name:");
                        User = Console.ReadLine();
                    }
                }

                var person = psdb.GetName(User);

                bool stayUserMode = true;

                do
                {
                    Console.WriteLine("Options:\n" +
                                       "\t1. watch posts\n" +
                                       "\t2. watch polls\n" +
                                       "\t3. create circle\n" +
                                       "\t4. create post\n" +
                                       "\t5. create poll\n" +
                                       "\t6. block User\n" +
                                       "\t0. exit User Mode\n");

                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        bool stayCircle = false;
                        bool stay = true;

                        Console.WriteLine("1. watch for circle\n" +
                                            "2. watch public\n");

                        string circleChoice = Console.ReadLine();
                        var circle = new Circle();

                        if (circleChoice == "1")
                        {
                            Console.WriteLine("Enter Circle name:");

                            string CircleName = Console.ReadLine();

                            while (true)
                            {
                                try
                                {
                                    var circleTest = ccdb.GetName(CircleName);
                                    break;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e + "Circle Name doesn't exist");
                                    Console.WriteLine("Enter Circle Name:");
                                    User = Console.ReadLine();
                                }
                            }

                            circle = ccdb.GetName(CircleName);
                        }
                        else
                        {
                            circle = ccdb.GetName("public");
                        }

                        int currentId = 0;

                        do
                        {
                            Console.Clear();

                            while (stayCircle == true)
                            {
                                Console.Clear();

                                Console.WriteLine("Options:\n" +
                                       "\t1. display next post\n" +
                                       "\t2. display previous post\n" +
                                       "\t3. comment\n" +
                                       "\t0. exit Circle\n");

                                string WallChoice = Console.ReadLine();

                                ccdb.PrintPost(circle, currentId);

                                if (WallChoice == "1")
                                {
                                    currentId++;
                                }
                                if (WallChoice == "2")
                                {
                                    if (currentId > 0)
                                        currentId--;
                                }
                                if (WallChoice == "3")
                                {
                                    Console.WriteLine("Write comment:\n");

                                    string comment = Console.ReadLine();


                                }
                                if (WallChoice == "0")
                                {
                                    stayCircle = false;
                                }
                                else
                                {
                                    Console.WriteLine("invalid option. try again\n");
                                }

                            } while (stayCircle == true) ;
                        } while (stay == true);
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
                    if (choice == "6")
                    {

                    }
                    if (choice == "0")
                    {
                        stayUserMode = false;
                    }
                    else
                    {
                        Console.WriteLine("invalid option. try again\n");
                    }
                } while (stayUserMode == true);
            }
        }
    }
}
