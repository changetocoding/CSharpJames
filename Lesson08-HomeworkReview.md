# Homework Checkout
See https://github.com/changetocoding/CSharpJames/blob/main/Assignment04-Checkout.md



# Class code
```cs
using System;

namespace ConsoleApp44
{
    class Program
    {

        static void Main(string[] args)
        {

            //            Console.WriteLine("Hello World!");
            //
            //            var ne = new Counter();
            //            var toChange = "nnn";
            //            ne.TryGet("test", ref toChange);
            //
            //            Type t = ne.GetType();
            //            Type t2 = typeof(Counter);
            //
            //            if (t is Counter)
            //            {
            //                // do something
            //            }
            var test = new TestClass();
            test.RunTest();

            var child = new Child();
        }

        public string GetAgeAndName(ref int no, ref Counter counter, out int age)
        {
            age = 10;
            var name = "";
            return name;
        }
    }


    public class TestClass
    {
        private string a = "Unchanged";

        private void TestMethod(string b)
        {
            var newString = "Changed in TestMethod";
            b = newString;
            Console.WriteLine(b);
        }

        public void RunTest()
        {
            TestMethod(a);
            Console.WriteLine(a);
        }
    }


    class Counter
    {
        private static int _count;
        public Counter()
        {
            _count++;
        }

        public int GetCount()
        {
            return _count;
        }

        public bool TryGet(string key, ref string val)
        {
            val = "test";
            return true;
        }
    }

    // static class - can't initialise. But can inherit (by another static class)
    static class MyStatic {
        // static field - shared info between all instances
        // or data for static methods
        private static string _myString = "Trimed: ";

        // Method - Extension
        // Global Method
        public static string MyExtension(this string it)
        {
            return _myString + it.ToLowerInvariant().Trim();
        }

        public static string MyTrimIt(string it)
        {
            return _myString + it.ToLowerInvariant().Trim();
        }
    }

     // sealed - cannot be inherited
    sealed class MyClass
    {
        private readonly string _name = "Test";
        const string _cname = "Test";
        static readonly string _srname = "Test";

        public MyClass(string name)
        {
            _name = name; // Allowed as readonly. But not allowed to set in method below
            _cname = "ttt"; // Not allowed to set as const
            _srname = "ttt"; // Not allowed to set as static readonly
        }

        public void MethodName()
        {
            _name = "Not allowed";

            throw new Exception("test");
        }
    }

    // Not allowed to construct abstract class
    internal abstract class MyAbsClass
    {
        private string _age = "10";

        // Can have abstract method. It must be overriding by subclasses
        public abstract void MethodName();

        // can have implementation on abstract class. Useful for putting common functionality
        public void OtherMethod()
        {
            
        }
    }

    class Child : MyAbsClass
    {
        // overriding (parent)
        public override void MethodName()
        {
            throw new NotImplementedException();
        }

        // overloading (Same method name, different params)
        public void Overloading(string param1)
        {

        }

        public void Overloading(string param1, string param2)
        {
        }

        // Virtual method means can be overriden by child classes
        public virtual void VirtualMethod()
        {
            
        }
    }
}

```
