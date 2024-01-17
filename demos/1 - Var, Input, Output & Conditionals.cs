// comment

/*
Defined types
*/
int x;
x = 5;
Console.WriteLine(x);

/*
You can also declare a variable an initialize it in one statement:
*/
int x = 5;
Console.WriteLine(x);

//print
Console.WriteLine("Hello World!");

/* Console.WriteLine("") will print, or write, a full line, including the new line. If you do not want a new line at the end, you can use Console.Write("") to display the text with no newline afterward. */
Console.Write("There will not be a newline after this.");

/* Also, please be aware that, unlike input in Python, you do not provide the text of the prompt to the Console.ReadLine() function in C#, so you must display it first with Console.Write(""). */
Console.Write("What is your favorite color? ");
string color = Console.ReadLine();

// curly braces define blocks
if (x > y)
{
  Console.WriteLine("greater");
}

/* String Interpolation
In C#, if you would like to use a variable inside a string, you start the string with a dollar sign $ in the same way that in Python, you start a format string with an f.*/
string school = "BYU-Idaho";
Console.WriteLine($"I am studying at {school}.");

// if statements
if (x > y)
{
    Console.WriteLine("greater than");
}

/*
If you put one block of code inside another, it should be indented as follows:
*/

if (x > y)
{
    if (x > z)
    {
        Console.WriteLine("greater than both");
    }
}

/* Else and Else If */

if (x > y)
{
    Console.WriteLine("greater than");
}
else
{
    Console.WriteLine("less than");
}

/* The else if condition also defines its body in the same fashion. Please note that in C#, the keywords are else if not elif: */
if (x > y)
{
    Console.WriteLine("greater than y");
}
else if (x > z)
{
    Console.WriteLine("greater than z");
}
else
{
    Console.WriteLine("less than both");
}

// Operators
if (name == "John")
{
    Console.WriteLine("The name is John");
}

if (color != favoriteColor)
{
    Console.WriteLine("That color is not my favorite");
}

// And, Or, and Not Operators

