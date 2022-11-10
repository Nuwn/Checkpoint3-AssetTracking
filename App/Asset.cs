using static Checkpoint3_AssetTracking.App.Office;

namespace Checkpoint3_AssetTracking.App
{
    public sealed class Asset
    {
        public Computer Technology { get; set; }
        public OfficeType Office { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }

        public Asset(){}

        public Asset(Computer technology, OfficeType office, DateTime purchaseDate, decimal price, string? currency = null)
        {
            Technology = technology;
            Office = office;
            PurchaseDate = purchaseDate;
            Price = price;

            // if currency is not null, we set based on location
            Currency = currency ?? GetCurrency(office)!;
        }

        
    }
}
