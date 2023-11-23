public class ThreeSumSolution {
    
    //Naive approach 308/312 testcases passed
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
    
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length - 2; i++) {
            // Skip duplicate values for i
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1, right = nums.Length - 1;

            while(left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if(sum == 0) {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicate values for left
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    // Skip duplicate values for right
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                } else if (sum < 0) {
                    left++;
                } else {
                    right--;
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