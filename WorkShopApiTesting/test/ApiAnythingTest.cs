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
        public void PostTest(string jsonString)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonFile = TestFileLoader.LoadFromFile(jsonString);

            //Act
            var result = api.Post(jsonFile);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonResult["data"],jsonFile));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void DeleteTest(string jsonString)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonFile = TestFileLoader.LoadFromFile(jsonString);

            //Act
            var result = api.Delete(jsonFile);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonResult["data"], jsonFile));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void PutTest(string jsonString)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonFile = TestFileLoader.LoadFromFile(jsonString);

            //Act
            var result = api.Put(jsonFile);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonFile, jsonResult["json"]));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void PatchTest(string jsonString)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonFile = TestFileLoader.LoadFromFile(jsonString);

            //Act
            var result = api.Patch(jsonFile);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.True(JToken.DeepEquals(jsonFile, jsonResult["data"]));
        }

        [Theory]
        [InlineData("user_01.json")]
        [InlineData("user_02.json")]
        public void GetTest(string jsonString)
        {
            //Arrange
            ApiAnything api = new ApiAnything();
            var jsonFile = TestFileLoader.LoadFromFile(jsonString);

            //Act
            var result = api.Get(jsonFile);
            var jsonResult = JObject.Parse(result.Content);

            //Assert
            Assert.NotNull(jsonResult["json"]);
        }
    }
}
