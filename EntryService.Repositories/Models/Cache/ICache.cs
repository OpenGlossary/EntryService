namespace EntryService.Repositories.Models.Cache
{
    public interface ICache
    {
        /// <summary>
        /// Inserts data into the cache, with an optional expiration time
        /// </summary>
        void InsertAsync<T>(string key, T value, TimeSpan? expiration = null);
        
        T GetAsync<T>(string key);

        /// <summary>
        /// Removes a key-value pair from cache if present or does nothing if not
        /// </summary>
        void RemoveAsync(string key);

        /// <summary>
        /// Wipes the cache completely, unsure if ever needed
        /// </summary>
        void ClearAsync();
        
        /// <summary>
        /// Checks the cache for a given key without returning the value
        /// </summary>
        bool ContainsKeyAsync(string key);
    }
}
