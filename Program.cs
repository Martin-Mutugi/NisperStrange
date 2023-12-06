// See https://aka.ms/new-console-template for more information
namespace boxVolume;
public class Box{
    double width ;
    double height;
    double length;


    public class boxdemo{
        public static void Main(string[] args)
        {
            Box bi=new Box();
            Box b2=new Box();
            double volume=0.0;

            // specializing with box one

            bi.width=3.0;
            bi.height=6.0;
            bi.length=9.0;

            // specializing with box two
            b2.width=5.0;
            b2.height=10.0;
            b2.length=15.0;

            //volume for box one
            volume=bi.width*bi.height*bi.length;
            Console.WriteLine("")
        }
    }
}
