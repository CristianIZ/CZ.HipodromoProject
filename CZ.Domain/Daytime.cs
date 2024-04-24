using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public class Daytime : BaseEntity
    {
        [Required]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }

        private Daytime() { }
    }
}
