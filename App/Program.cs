using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyModel;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var assemblies = GetReferencingAssemblies("DesignPatternLib").Where(x=>x.FullName.StartsWith("DesignPatternLib")).FirstOrDefault();
            if(assemblies != null)
            {
                var dictTypes = new Dictionary<int,Type>();
                var typesCount = assemblies.ExportedTypes.Count();
                for(var i = 0; i < typesCount; i++)
                {
                    dictTypes.Add(i, assemblies.ExportedTypes.ElementAt(i));
                    Console.WriteLine($"{i},{assemblies.ExportedTypes.ElementAt(i)}");
                }
                Console.WriteLine("Please input type index you want to run:");
                var typeIndex = Console.ReadLine();
                var index = -1;
                while(string.IsNullOrEmpty(typeIndex) || !int.TryParse(typeIndex, out index) || index >= typesCount || index < 0)
                {
                    Console.WriteLine("Input error! Please reinput:");
                    typeIndex = Console.ReadLine();
                }
                var curInsance = Activator.CreateInstance(dictTypes[index]);
                Console.WriteLine("Please input method params:");
                var param = Console.ReadLine().Split(' ');
                curInsance.GetType().GetMethod("Test", BindingFlags.Public | BindingFlags.Static).Invoke(null,new object[] { param });
            }
        
        
        }
        public static IEnumerable<Assembly> GetReferencingAssemblies(string assemblyName)
        {
            var assemblies = new List<Assembly>();
            var dependencies = DependencyContext.Default.RuntimeLibraries;
            foreach (var library in dependencies)
            {
                if (IsCandidateLibrary(library, assemblyName))
                {
                    var assembly = Assembly.Load(new AssemblyName(library.Name));
                    assemblies.Add(assembly);
                }
            }
            return assemblies;
        }

        private static bool IsCandidateLibrary(RuntimeLibrary library, string assemblyName)
        {
            return library.Name == (assemblyName)
                || library.Dependencies.Any(d => d.Name.StartsWith(assemblyName));
        }
    }
}
