using Sales.Models.Abstract;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete
{
    public class ProductDAL : BaseRepository<Product>,IRepository<Product>
    {

    }
}
