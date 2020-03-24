using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;


namespace Custom_BaseStationEmulator
{
    class Server
    {
        static Hashtable messageHash = new Hashtable();
        private static void ProccessClientReq(object argument) 
        {
            TcpClient client = (TcpClient)argument;
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream()); //these allow the Client (on the sever side) to read and write 
                string s = string.Empty;
                while (!(s = reader.ReadLine()).Equals("Exit") || (s == null))
                { 
                    string[] message = s.Split(new char[] { ' ' }, 2); // splits id from message

                    if (!messageHash.ContainsKey(message[0])) {
                        messageHash.Add(message[0], new List<string>());
                    }
                    ((List<string>)messageHash[message[0]]).Add(message[1]);
                    Console.WriteLine("Client Msg: " + s);

                    if (s == "RTS")
                    {
                        Console.WriteLine("CTS");
                        writer.WriteLine("Server: CTS"); 
                    }
                    else
                    {
                        Console.WriteLine("ACK");
                        writer.WriteLine("Server: ACK");
                    }
                    writer.Flush();
                }
                reader.Close();
                writer.Close();
                client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }
        private static void HandleDB(object argument)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "db")
                {
                    try
                    {
                        foreach (object key in messageHash.Keys)
                        {
                            Console.WriteLine(key);
                            foreach (string mes in (dynamic)messageHash[key])
                            {
                                Console.WriteLine(mes);
                            }
                        }
                        input = Console.ReadLine();

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            TcpListener listener = null; //used to monitor a TCP port for incoming requests and then create either a Socket or a TcpClient that manages the connection to the client
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                listener.Start(); // enables listening
                Console.WriteLine("The server has started");
                Thread t1 = new Thread(HandleDB);
                t1.Start(); //new thread is spawned, ProccessClientReq is called, while loop loops back through
                while (true)
                {
                    Console.WriteLine("Waiting for a client conections...");
                    TcpClient Client = listener.AcceptTcpClient(); //accepts incoming connection requests and creates a TcpClient to handle the request
                    Console.WriteLine("Connection established - listening");
                    Thread t = new Thread(ProccessClientReq);
                    t.Start(Client); //new thread is spawned, ProccessClientReq is called, while loop loops back through
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
