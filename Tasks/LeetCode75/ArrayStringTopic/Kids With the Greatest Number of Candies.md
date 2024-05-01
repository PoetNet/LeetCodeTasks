## Solution

---

### Overview

We are given an integer array `candies`, where each `candies[i]` represents the number of candies the ithi^{th}ith kid has, and an integer `extraCandies`, denoting the number of extra candies that you have.

Our task is to return a boolean array `result` of length `n`, where `result[i]` is true if, after giving the ithi^{th}ith kid all the `extraCandies`, they will have the greatest number of candies among all the kids, or `false` otherwise.

---

### Approach: Ad Hoc

#### Intuition

We precompute the greatest number of candies that any kid(s) has, let's call it `maxCandies`.

Following the precomputation, we iterate over `candies`, checking whether the total candies that the current kid has exceeds `maxCandies` after giving `extraCandies` to the kid. For every kid, we perform `candies[i] + extraCandies >= maxCandies` and push it into a boolean list called `result`.

In the end, we return `result`.

Here's a visual representation of how the approach works in the first example given in the problem description:

![img](https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/Figures/1431/1431-1.png)

#### Algorithm

1. Create an integer variable called `maxCandies` to store the greatest number of candies in `candies`. We initialize it with `0`.
2. We iterate over `candies` and for each kid who has `candy` candies, we perform `maxCandies = max(maxCandies, candy)` to get the greatest number of candies in `candies`.
3. Create a boolean list `answer`.
4. We iterate over `candies` once more, and for each kid who has `candy` candies, we add `candy + extraCandies >= maxCandies` to `answer`.
5. Return `answer`.

#### Implementation

#### Complexity Analysis

Here, nnn is the number of kids.

- Time complexity: O(n)O(n)O(n)
    
    - We iterate over the `candies` array to find out `maxCandies` which takes O(n)O(n)O(n) time.
    - We iterate over the `candies` array once more. We check for each kid whether they will have the most candies among all the children after receiving `extraCandies` and push the result in `result` which takes O(1)O(1)O(1) time. It requires O(n)O(n)O(n) time for nnn kids.
- Space complexity: O(1)O(1)O(1)
    
    - Without counting the space of input and output, we are not using any space except for some integers like `maxCandies` and `candy`.

# 5. [[Reverse Vowels of a String]]

Easy

Topics

Companies

Given a string `s`, reverse only all the vowels in the string and return it.

The vowels are `'a'`, `'e'`, `'i'`, `'o'`, and `'u'`, and they can appear in both lower and upper cases, more than once.

**Example 1:**

**Input:** s = "hello"
**Output:** "holle"

**Example 2:**

**Input:** s = "leetcode"
**Output:** "leotcede"

**Constraints:**

- `1 <= s.length <= 3 * 105`
- `s` consist of **printable ASCII** characters.