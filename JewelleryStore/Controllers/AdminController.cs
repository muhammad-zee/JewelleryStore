using JewelleryStore.AppSettings;
using JewelleryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryStore.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContext _dbContext;
        private IGenericRepository<ProductModel> _productRepository;
        private IGenericRepository<ProductCategoryModel> _productCategoryRepository;
        private IGenericRepository<ProductTypeModel> _productTypeRepository;

        public AdminController(AppDbContext dbContext,
            IGenericRepository<ProductModel> productRepository,
            IGenericRepository<ProductCategoryModel> productCategoryRepository,
            IGenericRepository<ProductTypeModel> productTypeRepository)
        {
            this._dbContext = dbContext;
            this._productRepository = productRepository;
            this._productTypeRepository = productTypeRepository;
            this._productCategoryRepository = productCategoryRepository;
        }
        public IActionResult Index()
        {
            ViewBag.ProductTypeModel = this._productTypeRepository.getAll();
            ViewBag.ProductCategoryModel = this._productCategoryRepository.getAll();
            return View();
        }

        #region Products

        [HttpGet]
        public ActionResult getProducts_PartiialView()
        {
            IEnumerable<ProductModel> Products = (from prod in this._productRepository.getAll()
                                                    join prod_cat in this._productCategoryRepository.getAll()
                                                  on prod.ProductCategoryId equals prod_cat.Id
                                                  join prod_type in this._productTypeRepository.getAll()
                                                  on prod.ProductTypeId equals prod_type.Id
                                                  select new ProductModel { 
                                                      Id = prod.Id,
                                                      Name = prod.Name,
                                                      ProductCategoryId = prod.ProductCategoryId,
                                                      ProductCategoryName = prod_cat.Name,
                                                      ProductTypeId = prod.ProductTypeId,
                                                      ProductTypeName = prod_type.Name,
                                                      ProductBuyingPrice = prod.ProductBuyingPrice,
                                                      ProductSalePrice = prod.ProductSalePrice

                                                  });


            //var param = new SqlParameter(,)
            return PartialView("Products_PartialView", Products);

        }

        #endregion
    }
}
