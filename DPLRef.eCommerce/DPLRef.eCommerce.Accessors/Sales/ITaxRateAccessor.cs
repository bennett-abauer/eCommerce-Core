using DPLRef.eCommerce.Common.Contracts;
using DPLRef.eCommerce.Common.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPLRef.eCommerce.Accessors.Sales
{
    public interface ITaxRateAccessor : IServiceContractBase
    {
        decimal Rate(Address address);
    }
}
