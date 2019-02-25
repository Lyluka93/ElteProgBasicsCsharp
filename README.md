# ElteProgBasicsCsharp

## Introduction

This repository consists of practice exercises which are from ELTE programming course. 

For the official sources, see the **References** section. 

## References 

The official source of the original ELTE course: http://progalap.elte.hu/ 

The source of a proper Markdown how-to tutorial: https://markdown-it.github.io/

**C#** - related tutorial **(1)**: https://www.tutorialspoint.com/csharp/index.htm

## Tasks 

# Task001

Get a Natural number from user input. If it is not positive or Natural number, then indicate the trouble and exit the program. If it is positive, then write out the given number. 

# Description of my solution

Let’s declare an ‘int’ variable called userInput! Then, I use Console.WriteLine() to ask the user for a whole number, which I have to declare as the value of userInput. But, some trouble appears. We need a whole number from user input, however, user input is ‘string’ by default. Integer in C# is always a whole number but can’t come immediately from a string. This means conversion is necessary to get an ‘int’ value from user input. Therefore, I must check the Microsoft Documentation for some help, and then I can find Int32.TryParse() method which is perfect for my aim. 
Then, I have to check with a condition if the whole number is positive or not. When the condition is true, the number is written on the console, but when it is false, a message appears on the console: "You haven't entered a positive whole number! The program will close."
Of course, I have to make sure what the user gives as a whole number is REALLY a whole number. If the conversion is successful, then there is a whole number that I can work with. So, I need to check this first, because this is the condition I can move on. When this condition is false, a message appears on the console: “You haven't entered a whole number! The program will close.”


# My solution: https://github.com/Lyluka93/ElteProgBasicsCsharp/blob/master/Exercises/Task001.cs

# References

https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?redirectedfrom=MSDN&view=netframework-4.7.2#System_Int32_TryParse_System_String_System_Int32__
