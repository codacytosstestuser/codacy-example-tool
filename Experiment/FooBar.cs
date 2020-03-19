
namespace Experiment
{
    public class FooBar
    {
        public class InnerClass
        {
            public bool RunInnerClass(string input)
            {
                switch (input)
                {
                    case "Foo":
                        return false;
                    case "Bar":
                        return false;
                    case "FooBar":
                        return true;
                    default:
                        return false;
                }
            }
        }
    }
}