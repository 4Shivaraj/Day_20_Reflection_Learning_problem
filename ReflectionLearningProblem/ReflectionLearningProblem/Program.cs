using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLearningProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Reflection Learning Problem");
            string assemblypath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_9\NewAddressBook\AddressBookProblem\AddressBookProblem\bin\Debug\net6.0\AddressBookProblem.dll";
            ReflectionFactory.TestAssemblyUsingReflection(assemblypath);
            Console.ReadLine();
        }
        public class ReflectionFactory
        {
            public static void TestAssemblyUsingReflection(string assemblypath)
            {
                Assembly assembly = Assembly.LoadFrom(assemblypath);
                Type[] types = assembly.GetTypes();
                if (assembly != null)
                {
                    foreach (Type type in types)
                    {
                        Console.WriteLine(type.FullName);
                    }
                }
            }
        }
    }
}

