# Task 1 

Firstly, we need to create and fill an array, so I wrote for this a couple of methods: 
ArrayGenerate(int n,int min,int max) - when a method is called, we define the size of array and range of random numbers (min and max)
PrintArray(int[] array] - a function to display all the array contents
MultiplierCounter - a function with a loop inside, that checks if the number is a multiplier either 4 or 6, if it does, then the counter increases
Then, when all the methods are present, we can cope this task in only 2 lines in the main method
```C#
int[] array = ArrayGenerate(20, -20, 20);
int number = MultipleCounter(array);
```

# Task 1.1
To complete this task I chose System.Linq function str.SequenceEqual(str2)
So then, just to make it more reusable, I added a function that asks user to input a string, then system takes this input and the answer is shown
```C#
   public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());

        }
```        
        
# Task 2.1
Scenario:

