namespace BankApp.IServices
{
    public interface ISerializer<T>
    {
        void Serialize(T obj, string path);
        T? Deserialize(string path);
    }
}