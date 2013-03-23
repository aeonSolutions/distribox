using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Distribox.Network
{

    class Peer
    {
        private IPAddress _address;
        private int _port;

        public Peer(IPAddress _address, int _port)
        {
            this._address = _address;
            this._port = _port;
        }

        public String IP
        {
            get
            {
                return _address.ToString();
            }

            set
            {
                _address = IPAddress.Parse(value);
            }
        }

        public int Port
        {
            get
            {
                return _port;
            }

            set
            {
                _port = value;
            }
        }

        public override int GetHashCode()
        {
            return String.Format("{0}:{1}", IP, Port).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var peer = (Peer)obj;
            return this.IP == peer.IP && this.Port == peer.Port;
        }
    }
    
}