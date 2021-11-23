using JewelleryStore.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryStore.AppSettings
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<ProductModel> tbl_Product { get; set; }
        public DbSet<ProductTypeModel> tbl_ProductType { get; set; }
        public DbSet<ProductCategoryModel> tbl_ProductCategory { get; set; }

    }
}
