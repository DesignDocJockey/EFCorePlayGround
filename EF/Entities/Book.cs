using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Entities
{
    public class Book
    {
        public Guid Uuid{ get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string IsbnNumber { get; set; }
        public int Edition { get; set; }
        public DateTime PublicationDate { get; set; }
        public int PageCount { get; set; }
    }
}
