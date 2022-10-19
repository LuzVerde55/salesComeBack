namespace SalesCome.Infrastructure.Services.Cache
{
    public interface ICacheService
    {
        public void Insert(string key, object obj);

        public T Get<T>(string key);

        public bool Exist(string key);

        public void Remove(string key);
    }
}
