using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class room
    {
        private string name;
        private string address;
        private int port;
        private bool connect;
        private connector myConnectRoom;

        public room(string name, string address, int port)
        {
            this.name = name;
            this.address = address;
            this.port = port;
            this.connect = false;
            this.myConnectRoom = new connector();
        }

        public string nameGetSet
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string addressGetSet
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public int portGetSet
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }

        public bool connectGetSet
        {
            get
            {
                return connect;
            }
            set
            {
                connect = value;
            }
        }

        public connector myConnectRoomGetSet
        {
            get
            {
                return myConnectRoom;
            }
            set
            {
                myConnectRoom = value;
            }
        }
    }
}
