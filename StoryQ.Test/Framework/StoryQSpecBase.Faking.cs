using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;

namespace StoryQ.Test.Framework
{
    partial class StoryQSpecBase
    {

        /// <summary>
        /// Create a mock
        /// </summary>
        /// <typeparam name="T">Type to be mocked</typeparam>
        /// <param name="argumentsForConstructor">Constructor arguments</param>
        /// <returns>TMessage</returns>
        protected virtual T Fake<T>(params object[] argumentsForConstructor) where T : class
        {
            return A.Fake<T>(b => b.WithArgumentsForConstructor(argumentsForConstructor));
        }

        protected virtual T Fake<T>()
        {
            return A.Fake<T>();
        }
        
    }
}
