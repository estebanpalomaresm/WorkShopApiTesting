using System;
using System.Collections.Generic;
using System.Text;
using WorkShopApiTesting.src;
using WorkShopApiTesting.src.utils;
using Xunit;

namespace WorkShopApiTesting.test
{
    public class ApiStatusCodeTest
    {

        [Theory]
        [ClassData(typeof(ApiStatusCodeTestData))]
        public void GetTest(int statusCode, int expectedStatusCode)
        {
            //Arrange
            var api = new ApiStatusCode();

            //Act
            var result = api.Get(statusCode);

            //Assert
            Assert.Equal((int)result.StatusCode, expectedStatusCode);
        }
        [Theory]
        [ClassData(typeof(ApiStatusCodeTestData))]
        public void DeleteTest(int statusCode, int expectedStatusCode)
        {
            //Arrange
            var api = new ApiStatusCode();

            //Act
            var result = api.Delete(statusCode);

            //Assert
            Assert.Equal((int)result.StatusCode, expectedStatusCode);
        }
        [Theory]
        [ClassData(typeof(ApiStatusCodeTestData))]
        public void PatchTest(int statusCode, int expectedStatusCode)
        {
            //Arrange
            var api = new ApiStatusCode();

            //Act
            var result = api.Patch(statusCode);

            //Assert
            Assert.Equal((int)result.StatusCode, expectedStatusCode);
        }
        [Theory]
        [ClassData(typeof(ApiStatusCodeTestData))]
        public void PostTest(int statusCode, int expectedStatusCode)
        {
            //Arrange
            var api = new ApiStatusCode();

            //Act
            var result = api.Post(statusCode);

            //Assert
            Assert.Equal((int)result.StatusCode, expectedStatusCode);
        }
        [Theory]
        [ClassData(typeof(ApiStatusCodeTestData))]
        public void PutTest(int statusCode, int expectedStatusCode)
        {
            //Arrange
            var api = new ApiStatusCode();

            //Act
            var result = api.Put(statusCode);

            //Assert
            Assert.Equal((int)result.StatusCode, expectedStatusCode);
        }
    }
}
