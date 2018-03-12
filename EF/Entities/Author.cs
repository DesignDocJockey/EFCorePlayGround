using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Entities
{
    public class Author
    {
        public Guid Uuid { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
    }
}
