using System.Text;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
System.Console.InputEncoding = Encoding.GetEncoding(1251);

Console.WriteLine("Введите Ваше имя");
string? username = Console.ReadLine();
Console.WriteLine("Привет,");
Console.WriteLine(username);