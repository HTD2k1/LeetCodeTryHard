public class IsValidPalindromeSolution {
    public bool IsPalindrome(string s) {
        int i = 0, j = s.Length - 1;
        while(i < j)
        {
            if (!char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }
            if ((Char.ToLower(s[i])) != Char.ToLower(s[j])) return false;
            i++;
            j--;
        }        
        // Checking
        return true;
    }

}