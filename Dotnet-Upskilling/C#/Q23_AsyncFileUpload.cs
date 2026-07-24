using System;
using System.Threading.Tasks;

class Program
{
    // Async method
    static async Task<string> UploadFileAsync()
    {
        // Simulate 3-second upload
        await Task.Delay(3000);

        return "File Uploaded Successfully";
    }

    static async Task Main()
    {
        try
        {
            Console.WriteLine("Uploading File...");

            string result = await UploadFileAsync();

            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
