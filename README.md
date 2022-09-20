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
        
# Task 2<br />
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
 
 Summary: Error message is shown in the "jackpots" page after clicking big banner game 
 Priority: High
 Environment: PC Windows 10, Opera Browser 104.0
 Date: 09.20.2022
 Severity: Blocker
 Steps to reproduce:
 1. Open videoslots.com page
 2. Go to "Jackpots" tab
 3. Click on big banner game
 4. Pay attention to the error<br />



 Actual result: Error message is shown in the "jackpots" page after clicking big banner game<br /> 
 Expected result: Game page is opened after clicking big banner game in the jackpots page<br />
 Comments: also reproduced in other pages with big banner<br />
 Attachments:
 
https://user-images.githubusercontent.com/104302356/191267509-e83dfc71-82c2-4769-83f6-e5935644da4d.mp4


I find this defect critical because there`s no workaround, all the games from the banner cannot be opened through this way 

Summary: No search results are shown in search page after selecting a category 
 Priority: High
 Environment: PC Windows 10, Opera Browser 104.0
 Date: 09.20.2022
 Severity: Critical
 Steps to reproduce:
 1. Open videoslots.com page
 2. Click on "Jackpots" category in the side-menu
 3. Click on "Slots" category in the side-menu
 4. Pay attention that no games are shown

 Actual result: No search results are shown in search page after selecting a category <br /> 
 Expected result: Games are shown due to the category after user selecting it in the side-menu<br />
 Attachments:




https://user-images.githubusercontent.com/104302356/191270303-0dcda119-a5fc-416d-b5f3-60ed557b45f2.mp4

I find this defect critical because the main goal of this function(search) cannot be met, it breaks every time category is changed<br />


note: VideoSlots is not availible in Ukraine, so I couldn`t create a new account and check the functionality deeper, but when I tried to use VPN, I reached the requests limit<br />
