using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerInc.PhysicsEngine.TestingEnv.Backend
{
    internal class TestCases
    {
        internal static void RunTest(TestType testType)
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
            PhysicsObject obj = new();
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
    }

    internal enum TestType
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
