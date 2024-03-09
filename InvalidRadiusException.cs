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

        //Not sure why the exception message had to be here but it didn't work using the example from class
        public InvalidRadiusException(int radius): base($"Exception thrown. Radius of value: {radius} is not greater than zero.")
        {
            
        }
    }
}
