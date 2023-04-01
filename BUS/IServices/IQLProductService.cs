using DAL.Entities;
using DAL.Utilities.Request;
using DAL.Utilities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLProductService
    {
        Task<CreateProductResponse> add(CreateProductRequest product);
        Task<GetProductResponse> getById(int id);
        Task<CreateProductResponse> updateById(int productId, UpdateProductRequest updateProduct);
        Task<DeleteProductResponse> deleteById(int productId);
    }
}
