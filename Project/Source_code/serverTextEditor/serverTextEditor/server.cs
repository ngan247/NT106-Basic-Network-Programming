using demoLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;


namespace serverTextEditor
{

    public class server
    {

        int portSimpleServer;
        TcpListener tcpListener;
        static List<client> clients = new List<client>();

        public server(string ipAddress, int port)
        {
            portSimpleServer = port;
            IPAddress ip = IPAddress.Parse(ipAddress);
            tcpListener = new TcpListener(ip, port);
        }

        public void start()
        {
            tcpListener.Start();

            Console.WriteLine("Port: " + Convert.ToString(portSimpleServer));

            while (true)
            {
                Socket socket = tcpListener.AcceptSocket();
                client client_index = new client(socket);
                clients.Add(client_index);
                client_index.Start();
            }
        }


        public void stop()
        {
            foreach (client element in clients)
            {
                element.Stop();
            }
            tcpListener.Stop();
        }

        public static void ServerSocketMethod(client dataFromClient)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Socket socket = dataFromClient.socketGetSet;
                NetworkStream stream = dataFromClient.streamGetSet;
                BinaryReader binaryReader = dataFromClient.readerGetSet;
                //dataFromClient.SendData(dataFromClient, "Successful Connection");

                int numberInputBytes;
                while ((numberInputBytes = binaryReader.ReadInt32()) != 0)
                {
                    byte[] bytes = binaryReader.ReadBytes(numberInputBytes);
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    editorClass packet = binaryFormatter.Deserialize(memoryStream) as editorClass;

                    switch (packet.type)
                    {
                        case editorType.DATA:
                            string message = ((editorDataClass)packet).data;
                            Console.WriteLine("<client>: " + message);
                            foreach (client element in clients)
                            {
                                element.SendData(dataFromClient, message);
                            }
                            break;
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Caution: " + exc.Message);
            }
            finally
            {
                dataFromClient.Stop();
            }
        }
    }
}
