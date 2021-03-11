using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using WorkShopApiTesting.src.end_points;
using WorkShopApiTesting.src.utils;
using Xunit;

namespace WorkShopApiTesting.test
{
    public class ApiAnythingTest
    {
        [Fact]
        public void PostTest()
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonString = TestFileLoader.LoadFromFile("user_01.json");

            //Act
            var result = api.Post(jsonString);

            //Assert
            var jsonResult = JObject.Parse(result.Content);
            Assert.Equal(jsonResult["json"].ToString(),jsonString.ToString());
        }

    }
}
