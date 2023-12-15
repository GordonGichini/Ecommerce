using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;
using Ecommerce.Services;
using Ecommerce.Services.Iservices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProduct _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProduct productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts([FromQuery] int pageSize = 10, [FromQuery] int pageNumber = 1)
        {
            var products = await _productService.GetAllProducts(pageSize, pageNumber);
            return Ok(products);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<List<Product>>> FilterProducts([FromQuery] string name, [FromQuery] decimal? price)
        {
            var filteredProducts = await _productService.FilterProducts(name, price);
            return Ok(filteredProducts);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            var product = await _productService.GetProduct(id);

            if (product == null)
            {
                return NotFound("Product Not Found");
            }
            return Ok(product);
        }

        [HttpPost]
        [Authorize(Policy = "AdminPolicy")]
        public async Task<ActionResult<string>> AddProduct(AddProductDto newProduct)
        {
            var newProduct = _mapper.Map<Product>(ProductDto);
            var response = await _productService.AddProduct(newProduct);
            return Created($"Products/{newProduct.Id}", response);
        }

        [HttpPut("{id}")]
        [Authorize(Policy = "AdminPolicy")]
        public async Task<ActionResult<string>> UpdateProduct(Guid id, UpdateProductDto uProduct)
        {
            var product = await _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound("Product Not Found");
            }

            var updatedProduct = _mapper.Map(uProduct, product);

            var response = await _productService.UpdateProduct(updatedProduct);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminPolicy")]
        public async Task<ActionResult<string>> DeleteProduct(Guid id)
        {
            var product = await _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound("Product Not Found");
            }

            var response = await _productService.DeleteProduct(product);
            return Ok(response);
        }
    }
}

