using System;
using System.Collections.Generic;
using System.Linq;
using SimpleIoCContainer.Exceptions;
using SimpleIoCContainer.Interfaces;

namespace SimpleIoCContainer
{
    internal class DefaultResolvable : IResolvable
    {
        internal IDictionary<Type, Type> TypeContainer { get; set; }

        public T Resolve<T>()
        {
            if (this.TypeContainer == null)
            {
                throw new TypeRepositoryEmptyException();
            }

            var desiredType = typeof(T);
            var outputPair = this.TypeContainer.FirstOrDefault(pair => pair.Key == desiredType);
            if (outputPair.Key == null || outputPair.Value == null)
            {
                throw new CannotResolveTypeException();
            }

            var outputType = outputPair.Value;
            if (!desiredType.IsAssignableFrom(outputType))
            {
                throw new CannotResolveTypeException();
            }

            // tworzymy instancje klasy
            return (T)Activator.CreateInstance(outputType);
        }
    }
}
