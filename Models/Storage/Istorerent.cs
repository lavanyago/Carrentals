using System;
using System.Collections.Generic;

using carrentals.Models.Engine;

namespace carrentals.Models.Storage
{
    public interface Istorerent
    {
      void createC (Customer newcust);
      Customer getbyIDC (Guid ID, Guid userId);
      void updateC (Customer updatedCust);
      List <Customer> GetALL(Guid userId);

    }
}