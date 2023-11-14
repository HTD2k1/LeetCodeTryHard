public class LongestConsecutiveSequenceSolution
{
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0 || nums == null) return 0;
        HashSet<int> hashSet = new HashSet<int>(nums);
        int longestSequence = 1, currentSequenceLength = 1, currentNum = 0;
        foreach(var num in hashSet){
            if(!hashSet.Contains(num - 1)){
                currentNum = num;
                while(hashSet.Contains(currentNum + 1))
                {   
                    currentSequenceLength++;
                    currentNum++;
                }
                longestSequence = Math.Max(currentSequenceLength, longestSequence);
                currentSequenceLength = 1;
            }
        }
        
        return longestSequence;
    }
}