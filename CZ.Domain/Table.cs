using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public class Table : BaseEntity
    {
        public int CutleryQuantity { get; set; }

        private Table() { }

        public Table(int cutleryQuantity)
        {
            this.CutleryQuantity = cutleryQuantity;
        }
    }
}
