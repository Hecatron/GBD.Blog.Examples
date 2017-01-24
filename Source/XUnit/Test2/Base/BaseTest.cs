using System;
using Serilog;
using Test2.Logging;
using Xunit.Abstractions;

namespace Test2.Base {
    /// <summary> Used as a Base class for testing. </summary>
    public class BaseTest : IDisposable {

        protected readonly ILog Logger;
        //protected readonly ITestOutputHelper output;
        //protected readonly IDisposable _logCapture;
        protected bool SerilogSetup;

        /// <summary> Constructor. </summary>
        /// <param name="outputHelper"> The output helper from XUnit. </param>
        public BaseTest(ITestOutputHelper outputHelper) {
            // Get a hold of the XUnit output
            //  output = outputHelper;
            // Connects Serilog to the XUnit Output
            //  _logCapture = LoggingHelper.Capture(outputHelper);


            // Currently there's problem with preivew2 tooling for Visual Studio 2015 and .Net Core
            // when it comes to capturing output for Tests in the Visual Studio Test Explorer
            // The only way around this currently is to output text to the Console
            // and see it via "dotnet test" at the command line
            if (SerilogSetup == false) {
                // Add [{SourceContext}] to the output so we know which class it is
                var outtemplate =
                "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}";
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.LiterateConsole(outputTemplate: outtemplate)
                    .CreateLogger();
                SerilogSetup = true;
            }

            // Store a reference for LibLog
            // Because this is a base class avoid GetCurrentClassLogger and use GetType().ToString()
            Logger = LogProvider.GetLogger(GetType().ToString());
        }

        /// <summary> Cleanup the LoggingHelper. </summary>
        public void Dispose() {
            //_logCapture.Dispose();
        }
    }
}
