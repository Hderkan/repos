﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Entities
{
     public class BookAuthor
    {
        public int BookAuthorId { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }


    }
}
