using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WorkShopApiTesting.src.utils
{
    public class ApiStatusCodeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 200, 200 };
            yield return new object[] { 300, 300 };
            yield return new object[] { 400, 400 };
            yield return new object[] { 500, 500 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
