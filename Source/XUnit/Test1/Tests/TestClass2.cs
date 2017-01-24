using Test1.Base;
using Test1.Logging;
using Xunit;
using Xunit.Abstractions;

namespace Test1.Tests {
    /// <summary> Example of a test Class. </summary>
    public class TestClass2 : BaseTest {

        /// <summary> Constructor. </summary>
        /// <param name="outputHelper"> The output helper used by XUnit. </param>
        public TestClass2(ITestOutputHelper outputHelper) : base(outputHelper) {
            // We Capture the Output injected by XUnit for Outputting to Visual Studio
            // and pass it to the Base Class to setup the Logger property for use with LibLog
        }

        /// <summary> Example Test. </summary>
        [Fact]
        public void TestLog2() {
            // Example of throwing out some log entries for Visual Studio to pick up on in the output

            // This uses LibLog which is independent of the Logging framework
            // Typically this would be used in the library we're testing
            Logger.Warn("LibLog Warning Test2");

            // Use serilog's structured data output via liblog
            Logger.WarnFormat("Structured {data} message", "some data");

            // Example of writing directly to Serilog which normally shouldn't be needed
            Serilog.Log.Logger.Warning("Serilog Warning Test2");

            // Example of checking to see if something is true for a given test
            Assert.True(true);
        }
    }
}