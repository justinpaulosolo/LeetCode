public class ValidAnagramSolution
{
    public bool isAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dict1 = new Dictionary<char, int>();

        foreach(char ch in s)
        {
            if(dict1.ContainsKey(ch))
                dict1[ch]++;
            else
                dict1[ch] = 1;
        }

        foreach(char ch in t)
        {
            if(dict1.ContainsKey(ch))
            {
                if(dict1[ch] == 0)
                    return false;
                dict1[ch]--;
            }
            else
                return false;
        }

        return true;
    }
}
