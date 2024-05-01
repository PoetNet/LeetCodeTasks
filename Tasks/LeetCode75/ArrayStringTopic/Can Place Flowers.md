## Solution

---

#### Approach #1 Single Scan [Accepted]

The solution is very simple. We can find out the extra maximum number of flowers, countcountcount, that can be planted for the given flowerbedflowerbedflowerbed arrangement. To do so, we can traverse over all the elements of the flowerbedflowerbedflowerbed and find out those elements which are 0(implying an empty position). For every such element, we check if its both adjacent positions are also empty. If so, we can plant a flower at the current position without violating the no-adjacent-flowers-rule. For the first and last elements, we need not check the previous and the next adjacent positions respectively.

If the countcountcount obtained is greater than or equal to nnn, the required number of flowers to be planted, we can plant nnn flowers in the empty spaces, otherwise not.

**Implementation**

**Complexity Analysis**

- Time complexity: O(n)O(n)O(n). A single scan of the flowerbedflowerbedflowerbed array of size nnn is done.
    
- Space complexity: O(1)O(1)O(1). Constant extra space is used.
    

---

#### Approach #2 Optimized [Accepted]

**Algorithm**

Instead of finding the maximum value of countcountcount that can be obtained, as done in the last approach, we can stop the process of checking the positions for planting the flowers as soon as countcountcount becomes equal to nnn. Doing this leads to an optimization of the first approach. If countcountcount never becomes equal to nnn, nnn flowers can't be planted at the empty positions.

**Implementation**

**Complexity Analysis**

- Time complexity: O(n)O(n)O(n). A single scan of the flowerbedflowerbedflowerbed array of size nnn is done.
    
- Space complexity: O(1)O(1)O(1). Constant extra space is used.