using AutoMapper;
using AvaliacaoTecnica.DTO;
using AvaliacaoTecnica.DTO.Request;
using Db.Entitites;
using Db.Exceptions;
using Db.Repositories.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Moq;
using Service.Contracts;
using Service.Implementations;
using System;
using Xunit;

namespace UnitTests.Services
{
    public class ProductServiceTest
    {
        private ProductService productService;

        public ProductServiceTest()
        {
            productService = new ProductService(new Mock<IMapper>().Object, new Mock<IProductRepository>().Object);
        }

        [Fact]
        public async void Post_SendInvalidDTO()
        {
            var result = await productService.InsertProduct(new ProductCreateDTO(){});
            Assert.False(result.Success);
        }

        [Fact]
        public async void Put_SendInvalidCode()
        {
            var result = await productService.UpdateProduct(15, new ProductCreateDTO()
            {
                Description = "Descrição Teste",
                Dimensions = "10x50",
                Code = 0,
                Reference = null,
                Stockbalance = 300,
                Price = 120.00M,
                Active = true,
                CategoryId = 1
            });

            Assert.False(result.Success);
        }

        [Fact]
        public async void Put_SendInvalidPrice()
        {

            var result = await productService.UpdateProduct(15, new ProductCreateDTO()
            {
                Description = "Descrição Teste",
                Dimensions = "10x50",
                Code = 987,
                Reference = null,
                Stockbalance = 300,
                Price = 0M,
                Active = true,
                CategoryId = 1
            });

            Assert.False(result.Success);
        }

        [Fact]
        public async void Put_SendInvalidCategoryId()
        {

            var result = await productService.UpdateProduct(15, new ProductCreateDTO()
            {
                Description = "Descrição Teste",
                Dimensions = "10x50",
                Code = 987,
                Reference = null,
                Stockbalance = 300,
                Price = 120.50M,
                Active = true,
                CategoryId = 0
            });

            Assert.False(result.Success);
        }


        [Fact]
        public async void Patch_SendInvalidJson()
        {
            var result = await productService.PatchProduct(1, new JsonPatchDocument(){});
            Assert.False(result.Success);
        }

        [Fact]
        public async void Patch_SendInvalidId()
        {
            var result = await productService.PatchProduct(int.MaxValue, new JsonPatchDocument() { });
            Assert.False(result.Success);
        }

        [Fact]
        public async void Delete_SendInvalidId()
        {
            var result = await productService.DeleteProduct(int.MaxValue);
            Assert.False(result.Success);
        }


    }
}
