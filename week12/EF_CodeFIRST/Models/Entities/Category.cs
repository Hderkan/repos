using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CodeFIRST.Models
{
    public class Category
    {
    public int CategoryId { get; set; }

    public bool IsDeleted { get; set; }
    public string CategoryName { get; set; }

    public string CategoryDescription { get; set; }

    public List<Book> Books { get; set; }
    
    }
}