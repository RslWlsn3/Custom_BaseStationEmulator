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
    //Object for hanlding messages
    class Message
    {
        string message;
        string senderID;
        DateTime dt;
        string response;

        //Store prevelent data about message
        public Message(string ID, string mess, string res)
        {
            message = mess;
            senderID = ID;
            response = res;
            dt = DateTime.Now;
        }
        
        //print message data to console
        public void printMessage()
        {
            Console.WriteLine("Sender ID: " + senderID + "     Message: " + message + "     Time Stamp: " + dt);
            Console.WriteLine("Response: " + response + "\n");
        }
    }
    //Server recieves messages from one or many clients and send conformaiton back. Messages are stored in a hash table. 
    class Server
    {
        static Hashtable messageHash = new Hashtable();

        //handles the storing of each message sent by a client
        private static void saveMessage(string ID, string message, string response)
        {
            Message messageObject = new Message(ID, message, response);
            if (!messageHash.ContainsKey(ID))
            {
                messageHash.Add(ID, new List<Message>());
            }
            ((List<Message>)messageHash[ID]).Add(messageObject);
        }

        //A thread calls ProccessClientReq which reads, replys and saves all messages that the client sends
        private static void ProccessClientReq(object argument) 
        {
            TcpClient client = (TcpClient)argument;
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());  
                string s = string.Empty;
                string response;
                while (!(s = reader.ReadLine()).Equals("Exit") || (s == null))
                { 
                    string[] fullMessage = s.Split(new char[] { ' ' }, 2); // splits id from message
                    string ID = fullMessage[0];
                    string message = fullMessage[1];

                    Console.WriteLine("Client Msg: " + s);

                    // handle RTS/CTS (Request To Send / Clear To Send)
                    if (message == "RTS")
                    {
                        response = "CTS";
                        Console.WriteLine(response);
                        writer.WriteLine("Server: " + response); 
                    }
                    //handle all normal messages
                    else
                    {
                        response = "ACK";
                        Console.WriteLine(response);
                        writer.WriteLine("Server: " + response);
                    }
                    writer.Flush();
                    saveMessage(ID, message, response);
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
        //prints out all saved messages when the user enters "db"
        private static void HandleDB(object argument)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "db")
                {
                    try
                    {
                        Console.WriteLine("\n*************************************************************************************************************");
                        foreach (object key in messageHash.Keys)
                        {                            
                            foreach (Message mes in (dynamic)messageHash[key])
                            {
                                mes.printMessage();
                            }
                        }
                        Console.WriteLine("*************************************************************************************************************\n");
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
                Console.WriteLine("\n*******************************\nEnter \"db\" to veiw all messages\nEnter \"Exit\" to quit\n*******************************\n");
                Thread t1 = new Thread(HandleDB);
                t1.Start(); //Thread is spawned to listen for user input
                while (true)
                {
                    Console.WriteLine("Waiting for a client conections...");
                    TcpClient Client = listener.AcceptTcpClient(); //accepts incoming connection requests and creates a TcpClient to handle the request
                    Console.WriteLine( "Connection established - listening\n");
                    Thread t = new Thread(ProccessClientReq);
                    t.Start(Client); //new thread is spawned to handle client   
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
