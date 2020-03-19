using Xunit;
using Experiment;

namespace Tests
{
    public class FooBarTests
    {
        [Fact]
        public void TestFoo()
        {
            var foo = new Foo();
            
            foo.RunFoo();
        }

        [Fact]
        public void TestBar()
        {
            var bar = new Bar();

            Assert.True(bar.RunBar(false));
        }
        
        [Fact]
        public void TestFooBar()
        {
            var innerClass = new FooBar.InnerClass();

            Assert.True(innerClass.RunInnerClass("FooBar"));
            Assert.False(innerClass.RunInnerClass("Foo"));
        }
    }
}
