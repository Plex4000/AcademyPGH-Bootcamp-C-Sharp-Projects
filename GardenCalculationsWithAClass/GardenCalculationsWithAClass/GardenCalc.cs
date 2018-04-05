using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenCalculationsWithAClass
{
   public class GardenCalc
    {
        public int Length;
        public int Height;
        public int Area;

        public GardenCalc(int length, int height)
        {
            Length = length;
            Height = height;
        }

        public int GetArea()
        {
            Area = Length * Height;
            return Area;
        }

        public int GetPerimeter()
        {
            int perimeter = 2 * Length + 2 * Height;
            return perimeter;
        }

        public double GetNumOfCarrots()
        {
            return Math.Ceiling((Area / 16.0) * 16);
        }

        public double GetNumOfCorn()
        {
            return Math.Ceiling((Area / 16.0) * 3);
        }

        public double GetNumOfBeets()
        {
            return Math.Ceiling((Area / 16.0) * 9);
        }
    }
}
