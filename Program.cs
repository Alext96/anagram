public class Program
{
    public static void Main()
    {
        Anagram anagram = new Anagram();
        string s1 = "salesman";
        string s2 = "nameless";
        var isAnagram = anagram.areAnagrams(s1, s2);
        Console.WriteLine(s1 + " and " + s2 + " is anagram? " + isAnagram);
    }
}

public class Anagram
{

    public bool areAnagrams(string s1, string s2)
    {
        
        if (s1.Length != s2.Length)
        {
            return false;
        }

        Dictionary<int, int> freq1 = new Dictionary<int, int>();
        Dictionary<int, int> freq2 = new Dictionary<int, int>();

        int currentCount = 0;

        int id = 0;

        foreach (char c in s1)
        {
            if(s1.Contains(c))
            {
                freq1.TryGetValue(id, out currentCount);
                freq1[c] = currentCount + 1;
            }
            else
            {
                freq1[c] = 1;
            }
        }

        foreach (char c in s2)
        {
            if (s2.Contains(c))
            {
                freq2.TryGetValue(id, out currentCount);
                freq2[c] = currentCount + 1;
            }
            else
            {
                freq2[c] = 1;
            }
        }

        foreach (KeyValuePair<int, int> entry in freq1)
        {
            int value;
            if (freq2.TryGetValue(entry.Key, out value))
            {
                //Console.WriteLine(value);
                // Key was in dictionary; "value" contains corresponding value
            }
            else
            {
                return false;
                // Key wasn't in dictionary; "value" is now 0
            }
            // do something with entry.Value or entry.Key
            return true;
        }
        return true;
    }
}
