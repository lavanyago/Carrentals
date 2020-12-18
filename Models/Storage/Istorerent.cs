using System;
using System.Collections.Generic;

using carrentals.Models.Engine;

namespace carrentals.Models.Storage
{
    public interface Istorerent
    {
      void createR (Rent newrent);
      Rent getbyCarId (Guid carid, Guid userId);
      void updateR (Rent updatedrent);
      List <Rent> GetALL(Guid userId);

    }
}