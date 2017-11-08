using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace DesignPatternLib.CSharpPracticalPattern.Factory
{
    public class Assembler
    {
        public static IConfigurationRoot Configuration { get; set; }
        private const string SectionName = "CustomFactories";
        private const string FactoryTypeName = "IFactory";
        private static Dictionary<Type, Type> dict = new Dictionary<Type, Type>();
        static Assembler()
        {
            var builder = new ConfigurationBuilder()
                     .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            
            var section = Configuration.GetSection(SectionName);
            var keyValues = section.GetChildren().First().AsEnumerable();
            foreach(var kv in keyValues)
            {
                var source = kv.Key.Split(':')[1];
                var target= kv.Value;
                dict.Add(Type.GetType(source), Type.GetType(target));
            }
        }
        public object Create(Type type)
        {
            if(type is null || !dict.ContainsKey(type))
            {
                throw new NullReferenceException();
            } 
            Type targetType = dict[type];
            return Activator.CreateInstance(targetType);
        }
        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }
    }
}