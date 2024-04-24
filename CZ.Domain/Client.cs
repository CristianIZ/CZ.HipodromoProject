using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public class Client : KeyEntity
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public int TucsonSubscriptionNumber { get; set; }

        private Client() { }

        public Client(Category category, string name, string lastName, string dni, int tucsonSubscriptionNumber)
        {
            this.Category = category;
            this.Name = name;
            this.LastName = lastName;
            this.DNI = dni;
            this.TucsonSubscriptionNumber = tucsonSubscriptionNumber;
        }
    }
}
