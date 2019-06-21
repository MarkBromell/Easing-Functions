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
    public class Cubic : Ease
    {
        public Cubic() : base() { }

        public Cubic(Point origin, Point destination) : base(origin, destination) { }

        public override float In(float x)
        {
            if (x > Destination.X)
            {
                return ValueWhenAboveRange();
            }
            else if (x < Origin.X)
            {
                return ValueWhenUnderRange();
            }

            float normalisedX = NormaliseInput(x);
            float y = Pow(normalisedX, 3);
            y = DenormaliseOutput(y);

			return y;
        }

        public override float Out(float x)
        {
            if (x > Destination.X)
            {
                return ValueWhenAboveRange();
            }
            else if (x < Origin.X)
            {
                return ValueWhenUnderRange();
            }

            float normalisedX = NormaliseInput(x);
            float y = 1 + Pow(normalisedX - 1, 3);
            y = DenormaliseOutput(y);

			return y;
        }

        public override float InOut(float x)
        {
            if (x > Destination.X)
            {
                return ValueWhenAboveRange();
            }
            else if (x < Origin.X)
            {
                return ValueWhenUnderRange();
            }

            float normalisedX = NormaliseInput(x);
            float y = 0.5f;

            if (x < 0.5)
            {
                y = 4 * Pow(normalisedX, 3);
            }
            else if (x > 0.5)
            {
                y = 1 + 4 * Pow(normalisedX - 1, 3);
            }

            y = DenormaliseOutput(y);

			return y;
        }

        public override float InInverse(float y)
        {
            if (y > Destination.Y)
			{
				return InverseValueWhenAboveRange();
			}
			else if (y < Origin.Y)
			{
				return InverseValueWhenUnderRange();
			}

            float normalisedY = NormaliseInput(y);
            float x = Pow(normalisedY, 1.0f / 3.0f);
            x = DenormaliseOutput(x);

			return x;
        }

        public override float OutInverse(float y)
        {
            if (y > Destination.Y)
			{
				return InverseValueWhenAboveRange();
			}
			else if (y < Origin.Y)
			{
				return InverseValueWhenUnderRange();
			}

            float normalisedY = NormaliseInput(y);
            float x = 1 - Pow(1 - normalisedY, 1.0f / 3.0f);
            x = DenormaliseOutput(x);

			return x;
        }

        public override float InOutInverse(float y)
        {
            if (y > Destination.Y)
			{
				return InverseValueWhenAboveRange();
			}
			else if (y < Origin.Y)
			{
				return InverseValueWhenUnderRange();
			}

            float normalisedY = NormaliseInput(y);
            float x = 0.5f;

            if (y < 0.5)
            {
                x = Pow(normalisedY / 4, 1.0f / 3.0f);
            }
            else if (y > 0.5)
            {
                x = 1 - Pow((1 - normalisedY) / 4.0f, 1.0f / 3.0f);
            }

            x = DenormaliseOutput(x);

			return x;
        }
    }
}
