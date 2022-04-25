using System;

namespace EF_2504.DAL.Entities
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public decimal BookPrice { get; set; }

        public string BookImageUrl { get; set; }

        public DateTime BookCreatedDate { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }







    }
}


