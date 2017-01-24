using System;
using Serilog;
using TestApp2.Logging;

namespace TestApp2 {
    public class Program {
        public static void Main(string[] args) {
            // Setup Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.LiterateConsole()
                .CreateLogger();


            // Create some example data to log
            var position = new {Latitude = 25, Longitude = 134};
            var elapsedMs = 34;

            // Log directly via Serilog
            Log.Logger.Verbose("Serilog: Test Verbose Message... {@Position} .. {Elapsed:000}", position, elapsedMs);
            Log.Logger.Information("Serilog: Test Info Message...");
            Log.Logger.Debug("Serilog: Test Debug Message...");
            Log.Logger.Warning("Serilog: Test Warning Message...");
            Log.Logger.Error("Serilog: Test Error Message...");
            Log.Logger.Fatal("Serilog: Test Fatal Message...");


            // Example of Logging within a Class
            var myClass = new MyClass();
            myClass.DoSomething();

            // Use LibLog as a proxy to log to Serilog
            var LibLogger = LogProvider.For<Program>();

            // Log via LibLog instead for abstraction / support of other logging frameworks
            LibLogger.Trace("Liblog: Test Trace Message...");
            LibLogger.Info("Liblog: Test Info Message...");
            LibLogger.Debug("Liblog: Test Debug Message...");
            LibLogger.Warn("Liblog: Test Warning Message...");
            LibLogger.Error("Liblog: Test Error Message...");
            LibLogger.Fatal("Liblog: Test Fatal Message...");

            // For Serilog type fields
            LibLogger.InfoFormat("Liblog {MethodName} Entry", nameof(Program));
            LibLogger.TraceFormat("Liblog: Test Verbose Message... {@Position} .. {Elapsed:000}", position, elapsedMs);

            Console.ReadKey();
        }
    }
}