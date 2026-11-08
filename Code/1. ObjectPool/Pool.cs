namespace ObjectPool.Interface;

public interface IPool<T>
{
    public T Rent();
    public void Return(T item);
}