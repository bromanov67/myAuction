namespace auction
{
    /// <summary>
    /// Bet (contain info)
    /// </summary>
    public class Bet
    {
        public int Id { get; init; }
        public int AuthorId { get; init; }
        public int LotId { get; init; }

        /// <summary>
        /// Размер ставки
        /// </summary>
        public int Amount { get; init; }
        public DateTime DateTime { get; init; }

    }
}
