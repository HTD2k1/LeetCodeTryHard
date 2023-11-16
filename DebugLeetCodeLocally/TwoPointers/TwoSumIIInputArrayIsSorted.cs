public class TwoSumIIInputArrayIsSortedSolution {
    // Solution if input array is not sorted
    // public int[] TwoSum(int[] numbers, int target) {
    //     Dictionary<int,int> numberFrequencies = new Dictionary<int,int>();
    //     for(int i = 0; i < numbers.Length; i++)
    //     {
    //         if(!numberFrequencies.ContainsKey(target - numbers[i])){
    //             numberFrequencies.TryAdd(numbers[i],i);
    //         }
    //         else{
    //             return new int[] {numberFrequencies[target - numbers[i]]+1, i+1};
    //         }
    //     }
    //     return new int[] {0, 0};
    // }
    
    public int[] TwoSum(int[] numbers, int target) {
        int sum = 0;
        for( int i = 0, j = numbers.Length - 1; i <j;){
            sum = numbers[i] + numbers[j];
            if( sum > target){
                j--;
            } 
            if(sum < target){
                i++;
            } 
            if (sum == target) return new int[] {i+1, j+ 1};
        }
        return new int[] {0, 0};
    }
}