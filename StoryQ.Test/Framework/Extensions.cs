using System.Diagnostics;
using System.Reflection;


namespace StoryQ.Test.Framework
{
    public static class Extensions
    {
        /// <summary>
        /// Executes the tests.
        /// </summary>
        public static void Run(this Outcome outcome)
        {
            var st = new StackTrace();
            MethodBase currentMethod = st.GetFrame(1).GetMethod();
            outcome.ExecuteWithReport(currentMethod);
        }
    }
}
