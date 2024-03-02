namespace stack
{
    public interface IImplementationStack<T>
    {
        bool IsEmpty();
        T Pop();
        void Push(T element);
    }
}
