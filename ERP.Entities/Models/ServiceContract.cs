﻿namespace ERP.Entities.Models;

public class ServiceContract : IEntity
{
    #region Private Key

    public int ServiceContractId { get; set; }

    #endregion

    #region Columns

    public bool IsSıgned { get; set; }

    #endregion

    #region Foreign Keys

    #endregion
}