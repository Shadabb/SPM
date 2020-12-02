using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SPM.API.Dtos;
using SPM.API.Models;
using SPM.API.Repository;
using Newtonsoft.Json.Serialization;
using SPM.API.Configuration;

namespace SPM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepo _repository;
        private IMapper _mapper;
        private FeaturesConfig _featuresConfig;
        //private readonly HttpClient _httpClient;
        //private ExternalServicesConfig _externalServicesConfig;

        //public ProductsController(IProductRepo repository, IMapper mapper, IOptions<FeaturesConfig> options, HttpClient httpClient, IOptionsMonitor<ExternalServicesConfig> externalServicesOptions)
        public ProductsController(IProductRepo repository, IMapper mapper, IOptions<FeaturesConfig> options) 
        {

            _repository = repository;
            _mapper = mapper;
            _featuresConfig = options.Value;

            //var externalServicesConfig = externalServicesOptions.Get(ExternalServicesConfig.WeatherApi);

            //httpClient.BaseAddress = new Uri(externalServicesConfig.Url);
            //_httpClient = httpClient;
        }

        //GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> GetAllProducts()
        {
            var enableWeatherForecast =_featuresConfig.EnableWeatherForecast;
            var enableGreeting =_featuresConfig.EnableGreeting;
            var forecastSectionTitle = _featuresConfig.ForecastSectionTitle;

            //var url = _httpClient;


            var productItems = _repository.GetAllProducts();
            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }


        //GET api/products/{id}
        [HttpGet("{id}", Name="GetProductById")]
        public ActionResult<ProductReadDto> GetProductById(int id)
        {
            var productItem = _repository.GetProductById(id);

            if (productItem != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(productItem));
            }

            return NotFound();
        }

        //Post api/products
        [HttpPost]
        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto productCreateDto)
        {
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.CreateProduct(productModel);
            _repository.SaveChanges();


            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtRoute(nameof(GetProductById), new {Id = productReadDto.Id}, productReadDto);
        }

        //PUT api/products/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if (productModelFromRepo == null)
            {
                return NotFound("Couldn't find the Product");
            }

            _mapper.Map(productUpdateDto, productModelFromRepo);

            _repository.UpdateProduct(productModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/products/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialProductUpdate(int id, JsonPatchDocument<ProductUpdateDto> patchProduct)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }

            var productPatch = _mapper.Map<ProductUpdateDto>(productModelFromRepo);
            patchProduct.ApplyTo(productPatch, ModelState);

            if (!TryValidateModel(productPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(productPatch, productModelFromRepo);

            _repository.UpdateProduct(productModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteProduct(productModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}