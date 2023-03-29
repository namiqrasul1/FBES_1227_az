//using System.Security.Cryptography;
//using System.Text;

//namespace SOLID;

//static class Hasher
//{
//    public static string GetHash(string content)
//    {
//        using SHA256 sha256 = SHA256.Create();
//        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(content));
//        StringBuilder stringBuilder = new();
//        for (int i = 0; i < bytes.Length; i++)
//            stringBuilder.Append(bytes[i].ToString("x2"));
//        return stringBuilder.ToString();
//    }
//}

//static class EmailService
//{
//    public static bool IsEmailValid(string email)
//    {
//        // amazing code
//        return !string.IsNullOrWhiteSpace(email);
//    }

//    public static void SendEmail(string from, string to, string message, string? caption = null)
//    {
//        if(IsEmailValid(from) && IsEmailValid(to))
//        {
//            // amazing code
//        }
//        throw new Exception("email is not valid");
//    }
//}

//class MainViewModel
//{
//    public void SendMailCommand(string from, string to, string message, string? caption = null) => EmailService.SendEmail(from, to, message, caption);

//    public bool LoginCommand(string username, string password)
//    {
//        // amazing code
        
//        var passwordHash = Hasher.GetHash(password);

//        // check
//        return true;
//    }


//}
//internal class Program
//{
//    private static void Main(string[] args)
//    {

//    }
//}