using System;

namespace SimpleIoCContainer.Exceptions
{
    public class NotAssignableException : Exception
    {
        public NotAssignableException()
            : base("Ouptut type is not assignable from source type!")
        {
        }
    }
}
