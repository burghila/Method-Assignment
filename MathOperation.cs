using System;

namespace MainMethodAssignment
{
    class MathOperation1
    {
        // Creates a method that takes two integers as parameters
        // The second parameter is optional and has a default value of 1
        public int MathOperation(int i, int j = 1)
        {
            // Performs multiplication on integers and return the result
            int result = i * j;
            return result;
        }
    }
}
