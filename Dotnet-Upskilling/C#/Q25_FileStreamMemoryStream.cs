using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Write sample file
        File.WriteAllText("sample.txt", "Hello C#");

        // Read file using FileStream
        using (FileStream fs =
               new FileStream("sample.txt",
               FileMode.Open,
               FileAccess.Read))
        {
            byte[] data = new byte[fs.Length];

            fs.Read(data, 0, data.Length);

            string content =
                Encoding.UTF8.GetString(data);

            Console.WriteLine(content);
        }

        // MemoryStream
        using (MemoryStream ms = new MemoryStream())
        {
            byte[] bytes =
                Encoding.UTF8.GetBytes("Memory Data");

            ms.Write(bytes, 0, bytes.Length);

            Console.WriteLine(
                "Bytes Written: " + ms.Length);
        }
    }
}
