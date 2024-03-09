using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingActivity
{
    public class InvalidRadiusException : Exception
    {
        //No arg ctor
        public InvalidRadiusException()
        {

        }

        //
        public InvalidRadiusException(int radius): base($"Exception thrown. Radius of value: {radius} is not greater than zero.")
        {
            
        }
    }
}
