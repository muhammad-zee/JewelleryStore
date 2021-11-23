using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelleryStore.Models
{

    public class ProductModel : BaseEntityModel
    {
        public string Name { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductTypeId { get; set; }
        public double ProductBuyingPrice { get; set; }
        public double ProductSalePrice { get; set; }
        [NotMapped]
        public string ProductCategoryName { get; set; }
        [NotMapped]
        public string ProductTypeName { get; set; }  
    }
}
