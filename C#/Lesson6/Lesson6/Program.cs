////List<int> ints = new() { 1,213,12,312,3,123,12,3};
////ints.Add(1);
//////for (int i = 0; i < ints.Count; i++)
//////{
//////    Console.WriteLine(ints[i]);
//////}
//////foreach (var i in ints)
//////{
//////    Console.WriteLine(i);
//////}

////double foo(int x) => 1 / x;

////int.TryParse(Console.ReadLine(), out int d);
////try
////{
////    var result = foo(d);
////    Console.WriteLine(result);
////}
////catch (DivideByZeroException ex)
////{
////    Console.WriteLine(ex.Message); // log file
////    throw;
////}


////double foo(int x) => 1 / x;

////void boo(int x)
////{
////	try
////	{
////		Console.WriteLine(foo(x));
////	}
////	catch (Exception ex)
////	{
////		Console.WriteLine(ex.Message);
////		throw;
////	}
////}

////try
////{
////    boo(0);
////}
////catch (Exception)
////{

////}


////int? foo(int? a)
////{
////    //throw new NotImplementedException();
////    if (a is null)
////        //throw new ArgumentNullException(nameof(a));
////        throw new ArgumentOutOfRangeException(nameof(a), "value xoshuma gelmedi");   
////    return a;
////}

////try
////{
////    foo(null);
////}
////catch (Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}


/////////////////////////////////////////////////////////////

/////
//var data = new string[] { "hakuna", "matata", "400" };

////try
////{
////    byte b = byte.Parse(data[2]);
////    Console.WriteLine(b);
////}
////catch (FormatException ex)
////{
////    Console.WriteLine(ex.Message);
////}
////catch (IndexOutOfRangeException ex)
////{
////    Console.WriteLine(ex.Message);
////}
////catch (OverflowException ex)
////{
////    Console.WriteLine(ex.Message);
////}
////catch (Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}


//// empty catch
////try
////{
////    var s = data[6];
////}
////catch
////{
////    Console.WriteLine("nese pis shey oldu");
////}


////try
////{
////	try
////	{
////		try
////		{

////		}
////		catch (Exception)
////		{
////			try
////			{

////			}
////			catch (Exception)
////			{

////				throw;
////			}
////			throw;
////		}
////	}
////	catch (Exception)
////	{

////		throw;
////	}
////}
////catch (Exception)
////{

////	throw;
////}

////try
////{
////	throw new InvalidDataException();
////	Console.WriteLine("try");
////}
////catch (Exception)
////{
////	Console.WriteLine("catch");
////}
////finally
////{
////	Console.WriteLine("finally");
////}

////////////////////////////////////////////
//// exception filtering

//int GetInt(int[] arr, int index)
//{
//    try
//    {
//        return arr[index];
//    }
//    catch (Exception) when (index < 0)
//    {
//        throw new ArgumentOutOfRangeException(paramName: null, message: "indeks menfi olammaz!!!");
//    }
//    catch (Exception) when (arr.Length < index)
//    {
//        throw new ArgumentOutOfRangeException(null, "indeks massivin olchusunden kichik olmalidir!!");
//    }
//}

//try
//{
//    Console.WriteLine(GetInt(new int[] { 0, 1, 24, 312, 5, 56, 6, 36, 3, 423, 4 }, -555));
//}
//catch (Exception ex) when(ex.Message.Length < 20)
//{
//    Console.WriteLine(ex.Message);
//}
