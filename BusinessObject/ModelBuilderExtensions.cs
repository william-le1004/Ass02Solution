using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>().HasData(
            new Member()
            {
                MemberId = 1,
                City = "Quy Nhon",
                CompanyName = "FPT",
                Country = "VIET NAM",
                Email = "kienle@gmail.com",
                Password = "123",
            });
        modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               ProductId = 1,
               CategoryId = 1,
               ProductName = "FPT TU BAN",
               Weight = "100KG",
               UnitPrice = 100,
               UnitslnStock = 100,
           },
           new Product()
           {
               ProductId = 2,
               CategoryId = 2,
               ProductName = "FPT TU BAN1",
               Weight = "1001KG",
               UnitPrice = 100,
               UnitslnStock = 100,
           },
           new Product()
           {
               ProductId = 3,
               CategoryId = 3,
               ProductName = "FPT TU BAN3",
               Weight = "100KG",
               UnitPrice = 100,
               UnitslnStock = 100,
           }
           );
    }

}
