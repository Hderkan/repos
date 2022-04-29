using DatabaseImageProject.Models.Abstract;
using DatabaseImageProject.Models.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Concrete
{
    public class ProductDAL : BaseRepository<Product>,IRepository<Product>
    {



    }
}
