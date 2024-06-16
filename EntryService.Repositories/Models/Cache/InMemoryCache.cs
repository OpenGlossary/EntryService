namespace EntryService.Repositories.Models.Cache
{
    public class InMemoryCache : ICache
    {
        public void InsertAsync(string key, T value, TimeSpan? expiration = null)
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
