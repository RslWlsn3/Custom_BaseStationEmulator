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
    class Server
    {        
        static void Main(string[] args)
        {
            TcpListener listener = null; //used to monitor a TCP port for incoming requests and then create either a Socket or a TcpClient that manages the connection to the client
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                listener.Start(); // enables listening
                Console.WriteLine("The server has started!");
                while (true)
                {
                    Console.WriteLine("waiting for client conects");
                    TcpClient Client = listener.AcceptTcpClient(); //accepts incoming connection requests and creates a TcpClient to handle the request
                    Console.WriteLine("Accepted new client connection");
                    StreamReader reader = new StreamReader(Client.GetStream());
                    StreamWriter writer = new StreamWriter(Client.GetStream()); //these allow the Client (on the sever side) to read and write 
                    string s = string.Empty;
                    while(!(s = reader.ReadLine()).Equals("Exit") || (s == null)){ //reads message line by line
                        Console.WriteLine("Client says: " + s);
                        Console.WriteLine("I'm responding back: " + s);
                        writer.WriteLine("From server:" + s); // responds by echoing back each line
                        writer.Flush();
                    }
                    reader.Close();
                    writer.Close();
                    Client.Close();
                }                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if(listener != null)
                {
                    listener.Stop();
                }
            }
        }
    }
}
