// Codec is the machine name that is used in Leetcode problem for the class that does encoding and decoding string.

using System.Text;
using Microsoft.Extensions.Primitives;

public class Codec
{
    // Encodes a list of strings to a single string by using non-ASCII characters.
    // This is not practical outside leetcode as in real world, non-ASCII chars exists
    public string encodeUsingNonASCIICharacters(IList<string> strs) {
        string encoded_string = "";
        encoded_string = String.Join("π", strs);
        Console.WriteLine(encoded_string);
        return encoded_string;
    }

    // Decodes a single string to a list of strings.
    public IList<string> decodeUsingNonASCIICharacters(string s) {
        var strs = s.Split("π");
        return new List<string>(strs);
    }

    public IList<string> ExecuteUsingNonASCIICharacters(IList<string> strs)
    {
        Codec codec = new Codec();
        var result = codec.decodeUsingNonASCIICharacters(codec.encodeUsingNonASCIICharacters(strs));
        return result;
    }

    public string encode(IList<string> strs)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string str in strs)
        {
            str.Replace("/", "//");
            sb.Append(new string[] {str, "/:" });
        }

        return sb.ToString();
    }
}