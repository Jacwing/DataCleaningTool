using System;

namespace SimpleIoCContainer.Exceptions
{
    public class TypeRepositoryEmptyException : Exception
    {
        public TypeRepositoryEmptyException()
            : base("Repository of types is empty!")
        {
        }
    }
}
