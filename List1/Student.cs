using System;

namespace List1
{
    public class Student
    {
        private string _name;
        private string _lastName;

        public Student(string name, string lastName)
        {
            _lastName = lastName;
            _name = name;
        }

        public string GetFulName()
        {
            return $"{_lastName} {_name }";

        }

    }
}
