/* MIT License

Copyright (c) 2019 Mark Bromell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Easing
{
    using System;

    public partial class Ease
    {
        private const float MIN = 0.0f;
        private const float MAX = 1.0f;
        private const float PI = (float)Math.PI;

        private static void ScaleParameters(ref float y, ref float deltaX, float yScale, float xScale)
        {
            y /= yScale;
            deltaX /= xScale;
        }

        private static float CoordinatesWithinRange(float newY, float x)
        {
            if (x <= MIN || newY <= MIN)
            {
                return MIN;
            }
            else if (x >= MAX || newY >= MAX)
            {
                return MAX;
            }
            else
            {
                return newY;
            }
        }

        private static float Sin(float value)
        {
            return (float)Math.Sin(value);
        }

        private static float Asin(float value)
        {
            return (float)Math.Asin(value);
        }

        private static float Sqrt(float value)
        {
            return (float)Math.Sqrt(value);
        }

        private static float Pow(float value, float exponent)
        {
            return (float)Math.Pow(Math.Abs(value), exponent);
        }
    }
}
