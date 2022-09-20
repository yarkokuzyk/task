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
        
# Task 2.0<br />
SCENARIO: Check the Multiplier Counter with auto-generated array<br />
GIVEN ArrayGenerate function is called
AND array is filled with int numbers
WHEN MultiplierCounter function is called
THEN number of multipliers either 4 or 6 is shown


SCENARIO: Check the Multiplier Counter with manualy-defined array<br />
GIVEN An array with {4,6,1,2,-20,5,10,12) values <br />
WHEN Multiplier Counter function is called<br />
THEN "number of multipliers either 4 or 6 = 4" message is shown <br />

SCENARIO: Check the Multiplier Counter with invalid data<br />
GIVEN An array with string values <br />
WHEN Multiplier Counter function is called with string array <br />
THEN error message is shown <br />

# Task 2.1

 SCENARIO: Check IsPalindrome() function with palindrome value <br />
 GIVEN Palindrome function is called<br />
 WHEN User has entered a string "1221"<br />
 THEN "True" output is shown <br />
 
 SCENARIO: Check IsPalindrome() function with not palindrome value<br />
 GIVEN Palindrome function is called<br />
 WHEN User has entered a string "notpalindrome"<br />
 THEN "false" output is shown <br />
 
 # Task 3.0
 
 
 


