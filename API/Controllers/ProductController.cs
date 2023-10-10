
using Core.Entities;
using Core.Intefaces;
using Core.Specification;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class ProductController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productcontext;
        private readonly IGenericRepository<ProductBrand> _brandcontext;
        private readonly IGenericRepository<ProductType> _typecontext;

        public ProductController(IGenericRepository<Product> productcontext, IGenericRepository<ProductBrand> brandcontext, IGenericRepository<ProductType> typecontext)
        {
            _brandcontext = brandcontext;
            _productcontext = productcontext;
            _typecontext = typecontext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var spec = new ProductWithTypesAndBrandsSpecification();
            var products = await _productcontext.ListAsync(spec);
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var spec = new ProductWithTypesAndBrandsSpecification(id);
            var product = await _productcontext.GetEntityWithSpec(spec);
            return Ok(product);
        }
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            return Ok(await _brandcontext.ListAllAsync());
        }
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductTypes()
        {
            return Ok(await _typecontext.ListAllAsync());
        }
    }
}