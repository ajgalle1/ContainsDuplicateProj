using Shouldly;

namespace SolutionTests

{
    public class TestCheckDuplicateMethod
    {

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, false)]
        [InlineData(new[] {1, 2, 2}, true)]

        public void Test1(int[] myArr, bool expected)
        {
            //arrange

            Solution.Solution solution = new Solution.Solution();

            //act

            var actual = solution.ContainsDuplicate(myArr);

            //assert
            actual.ShouldBe(expected, $"Something went wrong! {myArr} has a problem");

        }
    }
}