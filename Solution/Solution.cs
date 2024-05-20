namespace Solution
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
               Dictionary<int, int> intCounts = new Dictionary<int,int>();
                
                foreach (int num in nums)
            {
                if (intCounts.ContainsKey(num))
                {
                    return true;
                }
                else
                {
                    intCounts.Add(num, 1);
                }
            }


            return false;            
        }
    }
}

