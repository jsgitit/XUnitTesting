using System.Collections.Generic;

namespace GameEngine.Tests
{
    public class InternalHealthDamageTestData
    {
        // Create a list of test data objects, "Data", to share accross multiple test methods

        //private static readonly List<object[]> Data = new List<object[]>
        //{
        //    new object[] {0,100},
        //    new object[] {1,99},
        //    new object[] {50,50},
        //    new object[] {101,1}
        //};

        // ... and then expose the TestData property with Getter to Data
        //
        // public static IEnumerable<object[]> TestData => Data;

        // ... or better yet, simplify this by using "yield return"
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 0, 100 };
                yield return new object[] { 1, 99 };
                yield return new object[] { 50, 50 };
                yield return new object[] { 75, 25 };
                yield return new object[] { 101, 1 };
            }
        }
    }
}
