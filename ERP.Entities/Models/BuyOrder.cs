namespace ERP.Entities.Models;

public class BuyOrder : IEntity
{
    #region Private Key

    public int OrderId { get; set; }

    #endregion

    #region Columns

    #endregion

    #region Foreign Keys

    public int SupplyTermsContractId { get; set; }

    #endregion


    public SupplyTermsContract SupplyTermsContract { get; set; }
}