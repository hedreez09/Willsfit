using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Willsfit.Model;
using Willsfit.Services;

namespace Willsfit.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		
		public ProductsController(JsonFileProductService productService)
		{
			ProductService = productService;
		}

		public JsonFileProductService ProductService { get; }

		[HttpGet]
		public IEnumerable<Product> GetProducts()
		{
			return ProductService.GetProducts();
		}
	}
}
