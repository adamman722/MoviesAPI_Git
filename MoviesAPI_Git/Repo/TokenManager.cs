using MoviesAPI_Git.DTO;

namespace MoviesAPI_Git.Repo
{
    public static class TokenManager
    {
        private static Dictionary<Guid, TokenDTO> _items = new Dictionary<Guid, TokenDTO>();

        public static void AddItem(TokenDTO item, TimeSpan expirationDuration)
        {
            item.ExpirationTime = DateTime.UtcNow + expirationDuration;
            _items[item.Id] = item;
        }

        public static void RemoveExpiredItems()
        {
            var now = DateTime.UtcNow;
            var expiredItems = _items.Where(kv => kv.Value.ExpirationTime <= now).ToList();
            foreach (var kvp in expiredItems)
            {
                _items.Remove(kvp.Key);
            }
        }
        public static Dictionary<Guid, TokenDTO> GetTokens() { return _items; }

        public static bool ValidUser(Guid token)
        {
            RemoveExpiredItems();
     return( _items.ContainsKey(token));
        }
    }
}
