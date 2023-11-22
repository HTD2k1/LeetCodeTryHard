public class ThreeSumSolution {
    
    // Naive approach 308/312 testcases passed
    public IList<IList<int>> NaiveThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        HashSet<List<int>> existingTriplets = new HashSet<List<int>>(new TripletComparer());
        for (int k = 2; k < nums.Length; k++)
        {
            for (int j = 1; j < k; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var newTriplet = new List<int>() { nums[i], nums[j], nums[k] };
                        if (!existingTriplets.Contains(newTriplet))
                        {
                            result.Add(newTriplet);
                            existingTriplets.Add(newTriplet);
                        } 
                    }
                }
            }
        }
        return result;
    }

    public class TripletComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> triplet1, List<int> triplet2)
        {
            triplet1.Sort();
            triplet2.Sort();
            return triplet1.SequenceEqual(triplet2);
        }
        public int GetHashCode(List<int> triplet)
        {
            return base.GetHashCode();
        }
    }
}