# Daily Tasks

### 1. Reverse Prefix of Word

Given a 0-indexed string `word` and a character `ch`, reverse the segment of word that starts at index `0` and ends at the index of the first occurrence of `ch` (inclusive). If the character `ch` does not exist in `word`, do nothing.

For example, if `word = "abcdefd"` and `ch = "d"`, then you should reverse the segment that starts at `0` and ends at `3` (inclusive). The resulting string will be `"dcbaefd"`.
Return the resulting string.

 

### Example 1:
Input: word = "abcdefd", ch = "d"
Output: "dcbaefd"
Explanation: The first occurrence of "d" is at index 3. 
Reverse the part of word from 0 to 3 (inclusive), the resulting string is "dcbaefd".

### Example 2:
Input: word = "xyxzxe", ch = "z"
Output: "zxyxxe"
Explanation: The first and only occurrence of "z" is at index 3.
Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

### Example 3:
Input: word = "abcd", ch = "z"
Output: "abcd"
Explanation: "z" does not exist in word.
You should not do any reverse operation, the resulting string is "abcd".
 

### Constraints:

1 <= word.length <= 250
word consists of lowercase English letters.
ch is a lowercase English letter.

### 2. [Largest Positive Integer That Exists With Its Negative](https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative/)

#Easy

Given an integer array `nums` that **does not contain** any zeros, find **the largest positive** integer `k` such that `-k` also exists in the array.

Return _the positive integer_ `k`. If there is no such integer, return `-1`.

**Example 1:**

**Input:** nums = [-1,2,-3,3]
**Output:** 3
**Explanation:** 3 is the only valid k we can find in the array.

**Example 2:**

**Input:** nums = [-1,10,6,7,-7,1]
**Output:** 7
**Explanation:** Both 1 and 7 have their corresponding negative values in the array. 7 has a larger value.

**Example 3:**

**Input:** nums = [-10,8,6,7,-2,-3]
**Output:** -1
**Explanation:** There is no a single valid k, we return -1.

**Constraints:**

- `1 <= nums.length <= 1000`
- `-1000 <= nums[i] <= 1000`
- `nums[i] != 0`