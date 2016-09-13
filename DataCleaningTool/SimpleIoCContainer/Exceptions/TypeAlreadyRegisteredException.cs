using System;

namespace SimpleIoCContainer.Exceptions
{
    public class TypeAlreadyRegisteredException : Exception
    {
        public TypeAlreadyRegisteredException()
            : base("Type already registered!")
        {
        }
    }
}
