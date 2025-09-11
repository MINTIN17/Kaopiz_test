using MyApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Partner : EntityBase
    {
        public int UserId { get; set; }
        public string? About { get; set; }
        public User User { get; set; }
    }
}
