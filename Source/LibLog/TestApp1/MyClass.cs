using TestApp1.Logging;

namespace TestApp1 {
    public class MyClass {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public void DoSomething() {
            Logger.Trace("Method 'DoSomething' in progress");
        }
    }
}