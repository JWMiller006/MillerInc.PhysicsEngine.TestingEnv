using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MillerInc.PhysicsEngine.TestingEnv.Backend
{
    public class TestCases
    {
        public static void RunTest(TestType testType)
        {
            switch (testType)
            {
                case TestType.NewObject:
                    TestNewObject();
                    break;
                case TestType.Collision:
                    TestCollision();
                    break;
                case TestType.Force:
                    TestForce();
                    break;
                case TestType.Torque:
                    TestTorque();
                    break;
                case TestType.Impulse:
                    TestImpulse();
                    break;
                case TestType.AngularImpulse:
                    TestAngularImpulse();
                    break;
                case TestType.HLoD:
                    TestHLoD();
                    break;
                case TestType.Serialization:
                    TestSerialization();
                    break;
                default:
                    break;
            }
        }

        private static void TestNewObject()
        {
            Console.WriteLine("Enter the position of the object");
            Vector3 object1Position = GetVectorFromUser();
            Console.WriteLine("Enter the rotation of the object");
            Vector3 object1Rotation = GetVectorFromUser();
            Console.WriteLine("Enter the velocity of the object");
            Vector3 object1Velocity = GetVectorFromUser();
            Console.WriteLine("Enter the acceleration of the object");
            Vector3 object1Acceleration = GetVectorFromUser();
            Console.WriteLine("Enter the mass of the object");
            string? temp = Console.ReadLine();
            temp ??= "1";
            if (temp == "")
            {
                temp = "1";
            }
            float object1Mass = float.Parse(temp);
            PhysicsObject obj = new()
            {
                Velocity = object1Velocity,
                Acceleration = object1Acceleration,
                Position = object1Position,
                Rotation = new Quaternion(object1Rotation.X, object1Rotation.Y, object1Rotation.Z, 0),
                Mass = object1Mass

            };
            PhysicsObject obj2 = new();

        }

        private static void TestCollision()
        {
            PhysicsObject obj = new();
            PhysicsObject obj2 = new();
            obj.Collide(obj2);
        }

        private static void TestForce()
        {
            PhysicsObject obj = new();
            //obj.AddForce(new Vector3(1, 1, 1));
        }

        private static void TestTorque()
        {
            PhysicsObject obj = new();
            //obj.AddTorque(new Vector3(1, 1, 1));
        }

        private static void TestImpulse()
        {
            PhysicsObject obj = new();
            PhysicsObject obj2 = new();
            obj.Collide(obj2);
            //obj.ApplyImpulse(obj.CollisionResult.Impulse);
        }

        private static void TestAngularImpulse()
        {
            PhysicsObject obj = new();
            PhysicsObject obj2 = new();
            obj.Collide(obj2);
            //obj.ApplyAngularImpulse(obj.CollisionResult.Impulse);
        }

        private static void TestHLoD()
        {
            PhysicsObject obj = new HLoD.HLoDObject();
            //obj.HLoD = true;
        }

        private static void TestSerialization()
        {
            PhysicsObject obj = new();
            obj.Serialize("test.json");
            PhysicsObject obj2 = new("test.json");
        }

        public static Vector3 GetVectorFromUser()
        {
            Console.WriteLine("Enter a vector in the form x,y,z");
            string? input = Console.ReadLine();
            input ??= "0,0,0";
            string[] split = input.Split(',');
            try
            {
                return new Vector3(float.Parse(split[0]), float.Parse(split[1]), float.Parse(split[2]));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine("Invalid input. Defaulting to 0,0,0");

            }
            return new Vector3(0, 0, 0);
        }
    }

    public enum TestType
    {
        NewObject,
        Collision,
        Force,
        Torque,
        Impulse,
        AngularImpulse,
        HLoD, 
        Serialization
    }
}
