
using System.ComponentModel;
using API.Dtos;
using API.Errors;
using AutoMapper;
using Core.Entities;
using Core.Intefaces;
using Core.Specification;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly IGenericRepository<Product> _productcontext;
        private readonly IGenericRepository<ProductBrand> _brandcontext;
        private readonly IGenericRepository<ProductType> _typecontext;
        private readonly IMapper _mapper;

        public ProductController(IGenericRepository<Product> productcontext, IGenericRepository<ProductBrand> brandcontext, IGenericRepository<ProductType> typecontext, IMapper mapper)
        {
            _brandcontext = brandcontext;
            _productcontext = productcontext;
            _typecontext = typecontext;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductToReturnDto>>> GetAllProducts(string sort)
        {
            var spec = new ProductWithTypesAndBrandsSpecification(sort);
            var products = await _productcontext.ListAsync(spec);
            return Ok(_mapper
                .Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products));
            // return products.Select(product => new ProductToReturnDto
            // {
            //     Id = product.Id,
            //     Name = product.Name,~
            //     Description = product.Description,
            //     PictureUrl = product.PictureUrl,
            //     Price = product.Price,
            //     ProductBrand = product.ProductBrand.Name,
            //     ProductType = product.ProductType.Name


            // }).ToList();
        }
        [HttpGet("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductToReturnDto>> GetProductById(int id)
        {
            var spec = new ProductWithTypesAndBrandsSpecification(id);
            var product = await _productcontext.GetEntityWithSpec(spec);
            if (product == null)
                return NotFound(new ApiResponse(404));

            //using automapper  to map the class attributes or varviables
            return _mapper.Map<Product, ProductToReturnDto>(product);

            //without using automapper  to map the class attributes or varviables
            // return new ProductToReturnDto
            // {
            //     Id = product.Id,
            //     Name = product.Name,
            //     Description = product.Description,
            //     PictureUrl = product.PictureUrl,
            //     Price = product.Price,
            //     ProductBrand = product.ProductBrand.Name,
            //     ProductType = product.ProductType.Name
            // };
        }
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            return Ok(await _brandcontext.ListAllAsync());
        }
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            return Ok(await _typecontext.ListAllAsync());
        }
    }
}