using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace Custom_BaseStationEmulator
{
    class Client
    {
        static string autoMessage = "You can't handle the truth!";
        static string IPAddress = "127.0.0.1";
        static int port = 8080;

        //Sends message to server and receives reply
        static void sendMessage(StreamReader reader, StreamWriter writer, String ID, String s)
        {
            writer.WriteLine(ID + s); 
            writer.Flush();
            string messageFromSever = reader.ReadLine(); 
            Console.WriteLine(messageFromSever);
        }      

        //Displays instructions for running client
        static void displayInstructions()
        {
            Console.WriteLine("\nConnected to Sever.");
            Console.WriteLine("\n**************************************\nEnter \"auto\" to send automatic message");
            Console.WriteLine("Enter \"Exit\" to quit\n**************************************\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give client an ID");
            string input = Console.ReadLine();
            string ID = "ID#" + input + ": ";
            try //throws an exception if the server is not runing 
            {
                TcpClient client = new TcpClient(IPAddress, port);
                displayInstructions();
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());                
                string s = string.Empty;
                while (!s.Equals("Exit"))
                {
                    Console.WriteLine("\nEnter string to send to sever (Enter Exit to Exit): ");
                    s = Console.ReadLine();
                    if (s == "auto")
                    {
                        sendMessage(reader, writer, ID, "RTS");
                        sendMessage(reader, writer, ID, autoMessage);
                    }
                    else
                    {
                        sendMessage(reader, writer, ID, s);
                    }
                }
                reader.Close();
                writer.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
