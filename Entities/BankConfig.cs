using BankApp.Entities;

namespace bankapp.Entities
{
    public class BankConfig : BaseEntity
    {
        public BankConfig(int id): base(id)
        {
            
        }
        public string BankName { get; set; } = "Batch29Bank";
        public string Country { get; set; } = "Nigeria";
        public string BaseCurrency { get; set; } = "NGN";
        public int AccountNumberLength { get; set; } = 10;
        public decimal TransferFeeFlat { get; set; } = 10m; // NGN 10 flat
        public decimal ExternalTransferFeeFlat { get; set; } = 25m; // NGN 25 flat
    }
}