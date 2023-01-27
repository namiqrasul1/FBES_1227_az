using Lesson14;
using System.Text;
// Stream
// FileStream
// MemoryStream
// NetworkStream

// AdapterStream
// StreamWriter StreamReader
// BinaryWriter BinaryReader

// File, FileInfo
// Directory, DirectoryInfo
// Path

#region Stream Write And Read

// way 1

//var data = "Hakuna Matata 42";
//FileStream fs = new("text.txt", FileMode.Append, FileAccess.Write);

//var bytes = Encoding.Default.GetBytes(data);

//fs.Write(bytes);
////fs.Flush();
//fs.Close();
//fs.Dispose();

// way 2
//var data = "Hakuna Matata 42";
//using (FileStream fs = new("text.txt", FileMode.Append, FileAccess.Write))
//{
//    var bytes = Encoding.Default.GetBytes(data);
//    fs.Write(bytes);
//}

//var data = "Hakuna Matata 42";
//using FileStream fs = new("text.txt", FileMode.Append, FileAccess.Write);
//var bytes = Encoding.Default.GetBytes(data);
//fs.Write(bytes);

//using var fs = new FileStream("text.txt", FileMode.Open);
//var buffer = new byte[fs.Length];
//fs.Read(buffer, 0, buffer.Length);

//var data = Encoding.Default.GetString(buffer);
//Console.WriteLine(data);


#endregion

#region StreamWriter
//List<Book> books = new()
//{
//    new(){ Id = 1, Name = "Sefiller", Author = "Victor Hugo", Genre = "Drama" },
//    new(){ Id = 2, Name = "1984", Author = "Goerge Orweel", Genre = "Drama" },
//    new() { Id = 3, Name = "Angels and Demons", Author = "Dan Brown", Genre = "Dedective" }
//};


//using FileStream fs = new("books.txt", FileMode.Append);
////using StreamWriter sw = new("books.txt", true);
//using StreamWriter sw = new(fs);
//books.ForEach(book => sw.WriteLine(book));

#endregion

#region StreamReader

//using StreamReader sr = new(@"C:\Users\namiqrasullu\Desktop\books.txt");

//while (!sr.EndOfStream)
//{
//    var data = sr.ReadLine();
//    var props = data?.Split('$');
//    Console.WriteLine(data);
//}

#endregion


//List<Book> books = new()
//{
//    new(){ Id = 1, Name = "Sefiller", Author = "Victor Hugo", Genre = "Drama" },
//    new(){ Id = 2, Name = "1984", Author = "Goerge Orweel", Genre = "Drama" },
//    new() { Id = 3, Name = "Angels and Demons", Author = "Dan Brown", Genre = "Dedective" }
//};

//File.AppendAllText("books.txt", books[0].ToString());
//var datas = File.ReadAllText("books.txt");
//Console.WriteLine(datas);


#region CopyFile

//using (FileStream source = new FileStream(@"C:\Users\namiqrasullu\Downloads\source.jpg", FileMode.Open, FileAccess.Read))
//{
//    using (FileStream dest = new FileStream(@"C:\Users\namiqrasullu\Desktop\copy.jpg", FileMode.Create, FileAccess.Write))
//    {
//        //source.CopyTo(dest); // easy version
//        //var len = 10;
//        //var fileSize = source.Length;
//        //byte[] buffer = new byte[len];

//        //do
//        //{
//        //    len = source.Read(buffer, 0, buffer.Length); // 8
//        //    dest.Write(buffer, 0, len);
//        //    Console.WriteLine(fileSize);
//        //    fileSize -= len;
//        //    Thread.Sleep(300);
//        //} while (len != 0);
//    }
//}

using (FileStream source = new FileStream(@"C:\Users\namiqrasullu\Downloads\source.jpg", FileMode.Open, FileAccess.Read))
{
    using (FileStream dest = new FileStream(@"C:\Users\namiqrasullu\Desktop\copy.jpg", FileMode.Create, FileAccess.Write))
    {
        if (source.CanRead && dest.CanWrite)
        {
            var bytes = new byte[200];
            while(source.Read(bytes,0, bytes.Length) > 0)
            {
                dest.Write(bytes, 0, bytes.Length);
            }
        }
    }
}



#endregion