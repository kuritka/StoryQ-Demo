using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace StoryQ.Test.Framework
{
    public static class StoryQHelper
    {
      
        public static string Uncamel(string methodName)
        {
            return Regex.Replace(methodName, "[A-Z_]", x => " " + x.Value.ToLowerInvariant()).Trim();
        }

        public static string ConvertTestMethodAsScenario()
        {
            var methodName = GetTestMethodName();
            return methodName == null ? "Nonamed scenario!" : Uncamel(methodName);
        }


        private static string GetTestMethodName()
        {
            var method = GetTestMethod();
            return method == null ? null : method.Name;
        }

        private static MethodBase GetTestMethod()
        {
            var trace = new StackTrace();
            for (var i = 0; i < trace.FrameCount; i++)
            {
                var methodBase = trace.GetFrame(i).GetMethod();
                var isTestMethod = methodBase.GetCustomAttributes(true).Any(
                    attribute =>
                    {
                        var name = attribute.GetType().Name;
                        return name == "TestAttribute" || name == "TestMethodAttribute";
                    });

                if (isTestMethod) return methodBase;
            }
            return null;
        }
    }
}
