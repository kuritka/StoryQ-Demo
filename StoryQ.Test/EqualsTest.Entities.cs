namespace StoryQ.Test
{
    partial class EqualsTest 
    {
        public class Person
        {
            private readonly string _personName;

            public Person(string name)
            {
                _personName = name;
            }

            public override string ToString()
            {
                return _personName;
            }
        }



        public struct SPerson
        {
            private readonly string _personName;

            public SPerson(string name)
            {
                _personName = name;
            }

            public override string ToString()
            {
                return _personName;
            }
        }

    }
}
