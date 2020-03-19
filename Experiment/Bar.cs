using System;

namespace Experiment
{
    public class Bar
    {
        public bool RunBar(bool shouldPrint)
        {
            if (shouldPrint)
            {
                Console.WriteLine("Bar ran");
            }

            return true;
        }
    }
}