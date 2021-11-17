using System.Collections;
using System.Collections.Generic;

namespace UTExamples.Test
{
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 1, -1, 0 };
            yield return new object[] { -1, -1, -2 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
