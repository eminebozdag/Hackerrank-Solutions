using System;

class Solution 
{
    static void Main(String[] args)
    {
        long total = 0L;
        var n = int.Parse(Console.ReadLine());
        var array = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(array, long.Parse);
        for(int i=0; i<n; i++)
            total += ar[i];
        Console.WriteLine(total);
    }
}
