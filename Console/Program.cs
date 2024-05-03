//1.PartReverser

using Tasks.Daily.April2024;
using Tasks.LeetCode75.ArrayStringTopic;

//var reverser = new PartReverser();

//var case1 = reverser.ReversePrefix1("abcdefd", 'd'); //expected "dcbaefd"
//var case2 = reverser.ReversePrefix1("xyxzxe", 'z');  //expected "zxyxxe"
//var case3 = reverser.ReversePrefix1("abcd", 'z');    //expected "abcd"

//Console.WriteLine($"{case1}\n{case2}\n{case3} ");

// ----------------------------------------------------------------------------

//var reverser = new VowelsReverser();

//var case1 = reverser.ReverseVowels("leetcode"); //expected "leotcede"

//Console.WriteLine($"{case1}");

// ----------------------------------------------------------------------------

//var calculator = new ProductExceptSelfCalculator();
//var result1 = calculator.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
//var result2 = calculator.ProductExceptSelf(new int[] { 1, 1 });

// ----------------------------------------------------------------------------

var comparator = new VersionsComparator();
var result1 = comparator.CompareVersion("1.01", "1.001");
var result2 = comparator.CompareVersion("1.0", "1.000");
var result3 = comparator.CompareVersion("0.1", "1.0.0");
