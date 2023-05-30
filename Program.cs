namespace LinqSample;

class Program
{
    static void Main(string[] args)
    {   
        // Example 1
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // or like this List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var lowNums = from num in numbers
                        where num <5
                        select num;

        Console.WriteLine("Numbers < 5");
        foreach (var x in lowNums)
        {
            Console.WriteLine(x);
        }


        // Example 2
        var first3Numbers = numbers.Take(3);
        Console.WriteLine("First 3 numbers:");
        foreach(var n in first3Numbers)
        {
            Console.WriteLine(n);
        }

        // Example 3
        var fristNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
        Console.WriteLine("First numbers less than 6");
        foreach (var num in fristNumbersLessThan6)
        {
            Console.WriteLine(num);
        }

        // Example 4
        var wordsA = new string[] {"cherry", "apple", "blueberry"};
        var wordsB = new string[] {"cherry", "apple", "blueberry"};

        bool match = wordsA.SequenceEqual(wordsB);
        Console.WriteLine($"The sequences match : {match}");

        // Example 5
        // Combine Sequences with zip, calc the dot product of two integer vectors. It uses Zip
        // To calculate the dot product, passing it a lambda function to multiple two arrays
        // Elemenet by element and sum the result.

        int[] vectorA = { 0, 2, 4, 5, 6, };
        int[] vectorB = {1, 3, 5, 7, 8};
        int dotProduct = vectorA.Zip(vectorB, (a,b) => a * b).Sum();
        Console.WriteLine($"DOt product: {dotProduct}");

        // Example 6 Query Execution
        // Lazily
        // Sequence operators form first-class queries that
        // are not executed until you enumerate over them.

        int i =  0;
        var q = from n in numbers  
                select ++i;
        // To change from lazy to eager just add .ToList();
        foreach(var v in q)
        {
            Console.WriteLine($"v= {v}, i = {i}");
        }




        

        

    }
}
