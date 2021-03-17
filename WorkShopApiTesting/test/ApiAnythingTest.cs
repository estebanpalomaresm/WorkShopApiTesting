using Newtonsoft.Json.Linq;
using WorkShopApiTesting.src.end_points;
using WorkShopApiTesting.src.utils;
using Xunit;

namespace WorkShopApiTesting.test
{
    public class ApiAnythingTest
    {
        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void PostTest(string jsonFileName)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonString = TestFileLoader.LoadFromFile(jsonFileName);

            //Act
            var result = api.Post(jsonString);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonResult["data"],jsonString));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void DeleteTest(string jsonFileName)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonString = TestFileLoader.LoadFromFile(jsonFileName);

            //Act
            var result = api.Delete(jsonString);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonResult["data"], jsonString));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void PutTest(string jsonFileName)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonString = TestFileLoader.LoadFromFile(jsonFileName);

            //Act
            var result = api.Put(jsonString);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonResult["json"], jsonString));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void PatchTest(string jsonFileName)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonString = TestFileLoader.LoadFromFile(jsonFileName);

            //Act
            var result = api.Patch(jsonString);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonString, jsonResult["data"]));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void GetTest(string jsonFileName)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonString = TestFileLoader.LoadFromFile(jsonFileName);

            //Act
            var result = api.Get(jsonString);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.NotNull(jsonResult["json"]);
        }
    }
}
