

#region switch

//int key = 9;
//switch (key)
//{
//    case 0:
//    case 3:
//    case 9:
//    case 15: Console.WriteLine("0 3 9 15"); break;
//    case 1: Console.WriteLine("1"); break;
//    default:
//        break;
//}

//var key = Console.ReadKey();
//switch (key.Key)
//{
//    case ConsoleKey.Backspace:
//        break;
//    case ConsoleKey.Tab:
//        break;
//    case ConsoleKey.Clear:
//        break;
//    default:
//        break;
//}

#endregion

#region Array


// Array

////int[] ints = { 1, 2, 3 };
//int[] ints = new int[] { 1, 1, 2, 2, 2, 22, 2 };
////for (int i = 0; i < ints.Length; i++)
////{
////    Console.WriteLine(ints[i]);
////}
//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}

//_ = Console.ReadLine();

//int[] ints = { 1, 2, 3 };

//Array.Resize(ref ints, ints.Length + 1);



//foreach (var item in ints)
//{
//    Console.Write($"{item} "); // interpolation
//}

//string[] names = { "Ayshan oxumursan", "deist Islam", "geciken Rustem" };

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

// Mutidimensional Array
// Rectangular Array

//int[,] rectArr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//int[,] rectArr1 = new int[4, 3];
//int[,] rectArr2 = new int[2, 3]
//{
//    { 1, 2, 3 },
//    { 4, 5, 6 }
//};
//Console.WriteLine(rectArr2[0, 2]);
//foreach (var item in rectArr2)
//{
//    Console.Write($"{item} ");
//}

// Jagged Array

//int[][] jaggedArray = new int[3][];
//jaggedArray[0] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//jaggedArray[1] = new int[2] { 11, 12 };
//jaggedArray[2] = new int[3] { 13, 15, 14 };

//foreach(var jagged in jaggedArray)
//{
//    foreach (var item in jagged)
//    {
//        Console.Write($"{item} ");
//    }
//    Console.WriteLine();
//}

//int[] ints = { 12, 123, 12, 3, 124, 235, 345, 2134, 78, 8678, 4, 234, 23, 435, 74, 634, 542 };
//Array.Sort(ints);
////Array.Reverse(ints);
//foreach (var item in ints)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//var result = Array.BinarySearch(ints, 4);
//Console.WriteLine(result);

//Random random = new Random();
//Console.WriteLine(random.Next(-123, 123));

#endregion


#region String

//string str = "110111hakuna10111";
//var trim = str.Trim('1', '0', ' ');
//Console.WriteLine(trim );
//Console.WriteLine(str);

//string str = "hakuna";
//str = str.Insert(str.Length, "matata");

//Console.WriteLine(str);

//string s = "";
//string s1 = string.Empty;
//string s2 = null;
//string s3 = " ";

//Console.WriteLine(string.IsNullOrEmpty(s));  // true
//Console.WriteLine(string.IsNullOrEmpty(s1)); // true
//Console.WriteLine(string.IsNullOrEmpty(s2)); // true
//Console.WriteLine(string.IsNullOrEmpty(s3)); // false

//Console.WriteLine(string.IsNullOrWhiteSpace(s));  // true
//Console.WriteLine(string.IsNullOrWhiteSpace(s1)); // true
//Console.WriteLine(string.IsNullOrWhiteSpace(s2)); // true
//Console.WriteLine(string.IsNullOrWhiteSpace(s3)); // true

#endregion


#region Nullable

//int? i = null;
//void foo(string str)
//{
//    Console.WriteLine(str.EndsWith("com"));
//}

//string s = "gmail.com";
//string? str = null;
//foo(s);

#endregion