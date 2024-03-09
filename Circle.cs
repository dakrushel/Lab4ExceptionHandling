using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingActivity
{
    public class Circle
    {
        private int Radius;
    
        public void SetRadius (int radius)
        {
            //if radius > 0, set Radius
            if (radius > 0)
            {
                Radius = radius;
            }
            //else if radius <= 0, throw exception InvalidRadiusException
            else if (radius <=0)
            {
                throw new InvalidRadiusException(radius);
            }
        }
        public int GetRadius ()
        {
            return Radius;
        }

        public string CircleToString ()
        {
            return $"{Radius}";
        }
    }
}
