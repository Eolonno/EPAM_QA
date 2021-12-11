using System.IO;
using Serilog;

namespace PocketOptions.Tests.Utils
{
    public static class Log
    {
        static Log()
        {
            File.Delete("PocketOptionsTests.log");
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File("PocketOptionsTests.log",
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

        }
        public static void Info(string message)
        {
            Serilog.Log.Information(message);
        }
    }
}