using EF_2504.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Concrete.EF.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryName).IsRequired();
            builder.HasData(
                
                new Category { CategoryId=1,CategoryName="Roman",CategoryDescription="Romanlar"},

                new Category { CategoryId=2, CategoryName="Hikaye",CategoryDescription="Hikayeler"},

                new Category { CategoryId=3, CategoryName="Bilgisayar",CategoryDescription="Bilgisayar kitapları"}

                
                );
        }
    }
}
