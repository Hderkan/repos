﻿using EF_2504.DAL.Abstract;
using EF_2504.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Concrete.EF
{
    public class EFCategoryDAL : EFBaseRepository<Category>, IEntityRepository<Category>, ICategoryDAL
    {




    }
}
