using Strings;

Compression c1 = new Compression();
Exam e1 = new Exam();

Console.WriteLine("Enter the string :");
Console.WriteLine();

string s = Console.ReadLine();

//Console.WriteLine(c1.CompressionType_1(s));
//Console.WriteLine(c1.CompressionType_2(s));
Console.WriteLine(e1.Codility1(s));