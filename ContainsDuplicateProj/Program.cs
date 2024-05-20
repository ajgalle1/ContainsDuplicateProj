using Solution;

namespace ContainsDuplicateProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = {1, 2, 2};

            Solution.Solution solution = new Solution.Solution();

            Console.Write(solution.ContainsDuplicate(myArr));



        }
    }
}
