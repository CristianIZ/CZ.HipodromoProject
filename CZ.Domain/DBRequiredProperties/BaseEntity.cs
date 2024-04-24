using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public abstract class BaseEntity : IDBAudit
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
