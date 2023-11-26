namespace DataBases
{
    public class Exchange
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CryptoTokenId { get; set; }

        public virtual CryptoToken CryptoToken { get; set; }
    }
}
