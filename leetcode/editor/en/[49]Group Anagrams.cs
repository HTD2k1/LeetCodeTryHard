public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramsMap = new Dictionary<string, List<string>>();
        foreach (var str in strs)
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
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i <  letterFreqs.Length; i++)
        {
            if (letterFreqs[i] == 0) continue;
            builder.Append((char) (i+'a')+ Convert.ToChar(letterFreqs[i]));
        }
        return builder.ToString();
    }
}