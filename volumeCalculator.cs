using System;

namespace volumeCalculator {
    class Program {
        static void Main (string[] args) {

            /*This program is meant to find the volume of 5 different solid shapes or containers
            By using the standard formulas for each of them*/

            string[] shapes = new string[5] { "cylinder", "cone", "sphere", "cuboid", "cube" };

            decimal pie = 3.14m;
            decimal radius = 0;
            decimal height = 0;
            decimal length = 0;
            decimal width = 0;
            decimal volume = 0;
            decimal oneThird = 0.33m;
            decimal fourThird = 1.33m;

            Console.WriteLine ("[{0}]", string.Join (" ", shapes));
            Console.Write ("what is the shape of your container: ");
            string userResponse = Console.ReadLine ();

            
            // volume of cylinder = pie(3.14) * radius * radius * height
            if (userResponse == shapes[0]) {
                Console.Write ("what is the radius of the cylinder: ");
                radius = decimal.Parse (Console.ReadLine ());

                Console.Write ("what is the height of the cylinder: ");
                height = decimal.Parse (Console.ReadLine ());

                volume = pie * radius * radius * height;
                Console.Write ("The volume of the cylinder is: " + volume);

            }
            
            //volume of cone = 1/3 * pie(3.14) * radius * radius * height
            else if (userResponse == shapes[1]) {
                Console.Write ("what is the radius of the cone: ");
                radius = decimal.Parse (Console.ReadLine ());

                Console.Write ("what is the height of the cone: ");
                height = decimal.Parse (Console.ReadLine ());

                volume = oneThird * pie * radius * radius * height;
                Console.Write ("The volume of the cone is: " + volume);
            }

            //volume of sphere = 4/3 * pie(3.14) * radius * radius * radius
            else if (userResponse == shapes[2]) {
                Console.Write ("what is the radius of the sphere: ");
                radius = decimal.Parse (Console.ReadLine ());

                volume = fourThird * pie * radius * radius * radius;
                Console.Write ("The volume of the sphere is: " + volume);

            }

            //volume Of cuboid = length * width * height
            else if (userResponse == shapes[3]) {
                Console.Write ("what is the length of the cuboid: ");
                length = decimal.Parse (Console.ReadLine ());

                Console.Write ("what is the width of the cuboid: ");
                width = decimal.Parse (Console.ReadLine ());

                Console.Write ("what is the height of the cuboid: ");
                height = decimal.Parse (Console.ReadLine ());

                volume = length * width * height;
                Console.Write ("The volume of the cuboid is: " + volume);

            }

            //volume of cube = length * lenght * length
            else if (userResponse == shapes[4]) {
                Console.Write ("what is the length of the cube: ");
                length = decimal.Parse (Console.ReadLine ());

                volume = length * length * length;
                Console.Write ("The volume of the cube is: " + volume);

            }

        }
    }
}