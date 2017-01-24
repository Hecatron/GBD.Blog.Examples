using System;
using Test1.Logging;
using Xunit.Abstractions;

namespace Test1.Base {
    /// <summary> Used as a Base class for testing. </summary>
    public class BaseTest : IDisposable {

        protected readonly ILog Logger;
        protected readonly ITestOutputHelper output;
        protected readonly IDisposable _logCapture;

        /// <summary> Constructor. </summary>
        /// <param name="outputHelper"> The output helper from XUnit. </param>
        public BaseTest(ITestOutputHelper outputHelper) {
            // Get a hold of the XUnit output
            output = outputHelper;
            // Connects Serilog to the XUnit Output
            _logCapture = LoggingHelper.Capture(outputHelper);
            // Store a reference for LibLog
            // Because this is a base class avoid GetCurrentClassLogger and use GetType().ToString()
            Logger = LogProvider.GetLogger(GetType().ToString());
        }

        /// <summary> Cleanup the LoggingHelper. </summary>
        public void Dispose() {
            _logCapture.Dispose();
        }
    }
}
