namespace EntryService.Repositories.Models.Cache
{
    public class RedisCache : ICache
    {
        public void InsertAsync<T>(string key, T value, TimeSpan? expiration = null)
        {
            throw new NotImplementedException();
        }

        public T GetAsync<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveAsync(string key)
        {
            throw new NotImplementedException();
        }

        public void ClearAsync()
        {
            throw new NotImplementedException();
        }

        public bool ContainsKeyAsync(string key)
        {
            throw new NotImplementedException();
        }
    }
}
