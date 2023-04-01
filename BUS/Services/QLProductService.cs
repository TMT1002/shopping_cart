using BUS.IServices;
using DAL.Entities;
using DAL.Exceptions;
using DAL.IDALServices;
using DAL.Utilities.Request;
using DAL.Utilities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QLProductService : IQLProductService
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public QLProductService(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<CreateProductResponse> add(CreateProductRequest product)
        {
            var existingCategory = await _categoryService.GetById(product.categoryId);
            if (existingCategory != null)
            {
                var newProduct = new Product
                {
                    nameProduct = product.nameProduct,
                    description = product.description,
                    price = product.price,
                    discountPrecent = product.discountPrecent,
                    brand = product.brand,
                    stockQuantity = product.stockQuantity,
                    thumbnailImage = product.thumbnailImage,
                    thumbnailImgName = product.thumbnailImgName,
                    category = existingCategory
                };
                await _productService.add(newProduct);
                var response = new CreateProductResponse
                {
                    message = "Create product success!",
                    product = newProduct
                };
                return response;
            }
            throw new CategoryNotFoundException();
        }
        public async Task<GetProductResponse> getById(int id)
        {
            var existingProduct = await _productService.getById(id);
            if(existingProduct != null)
            {
                var response = new GetProductResponse
                {
                    message = "Get product success!",
                    product = existingProduct
                };
                return response;
            }
            throw new ProductNotFoundException();
        }
    }
}
