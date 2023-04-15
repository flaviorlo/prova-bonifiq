using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services.IServices;
using System;

namespace ProvaPub.Services
{
	public class ProductService: IProductService
	{
        private readonly TestDbContext _ctx;

        public ProductService(TestDbContext ctx) 
        {            
            _ctx = ctx;
        }

		public ItemsList ListProducts(int page)
		{
			int TotalCount = 10;

            return new ItemsList() {  HasNext=false, Products = _ctx.Products
																			   .Skip(TotalCount * page)
																			   .Take(TotalCount)
																			   .ToList() };
		}

	}
}
