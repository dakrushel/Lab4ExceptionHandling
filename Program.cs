using System.Threading.Channels;

namespace ExceptionHandlingActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiating circles without radius
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Circle circle3 = new Circle();

            //Trying to set radii for circles
            try
            {
                circle1.SetRadius(1);
                circle2.SetRadius(-1);
                circle3.SetRadius(0);
            }
            //Throwing exception for circle2
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
