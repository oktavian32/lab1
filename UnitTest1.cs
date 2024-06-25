using Microsoft.VisualStudio.TestPlatform.TestHost;
using lab1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello, World by Kolesnyk Anton FI-23!", lab1.Program.Func());
        }
    }
}