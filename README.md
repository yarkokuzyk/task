# Task 1 

Firstly, we need to create and fill an array, so I wrote for this a couple of methods:<br />
ArrayGenerate(int n,int min,int max) - when a method is called, we define the size of array and range of random numbers (min and max)<br />
PrintArray(int[] array) - a function to display all the array contents<br />
MultiplierCounter - a function with a loop inside, that checks if the number is a multiplier either 4 or 6, if it does, then the counter increases<br />
Then, when all the methods are present, we can cope this task in only 2 lines in the main method<br />
```C#
int[] array = ArrayGenerate(20, -20, 20);
int number = MultiplierCounter(array);
```

# Task 1.1<br />
To complete this task I chose System.Linq function str.SequenceEqual(str2)<br />
So then, just to make it more reusable, I added a function that asks user to input a string, then system takes this input and the answer is shown<br />
```C#
   public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());

        }
```        
        
# Task 2.1<br />
Scenario: Check the Multiplier Counter with auto-generated array<br />
Given ArrayGenerate function is called
And array is filled with int numbers
When MultiplierCounter
Then


