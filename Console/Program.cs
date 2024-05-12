using Tasks.Daily.April2024;
using Tasks.Daily.May2024;
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

//var comparator = new VersionsComparator();
//var result1 = comparator.CompareVersion1("1.01", "1.001");
//var result2 = comparator.CompareVersion1("1.0", "1.000");
//var result3 = comparator.CompareVersion1("0.1", "1.0.0");

// ----------------------------------------------------------------------------

//var comparator = new IncreasingTripletFinder();
//var result1 = comparator.IncreasingTriplet(new int[] { 0, 100, 10, 12, 5, 13 });

// ----------------------------------------------------------------------------

//var compressor = new StringCompressor();
//var result1 = compressor.Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });

// ----------------------------------------------------------------------------

//var result1 = BoatCounter.NumRescueBoats(new int[] { 1, 5, 3, 5 }, 7);
//var result2 = BoatCounter.NumRescueBoats(new int[] { 21, 40, 16, 24, 30 }, 50);

// ----------------------------------------------------------------------------

//var result1 = PairsCounter.CountPairs(new int[] { -1, 1, 2, 3, 1 }, 2);
//var result2 = PairsCounter.CountPairs(new int[] { -6, 2, 5, -2, -7, -1, 3 }, -2);

// ----------------------------------------------------------------------------

//var result1 = PrimeFractionFinder.KthSmallestPrimeFraction(new int[] { 1, 2, 3, 5 }, 3);

// ----------------------------------------------------------------------------

var result1 = MatrixMaxLocalFinder.LargestLocal(new int[][] 
{ 
    new int[] { 9, 9, 8, 1 }, 
    new int[] { 5, 6, 2, 6 }, 
    new int[] { 8, 2, 6, 4 }, 
    new int[] { 6, 2, 2, 2 } 
});

Console.ReadLine();
