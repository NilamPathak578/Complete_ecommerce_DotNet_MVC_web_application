using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public String ProfilePictureUrl { get; set; }

        public String FullName { get; set; }
        public String Bio { get; set; } 
    }
}
