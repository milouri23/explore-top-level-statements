#region Initial comparison

// Hello World without top-level statements

//using System;

//namespace Application
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

// Hello world with top-level statements

//Console.WriteLine("Hello, World!");

#endregion

/*
 * You can use top-level statements for scripting scenarios or to explore.
 *
 * Once you've got the basics working, you can start refactoring the code
 * and create methods, classes or other assemblies for reusable components
 * you've built.
 */

// Inside the project folder
// dotnet run -- Should I use top level statements in all my programs?

// Inside the solution folder
// dotnet run --project .\src\TopLevelStatementsApp\ -- Should I use top level statements in all my programs?

using TopLevelStatementsApp;

Console.WriteLine();
Console.WriteLine($"Procesando {args.Length} argumentos");
Console.WriteLine();

foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}
Console.WriteLine();

// This adds automatically the async modifier to the program entry point
// The program returns a Task<T>
// If don't specify a return, the program returns a Task
await Utilities.ShowConsoleAnimation();

Console.WriteLine();

string[] answers =
{
    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
};

var index = new Random().Next(answers.Length);
Console.WriteLine(answers[index]);