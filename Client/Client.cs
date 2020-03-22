using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;

    class Client
    {
        static void Main(string[] args)
        {
        try
        {
            TcpClient client = new TcpClient("127.0.0.1", 8080);
            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());
            string s = string.Empty;
            while (!s.Equals("Exit"))
            {
                Console.WriteLine("Enter string to send to sever (Enter Exit to Exit): ");
                s = Console.ReadLine();
                writer.WriteLine(s); //send data to sever
                writer.Flush();
                string messageFromSever = reader.ReadLine(); // We know that the sever sends an echo respone right back so we are ready to read this
                Console.WriteLine(messageFromSever);
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

