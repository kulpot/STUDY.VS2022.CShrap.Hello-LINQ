using System;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=1UqjUgcdq6g&list=PL90AF0EFFEF782D27&index=7&t=2s
//

class MainClass
{
    static void Main()
    {
        int[] numbers = new[] { 2, 4, 8, 1, 9, 2, 0, 3, 4, 2 };
        var result =
            from n in numbers
            where n < 5
            select n;
        char[] chars = new[] { 'c', 'p', 'o','t','i' };
        var vowels =
            from letter in chars
            where letter == 'a' || letter == 'e' ||
            letter == 'i' || letter == 'o' ||
            letter == 'u'
            select letter;
        //foreach(int i in result)
            //Console.WriteLine(i);
        foreach ( var c in vowels )
            Console.WriteLine(c);
    }
}