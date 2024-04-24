using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public class WaitingClient : BaseEntity
    {
        public Client Client { get; set; }

        private WaitingClient() { }

        public WaitingClient(Client client)
        {
            if (this.Client != null)
                throw new Exception("There is already a client waiting");

            this.Client = client;
        }
    }
}
