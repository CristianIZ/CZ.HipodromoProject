using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        private Category() { }

        public Category(string name)
        {
            this.Name = name;
        }
    }
}
