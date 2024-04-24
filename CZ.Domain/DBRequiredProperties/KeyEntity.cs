using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public abstract class KeyEntity : BaseEntity
    {
        [Required]
        public Guid Key { get; set; }
    }
}
