using System.Collections.Generic;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Linq;

namespace Sugar
{
    public static partial class DynamicCompile
    {
        public static readonly string CodePrefix = "namespace DynamicNameSpace { public static class DynamicClass { ";
        public static readonly string CodePostfix = " } }";
        public static readonly string DynamicMainExample = "public static object DynamicMain() { return \"Hello, world!\"; }";

        /// <summary>
        /// Check assemblies for important assemblies
        /// </summary>
        /// <param name="assemblies"></param>
        /// <returns></returns>
        private static List<string> checkAssemblies(List<string> assemblies)
        {
            if (assemblies == null)
                assemblies = new List<string>();

            List<string> result = assemblies.Select(x => x).Distinct().ToList();
            string[] importantDlls = new string[] { "System.dll" };

            foreach (var dll in importantDlls)
                if (!result.Contains(dll))
                    result.Add(dll);

            return result;
        }

        /// <summary>
        /// Value of compiled code in DynamicNameSpace, DynamicClass. Method DynamicMain is important!
        /// </summary>
        /// <param name="code"></param>
        /// <param name="assemblies"></param>
        /// <returns></returns>
        public static string Compile(string code, List<string> assemblies)
        {
            //CompilerParameters parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, "foo.exe", true);
            CompilerParameters parameters = new CompilerParameters() { GenerateInMemory = true };
            assemblies = checkAssemblies(assemblies);

            foreach (var assembly in assemblies)
                parameters.ReferencedAssemblies.Add(assembly);
            
            return new CSharpCodeProvider()
                .CompileAssemblyFromSource(parameters, new string[] { CodePrefix + code + CodePostfix })
                .CompiledAssembly
                .GetType("DynamicNameSpace.DynamicClass")
                .GetMethod("DynamicMain", BindingFlags.Static | BindingFlags.Public)
                .Invoke(null, null)
                .ToString();
        }

        /// <summary>
        /// Value of compiled code using System.dll in DynamicNameSpace, DynamicClass. Method DynamicMain is important!
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string Compile(string code)
        {
            return Compile(code, new List<string>());
        }

    }
}
