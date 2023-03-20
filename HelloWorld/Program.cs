using System;
using System.ComponentModel.Design;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Message responses;
            Message[] _responses = { new Message("Welcome Back!"),
            new Message("What a loveely name!"),
            new Message("Great Name!"),
            new Message("Oh hi!"),
            new Message("That is a silly name") };

            string name;

            Message myMessage;
            myMessage = new Message("Hello World - from Message Object");
            myMessage.Print();

            while(true)

            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                if (name == "Mark")
                {
                    _responses[0].Print();
                }
                else if (name == "Fred")
                {
                    _responses[1].Print();
                }
                else if (name == "Wilma")
                {
                    _responses[2].Print();
                }
                else if (name =="Alice")
                {
                    _responses[3].Print();
                }
                else
                {
                    _responses[4].Print();
                }
            }
                                   
        }
    }
}