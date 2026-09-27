


Thread thread_download = new Thread(() => 
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Downloading file...");
        Thread.Sleep(250);
    }
});


Thread checking_data = new Thread(() => 
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Checking data...");
        Thread.Sleep(500); 
    }
});


thread_download.Start();
checking_data.Start();
thread_download.Join();
checking_data.Join();

Console.WriteLine("All operations completed.");