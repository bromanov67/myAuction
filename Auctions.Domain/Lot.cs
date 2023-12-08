using FluentResults;

namespace auction
{
    /// <summary>
    /// Lot
    /// </summary>
    public class Lot
    {
        public int Id { get; init; }
        public int AuctionId { get; init; }
        public int Name { get; init; }
        public string COde { get; init; } 
        public string Description { get; init; }
        public LotStatus Status { get; init; }

        private List<Bet> _bets = new List<Bet>();

        /// <summary>
        /// Lot images
        /// </summary>
        public IReadOnlyCollection<string> Images { get; init; } = new List<string>();


        /// <summary>
        /// Попытка сделать ставку
        /// </summary>
        /// <param name="bet"></param>
        /// <returns> Результат выполнения операции</returns>
        public Result TryDoBet(Bet bet)
        {
            if (Status != LotStatus.Bidding)
            {
                return Result.Fail("Невозожно сделать ставку, торги завершены");
            }
            if (_bets.Any(b => b.Amount >= bet.Amount))
            {
                return Result.Fail("Ваша ставка была перекрыта");
            }
            _bets.Add(bet);
            return Result.Ok();
        }

    }
}
