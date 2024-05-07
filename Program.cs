namespace MillerInc.PhysicsEngine.TestingEnv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string? input = Console.ReadLine();
            input = input ?? "No input was given.";
            Console.WriteLine(input);
            Test.TestMethod();
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
