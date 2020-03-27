using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client_console
    {
        private static Client_model client;
        static string autoMessage = "You can't handle the truth!";

        //get id from user
        public static Client_model createClient()
        {
            Console.WriteLine("Give client an ID");
            string input = Console.ReadLine();
            string ID = "ID#" + input + ": ";
            Client_model cm = new Client_model(ID);             
            return cm;
        }

        //Display console intructions to user
        public static void displayInstructions()
        {
            Console.WriteLine("\nConnected to Sever.");
            Console.WriteLine("\n**************************************\nEnter \"auto\" to send automatic message");
            Console.WriteLine("Enter \"Exit\" to quit\n**************************************\n");
            Console.WriteLine("\nEnter string to send to sever (Enter exit to Exit): ");
        }

        //Send message to serever and resieve response 
        public static void handleMessage(string userMessage)
        {
            string serverResponse;
            if (userMessage == "auto")
            {
                serverResponse = client.sendMessage("RTS");
                Console.WriteLine("Server: " + serverResponse);
                serverResponse = client.sendMessage(autoMessage);
                Console.WriteLine("Server: " + serverResponse);
            }
            else
            {
                serverResponse =  client.sendMessage(userMessage);
                Console.WriteLine("Server: " + serverResponse);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            client = createClient();
            displayInstructions();
            string userMessage = "";
            while (!userMessage.Equals("exit"))
            {
                userMessage = Console.ReadLine();
                handleMessage(userMessage);
            }



        }
    }
}
