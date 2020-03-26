using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace Client
{
    class Client_model
    {        
        static string IPAddress = "127.0.0.1";
        static int port = 8080;
        private TcpClient client = new TcpClient(IPAddress, port);
        private dynamic reader;
        private dynamic writer;
        public static string ID;

        //create streamReader/Writer
        public Client_model(string id)
        {
            ID = id;
            reader = new StreamReader(client.GetStream());
            writer = new StreamWriter(client.GetStream());
        }

        //Sends message to server and receives reply
        public string sendMessage(String s)
        {
            writer.WriteLine(ID + s); 
            writer.Flush();
            string messageFromSever = reader.ReadLine();
            return messageFromSever;
        }

        ~Client_model()
        {
            reader.Close();
            writer.Close();
            client.Close();
        } 
       
    }
}
