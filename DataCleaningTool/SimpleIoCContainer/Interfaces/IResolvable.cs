namespace SimpleIoCContainer.Interfaces
{
    public interface IResolvable
    {
        T Resolve<T>();
    }
}
