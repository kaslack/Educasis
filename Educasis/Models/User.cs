using System;
using System.Collections.Generic;

namespace Educasis.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Cod { get; set; }
        public string Users { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
