using System;
using System.Runtime.CompilerServices;

namespace Franksoft.Research.All_About_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringA = "Hello World!";
            Console.WriteLine(stringA);
            Console.WriteLine(stringA.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(stringA));
            Console.WriteLine();

            string stringB = String.Format("{0} {1}!", "Hello", "World");
            Console.WriteLine(stringB);
            Console.WriteLine(stringB.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(stringB));
            Console.WriteLine();

            int integerA = 10086;
            Console.WriteLine(integerA);
            Console.WriteLine(integerA.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(integerA));
            Console.WriteLine();

            byte byteA = 255;
            Console.WriteLine(byteA);
            Console.WriteLine(byteA.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(byteA));
            Console.WriteLine();

            short shortA = 10086;
            Console.WriteLine(shortA);
            Console.WriteLine(shortA.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(shortA));
            Console.WriteLine();

            long longA = 10086;
            Console.WriteLine(longA);
            Console.WriteLine(longA.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(longA));
            Console.WriteLine();

            double doubleA = 10086D;
            Console.WriteLine(doubleA);
            Console.WriteLine(doubleA.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(doubleA));
            Console.WriteLine();

            NestedClassA nestedClassA1 = new NestedClassA();
            Console.WriteLine(nestedClassA1);
            Console.WriteLine(nestedClassA1.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedClassA1));
            Console.WriteLine();

            NestedClassA nestedClassA2 = new NestedClassA();
            Console.WriteLine(nestedClassA2);
            Console.WriteLine(nestedClassA2.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedClassA2));
            Console.WriteLine();

            NestedClassA nestedClassA3 = new NestedClassA();
            Console.WriteLine(nestedClassA3);
            Console.WriteLine(nestedClassA3.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedClassA3));
            Console.WriteLine();

            NestedClassB nestedClassB1 = new NestedClassB();
            Console.WriteLine(nestedClassB1);
            Console.WriteLine(nestedClassB1.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedClassB1));
            Console.WriteLine();

            NestedClassB nestedClassB2 = new NestedClassB();
            Console.WriteLine(nestedClassB2);
            Console.WriteLine(nestedClassB2.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedClassB2));
            Console.WriteLine();

            NestedClassB nestedClassB3 = new NestedClassB();
            Console.WriteLine(nestedClassB3);
            Console.WriteLine(nestedClassB3.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedClassB3));
            Console.WriteLine();

            NestedStructA nestedStructA1 = new NestedStructA(1, 0);
            Console.WriteLine(nestedStructA1);
            Console.WriteLine(nestedStructA1.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedStructA1));
            Console.WriteLine();

            NestedStructA nestedStructA2 = new NestedStructA(0, 1);
            Console.WriteLine(nestedStructA2);
            Console.WriteLine(nestedStructA2.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedStructA2));
            Console.WriteLine();

            NestedStructB nestedStructB1 = new NestedStructB(1, 0);
            Console.WriteLine(nestedStructB1);
            Console.WriteLine(nestedStructB1.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedStructB1));
            Console.WriteLine();

            NestedStructB nestedStructB2 = new NestedStructB(0, 1);
            Console.WriteLine(nestedStructB2);
            Console.WriteLine(nestedStructB2.GetHashCode());
            Console.WriteLine(RuntimeHelpers.GetHashCode(nestedStructB2));
            Console.WriteLine();

            Console.ReadKey();
        }

        private class NestedClassA
        {
        }

        private class NestedClassB
        {
        }

        private struct NestedStructA
        {
            public int field1;
            public int field2;

            public NestedStructA(int field1, int field2)
            {
                this.field1 = field1;
                this.field2 = field2;
            }
        }

        private struct NestedStructB
        {
            public int field1;
            public int field2;

            public NestedStructB(int field1, int field2)
            {
                this.field1 = field1;
                this.field2 = field2;
            }
        }
    }
}
