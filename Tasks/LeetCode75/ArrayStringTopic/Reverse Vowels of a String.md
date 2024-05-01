# Approach

- Identify Vowels and Their Indexes:
    
    - Iterate through the given string s.
    - For each character, check if it is a vowel (either lowercase or uppercase).
    - If a vowel is found, push it onto a stack, and store its index in a HashSet (indexesOfVowels) for later retrieval.
- Reverse Vowels in the String:
    
    - Iterate through the string again.
    - For each character at index i, if i is in the set of vowel indexes (indexesOfVowels):
    - Pop a vowel from the stack, which ensures the order of vowels is reversed.
    - Replace the character at index i with the popped vowel.
- Return the Result:
    
    - Convert the modified string to a final result and return it.

## Summary:

The HashSet (`vowels`) is used to quickly check if a character is a vowel. The Stack (`vowelsInTheString`) is employed to store the vowels in reverse order. The HashSet (`indexesOfVowels`) helps identify the indexes of vowels in the string for efficient retrieval during the reversal process. These data structures streamline the process of identifying and reversing vowels in the string.

```C#
public class Solution {
    public string ReverseVowels(string s) {
        Stack<char> vowelsInTheString = new Stack<char>();
        HashSet<char> vowels = new HashSet<char>(){'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I'};
        HashSet<int> indexesOfVowels = new HashSet<int>();
        StringBuilder result = new StringBuilder(s);    

        for (var i = 0; i < s.Length; i++)
        {
            if(vowels.Contains(s[i])){
                vowelsInTheString.Push(s[i]);
                indexesOfVowels.Add(i);
            }
        }

        for (var i = 0; i < s.Length; i++)
        {
            if(indexesOfVowels.Contains(i)){
                result[i] = vowelsInTheString.Pop();
            }
        }

        return result.ToString();
    }
}
```