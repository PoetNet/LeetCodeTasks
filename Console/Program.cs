//1.PartReverser

using Tasks.Daily.April2024;
using Tasks.LeetCode75.ArrayStringTopic;

//var reverser = new PartReverser();

//var case1 = reverser.ReversePrefix1("abcdefd", 'd'); //expected "dcbaefd"
//var case2 = reverser.ReversePrefix1("xyxzxe", 'z');  //expected "zxyxxe"
//var case3 = reverser.ReversePrefix1("abcd", 'z');    //expected "abcd"

//Console.WriteLine($"{case1}\n{case2}\n{case3} ");

var reverser = new VowelsReverser();

var case1 = reverser.ReverseVowels("leetcode"); //expected "leotcede"

Console.WriteLine($"{case1}");

