namespace MoviesAPI_Git.DTO
{
    public class TokenDTO
    {
        public Guid Id { get; }
        public DateTime ExpirationTime { get; set; }

        public TokenDTO()
        {
            Id = Guid.NewGuid();
        }

    }
}
