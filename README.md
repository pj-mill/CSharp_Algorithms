# CSharp_Algorithms
A console app demonstrating some rudimentary algorithms for strings, numbers, searches &amp; pyramids. More to come ...

---
### LeetCode Contests
|Context No.|Name|Difficulty|
|-----------|----|-----------|
|389|[Find The Difference](https://leetcode.com/contest/2/problems/find-the-difference/)|Easy|

---

###Math / Number Algorithms

| Algorithm | Comment |
| --------- | ------- |
| Fibonacci | Uses ThreadPool, ManualResetEvent & recursion to calculate the fibonacci spiral of 10 numbers |
| Armstrong | Demonstrate 2 ways to determine if a number is an armstrong number (number is equal to the power of all it's digits)
| Factorial | Shows 2 ways to calculate the factorial of a number using a while loop and recursion |
|Mean & Standard Deviation | Uses PLINQ's Aggregate Function to calculate the mean and Standard deviation for a set of numbers |
| Is Prime Number | Algorithm for checking prime numbers |

---

###String Algorithms

| Algorithm | Comment |
| --------- | ------- |
| Dupes | Finds and calculates the number of times a letter is duplicated in a string |
| Reverse | Shows 3 ways to reverse a string using an array, a while loop and recursion |
| Sentence Permutations | Shows an iterative approach to determining word permutations in a sentence |

---

###Search Algorithms

| Algorithm | Comment |
| --------- | ------- |
| Binary | Demonstrates the builtin c# feature and a custom divide and conquer method for performing a binary search|
| Linear | Searches sorted and unsorted lists and outputs the number of lookups it took to complete the process  |

---

###Pyramid Algorithms
#####No 1
         1
        2 2 
       3 3 3 
      4 4 4 4 
     5 5 5 5 5 
    6 6 6 6 6 6 

#####No 2
         1 
        1 2 
       1 2 3 
      1 2 3 4 
     1 2 3 4 5 
    1 2 3 4 5 6 

#####No 3
         * 
        * * 
       * * * 
      * * * * 
     * * * * * 
    * * * * * * 


#####No 4
                1 
              1 2 1 
            1 2 3 2 1 
          1 2 3 4 3 2 1 
        1 2 3 4 5 4 3 2 1 
      1 2 3 4 5 6 5 4 3 2 1 

#####No 5
      1 2 3 4 5 6 5 4 3 2 1 
        1 2 3 4 5 4 3 2 1 
          1 2 3 4 3 2 1 
            1 2 3 2 1 
              1 2 1 
                1 
                
