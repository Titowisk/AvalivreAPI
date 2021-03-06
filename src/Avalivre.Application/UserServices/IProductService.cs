﻿using Avalivre.Domain.Products;
using Avalivre.Infrastructure.DTO.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avalivre.Application.UserServices
{
    public interface IProductService
    {
        Task Delete(long product, int userId);
        Task Edit(UpdateProductDTO dto, int userId);

        Task<Product> Create(CreateProductDTO dto);
        Task<IEnumerable<SimilarProductDTO>> GetSimilarProducts(string name, int fetch = 10);
        Task<Product> Get(long id);

    }
}
