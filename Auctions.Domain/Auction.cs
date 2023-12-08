using System.Text;

namespace auction
{
    /// <summary>
    /// Auction (contatin info)
    /// </summary>
    public class Auction
    {
        public int Id { get; init; }
        public int Name { get; init; }
        public int AuthorId { get; init; }
        public DateTime DateStart { get; init; }
        public bool IsCreation { get; init; }

        private readonly DateTime _dateEnd;
        public DateTime DateEnd
        {
            get
            {
                // Автопродление акциона после ставки (+30 секунд)
                var maxBetDate = Lots.Values.SelectMany(l => l.Bets).Max(s => s.DateTime).AddSeconds(30);

                return _dateEnd > maxBetDate ? _dateEnd : maxBetDate;
            }
            init => _dateEnd = value;

        }
        /// <summary>
        /// Auction status
        /// </summary>
        public AuctionStatus Status
        {
            get
            {
                if (IsCreation)
                    return AuctionStatus.Creation;

                if (DateTime.UtcNow > DateStart)
                    return AuctionStatus.WaitBidding;

                if (DateTime.UtcNow > DateStart && DateTime.UtcNow < DateEnd)
                    return AuctionStatus.Bidding;

                if (DateTime.UtcNow > DateEnd)
                    return AuctionStatus.Complete;
                else
                    return AuctionStatus.Unknown;
                
            }
        }
        public Dictionary<int, Lot> Lots { get; init; } = new();

    }
}
