namespace Task1;

public class Cache<T>
{
    List<T> values = new List<T>();
    
    public void Add(T sl)
    {
        values.Add(sl);
    }
    public List<T> Get()
    {
        return values;
    }

    public void Remove(T a)
    {
        values.Remove(a);
    }

}
