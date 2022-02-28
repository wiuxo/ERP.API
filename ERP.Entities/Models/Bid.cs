namespace ERP.Entities.Models;

public class Bid : IEntity
{
    #region Private Key

    public int BidId { get; set; }

    #endregion

    #region Columns

    public double Price { get; set; }

    #endregion

    #region Foreign Keys

    public int BuyOrderId { get; set; }

    #endregion

    public BuyOrder BuyOrder { get; set; }
}