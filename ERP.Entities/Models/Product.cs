namespace ERP.Entities.Models;

public class Product : IEntity
{
    #region Private Key

    public int ProductId { get; set; }

    #endregion

    #region Columns

    public string ProductName { get; set; }

    #endregion

    #region Foreign Keys

    #endregion
}