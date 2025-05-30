
# Two Sum - LeetCode Problem

### ✅ Problem
Given an array of integers `nums` and an integer `target`, return the indices of the two numbers such that they add up to `target`.

You may assume that each input would have **exactly one solution**, and you may not use the same element twice.

Return the answer in any order.

### 🔍 Examples

#### Example 1:
```
Input: nums = [2,7,11,15], target = 9  
Output: [0,1]
```

#### Example 2:
```
Input: nums = [3,2,4], target = 6  
Output: [1,2]
```

---

### 🧠 Approaches Used

#### 1. Brute Force (Commented Out in Code)
- Nested loop to try every pair
- Time Complexity: `O(n^2)`
- Space Complexity: `O(1)`

#### 2. Optimized (HashMap Approach)
- Stores values and indices in a dictionary
- Time Complexity: `O(n)`
- Space Complexity: `O(n)`

---

### 🛠️ How to Run
```bash
dotnet run
```

---

## 🗂 File Info

- `Program.cs`: Main logic with brute force and optimized code.
- `TwoSumApp.csproj`: Project config file generated by .NET CLI.

---

## ✅ Summary
This repository demonstrates two ways to solve the classic "Two Sum" problem, focusing on clarity, time-space tradeoffs, and clean code organization.

---

### 📌 GitHub Repo Structure Example

```
Leetcode-Solutions/
└── TwoSum/
    ├── Program.cs
    ├── TwoSumApp.csproj
    └── README.md
```
