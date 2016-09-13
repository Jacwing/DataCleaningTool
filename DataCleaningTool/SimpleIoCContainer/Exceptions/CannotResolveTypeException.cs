using System;

namespace SimpleIoCContainer.Exceptions
{
    public class CannotResolveTypeException : Exception
    {
        public CannotResolveTypeException()
            : base("Cannot resolve desired type!")
        {
        }
    }
}
