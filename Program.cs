namespace MillerInc.PhysicsEngine.TestingEnv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckArgs(args);
        }

        static void CheckArgs(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }
            else
            {
                switch (args[0])
                {
                    case "test":
                        Test.TestMethod();
                        break;
                    default:
                        if (args.Length > 1)
                        {
                            switch (args[1])
                            {
                                case "new":
                                    Test.TestMethod();
                                    break;
                                default:
                                    Console.WriteLine("Invalid command line argument.");
                                    break;
                            }
                        }
                        Console.WriteLine("Invalid command line argument.");
                        break;
                }
            }
        }
    }

    public class Test
    {
        public static void TestMethod()
        {
            // Create a new instance of the PhysicsObject
            PhysicsObject obj = new();
            // Create another instance of the PhysicsObject
            PhysicsObject obj2 = new();

            // Simulate the collision between obj and obj2
            //obj.Collide(obj2);

            // Print the results of the collision
            //Console.WriteLine(obj.CollisionResult);
        }
    }
}
