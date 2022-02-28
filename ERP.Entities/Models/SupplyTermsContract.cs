namespace ERP.Entities.Models;

public class SupplyTermsContract : IEntity
{
    #region Private Key

    public int SupplyTermsContractId { get; set; }

    #endregion

    #region Columns

    public bool IsSigned { get; set; }

    #endregion

    #region Foreign Keys

    public int BuyOrderId { get; set; }

    #endregion

    public BuyOrder BuyOrder { get; set; }
}