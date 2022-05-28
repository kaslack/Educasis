using System;
using System.Collections.Generic;

namespace Educasis.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string? Cod { get; set; }
        public string Name { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string Contact1 { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
