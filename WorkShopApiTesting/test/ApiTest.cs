using System;
using System.Collections.Generic;
using System.Text;
using WorkShopApiTesting.src;
using Xunit;

namespace WorkShopApiTesting.test
{
    public class ApiTest
    {

        [Fact]
        public void GetTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.Get();

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void DeleteTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.Delete();

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void PatchTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.Patch();

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void PostTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.Post();

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void PutTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.Put();

            //Assert
            Assert.NotNull(result);
        }        
    }
}
