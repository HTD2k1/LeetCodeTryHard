
namespace DebugLeetCodeLocally.ArrayAndHashing
{

    public class TopKElementsSolution
    {
        private int[] _testNums = new int[] { 3, 0, 1, 0 };
        private int _testK = 1;
        
        // First Attemp
        // Time complexity: O(Nlog N) where N is the number of unique elements
        // Space complexity: O(N
        public int[] TopKFrequentFirstAttempt(int[] nums, int k)
        {
            Dictionary<int, int> numsFrequencies = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (numsFrequencies.ContainsKey(nums[i])) numsFrequencies[nums[i]]++;
                else numsFrequencies.Add(nums[i], 1);
            }

            return numsFrequencies.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        }
        
        // Second solution 
        // Time complexity: O(Nlog k) where k is the number of unique elements
        // Space complexity: O(N+k)
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numberFrequencies = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numberFrequencies.ContainsKey(nums[i])) numberFrequencies[nums[i]]++;
                else numberFrequencies.Add(nums[i], 1);
            }

            SortedSet<KeyValuePair<int, int>> minHeap = new SortedSet<KeyValuePair<int, int>>(new Comparer());
            foreach (var numberFrequency in numberFrequencies)
            {
                bool isMinHeapRemoved;
                 minHeap.Add(numberFrequency);
                 if (minHeap.Count > k)
                 {
                     isMinHeapRemoved = minHeap.Remove(minHeap.Min);
                 }
            }
            return minHeap.Select(x => x.Key).ToArray();
        }

        public class Comparer : IComparer<KeyValuePair<int, int>>
        {
            public int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return (x.Value != y.Value) ? x.Value.CompareTo(y.Value) : x.Key.CompareTo(y.Key);
            }
        }
    }
}