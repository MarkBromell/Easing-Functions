﻿/* MIT License

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
    public class Linear : Ease
    {
        public override float In(float y, float deltaX, float yScale = 1, float xScale = 1)
        {
            NormailzePoints(ref y, ref deltaX, yScale, xScale);

            float x = InInverse(y) + deltaX;
            float newY = x;

            return CoordinatesWithinRange(newY, x);
        }

        public override float InInverse(float y)
        {
            float x = y;
            return x;
        }

        public override float Out(float y, float deltaX, float yScale = 1, float xScale = 1)
        {
            NormailzePoints(ref y, ref deltaX, yScale, xScale);

            float x = OutInverse(y) + deltaX;
            float newY = x;

            return CoordinatesWithinRange(newY, x);
        }

        public override float OutInverse(float y)
        {
            float x = y;
            return x;
        }

        public override float InOut(float y, float deltaX, float yScale = 1, float xScale = 1)
        {
            NormailzePoints(ref y, ref deltaX, yScale, xScale);

            float x = InOutInverse(y) + deltaX;
            float newY = x;

            return CoordinatesWithinRange(newY, x);
        }

        public override float InOutInverse(float y)
        {
            float x = y;
            return x;
        }
    }
}
