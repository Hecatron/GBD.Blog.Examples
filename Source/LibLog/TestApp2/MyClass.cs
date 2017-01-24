using TestApp2.Logging;

namespace TestApp2 {
    public class MyClass {
        private static readonly ILog Logger = LogProvider.For<MyClass>();

        public void DoSomething() {
            Logger.Trace("Method 'DoSomething' in progress");
        }
    }
}