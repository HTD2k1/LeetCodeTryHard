﻿//Given an array of strings strs, group the anagrams together. You can return 
//the answer in any order. 
//
// An Anagram is a word or phrase formed by rearranging the letters of a 
//different word or phrase, typically using all the original letters exactly once. 
//
// 
// Example 1: 
// Input: strs = ["eat","tea","tan","ate","nat","bat"]
//Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
// 
// Example 2: 
// Input: strs = [""]
//Output: [[""]]
// 
// Example 3: 
// Input: strs = ["a"]
//Output: [["a"]]
// 
// 
// Constraints: 
//
// 
// 1 <= strs.length <= 10⁴ 
// 0 <= strs[i].length <= 100 
// strs[i] consists of lowercase English letters. 
// 
//
// Related Topics Array Hash Table String Sorting 👍 17248 👎 508
using System.Linq;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


// Benchmarking the code in Release Mode
var summary = BenchmarkRunner.Run<Solution>();

//  Uncomment these lines for normal display 
    // IList<IList<string>> sln = new Solution().GroupAnagramsByHashedString(); 
    // string result = string.Join(Environment.NewLine, sln.Select(arr => string.Join(" ", arr)));
    // Console.WriteLine(result);

[MemoryDiagnoser]
public class Solution
{
    public readonly string[] TestStrings = new[] { "eeeeat","tea","tan","ate","nat","bat"};

    // Catagorize grouped anagrams by using Dictionary with keys that are generated by sorting the string 

    
    public string HashString()
    {
        int[] letterFreqs = new int[26];
        foreach (var c in TestStrings[0])
        {
            letterFreqs[c - 97]++;
        }
        StringBuilder builder = new StringBuilder(TestStrings[0].Length);
        for (int i = 0; i <  letterFreqs.Length; i++)
        {
            builder.Append((char) (i+'a'),letterFreqs[i]);
        }
        return builder.ToString();
    }
    
        
    public List<IList<string>> GroupAnagramsBySortedKey()
    {
        Dictionary<string, List<string>> anagramsMap = new Dictionary<string, List<string>>();
        foreach (var str in TestStrings)
        {
            // Sort the characters of the string to form the ordered key for anagramsMap
            char[] tempArr = str.ToCharArray();
            Array.Sort(tempArr);
            string key = new string(tempArr);
            //string key = new string(str.OrderBy(c => c).ToArray());  // linq one line 

            // Add the string to corresponding anagram list 
            if (!anagramsMap.TryGetValue(key, out var existingAnagram))
            {
                existingAnagram = new List<string>();
                anagramsMap[key] = existingAnagram;
            }

            existingAnagram.Add(str);
        }

        return anagramsMap.Values.ToList<IList<string>>();
    }
    
    public IList<IList<string>> GroupAnagramsByHashedString()
    {
        Dictionary<string, List<string>> anagramsMap = new Dictionary<string, List<string>>();
        foreach (var str in TestStrings)
        {
            string key = GenerateHashedString(str); 

            // Add the string to corresponding anagram list 
            if (!anagramsMap.TryGetValue(key, out var existingAnagram))
            {
                existingAnagram = new List<string>();
                anagramsMap[key] = existingAnagram;
            }

            existingAnagram.Add(str);
        }

        return anagramsMap.Values.ToList<IList<string>>();
    }
    private string GenerateHashedString(string str)
    {
        int[] letterFreqs = new int[26];
        foreach (var c in str)
        {
            letterFreqs[c - 97]++;
        }
        StringBuilder builder = new StringBuilder(str.Length);
        for (int i = 0; i <  letterFreqs.Length; i++)
        {
            builder.Append((char) (i+'a'),letterFreqs[i]);
        }
        return builder.ToString();
    }
}
