//1.PartReverser

using Tasks.Daily.April2024;

var reverser = new PartReverser();

var case1 = reverser.ReversePrefix1("abcdefd", 'd'); //expected "dcbaefd"
var case2 = reverser.ReversePrefix1("xyxzxe", 'z');  //expected "zxyxxe"
var case3 = reverser.ReversePrefix1("abcd", 'z');    //expected "abcd"

Console.WriteLine($"{case1}\n{case2}\n{case3} ");
