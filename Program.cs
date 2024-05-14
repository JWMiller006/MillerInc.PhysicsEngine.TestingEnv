using MillerInc.PhysicsEngine.TestingEnv.Backend;
using MillerInc.PhysicsEngine.DisplayToolkit; 

namespace MillerInc.PhysicsEngine.TestingEnv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? temp; 
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a command");
                temp = Console.ReadLine();

                while (temp == null)
                {
                    Console.WriteLine("Please enter a command");
                    temp = Console.ReadLine();
                }

                args = temp.Split(' ');
            }


            if (CheckArgs(args))
            {
                Main([]);
            }

        }

        static bool CheckArgs(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No commands given");
                return true;
            }
            else
            {
                switch (args[0])
                {
                    case "test":
                        args = args[1..];
                        args = Test.TestMethod(args);
                        break;
                    case "??":
                        return true;
                    case "":
                        Console.WriteLine("Invalid command line argument.");
                        return true;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        return false;
                    case "help":
                        Console.WriteLine("Help is not yet finished");
                        break;
                    default:
                        Console.WriteLine("Invalid command line argument.");
                        break;
                }
                if (args.Length >= 1)
                {
                    args = args[1..];
                    CheckArgs(args);
                }
                return true; 
            }
        }
    }

    public class Test
    {
        public static string[] TestMethod(string[] args)
        {
            string? testType = ""; 
            if (args.Length < 1)
            {
                Console.WriteLine("What type of test"); 
                testType = Console.ReadLine();
            }
            else
            {
                testType = args[0];
                args = args[1..];
            }

            // Create a new instance of the PhysicsObject
            PhysicsObject obj = new();
            // Create another instance of the PhysicsObject
            PhysicsObject obj2 = new();

            // Simulate the collision between obj and obj2
            //obj.Collide(obj2);

            // Print the results of the collision
            //Console.WriteLine(obj.CollisionResult);
            switch (testType)
            {
                case "gpu":
                    GPUAccelerator.TestGPU();
                    Console.ReadLine(); 
                    break;
                case "object-test":
                    TestCases.RunTest(TestType.NewObject);
                    break;
                case "exit":
                    return args;
                case "clear":
                    Console.Clear();
                    break;
                case "help":
                    Console.WriteLine("Help is not yet finished");
                    break;
                default:
                    Console.WriteLine("Invalid test type");
                    break;
            }
            if (testType != "exit")
            {
                args = TestMethod(args);
                return args;
            }
            else
            {
                Console.WriteLine("Exiting test...");
                return args;
            }
        }
    }
}
