using Assets.Model;

namespace Transactions.Model
{
    public class Investment
    {
        public Investment(Asset asset, decimal value)
        {
            Asset = asset;
            Value = value;
        }

        public Asset Asset { get; }

        public decimal Value { get; }
    }
}