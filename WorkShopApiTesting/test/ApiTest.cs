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
        [Fact]
        public void GetScTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.GetSc();

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void DeleteScTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var resutl = api.DeleteSc();

            //Assert
            Assert.NotNull(resutl);
        }
        [Fact]
        public void PatchScTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.PatchSc();

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void PostScTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.PostSc();

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void PutScTest()
        {
            //Arrange
            var api = new Api();

            //Act
            var result = api.PutSc();

            //Assert
            Assert.NotNull(result);
        }
    }
}
