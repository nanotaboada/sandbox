/*

    Two strings are considered isomorphic if there is a 1:1 mapping between the
    letters of the two strings, and the order of the characters is preserved.

    Characters in the first (source) string must be mapped to a unique character
    in the second (target) string, and vice versa.

    Example (isomorphic)

    source = "love"
    target = "life"

    ---------------
    | Key | Value |
    ---------------
    |  l  <->  l  |
    |  o  <->  i  |
    |  v  <->  f  |
    |  e  <->  e  |
    ---------------

    The words "love" and "life" are isomorphic because we can map "l" with "l",
    "o" with "i", "v" with "f" and "e" with "e".

    Example (not isomorphic)

    ---------------
    | Key | Value |
    ---------------
    |  w  <->  p  |
    |  o  <->  o  | 
    |  r  <->  w  | /!\ inconsistency: "w" already maps to "p"
    |  d  <->  e  | 
    |  s  <->  r  |   
    ---------------

*/

string source = "love";
string target = "life";

static bool IsIsomorphic(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    // map of source (Key) and target (Value) characters
    var charMap = new Dictionary<char, char>();
    
    // set of characters that have already been mapped
    var charSet = new HashSet<char>();

    for (int i = 0; i < s.Length; i++)
    {
        // loop through the characters of both strings
        char source = s[i];
        char target = t[i];

        // check if the character from the source has already been mapped
        if (charMap.ContainsKey(source))
        {
            // verify that the mapping matches
            if (charMap[source] != target)
            {
                // inconsistency
                return false;
            }
        }
        // the character hasn't been mapped yet
        else
        {
            // check if the character from the target has already been mapped
            if (charSet.Contains(target))
            {
                // already mapped to another character
                return false;
            }

            // add the source/target character mapping
            charMap[source] = target;
            // add the target character to the set of alreaady mapped
            charSet.Add(target);
        }
    }

    return true;
}

Console.WriteLine(IsIsomorphic(source, target));