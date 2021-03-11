using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WorkShopApiTesting.src.utils
{
    public static class TestFileLoader
    {
        public static string LoadFromFile(string filename)
        {
            return File.ReadAllText("data/" + filename);
        }
    }
}
