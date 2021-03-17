using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace WorkShopApiTesting.src.utils
{
    public class ApiController 
    {
        private IConfiguration apiConfig;

        public ApiController(IConfiguration configuration)
        {
            apiConfig = configuration;
        }
    }
}
