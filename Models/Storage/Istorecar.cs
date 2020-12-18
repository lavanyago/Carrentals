using System;
using System.Collections.Generic;

using carrentals.Models.Engine;

namespace carrentals.Models.Storage
{
    public interface Istorecar
    {
         void createCar (Hakucar newcar);
        Hakucar getbyIDCar (Guid ID, Guid userid);
        void updateCar (Hakucar updatedCar);
        List <Hakucar> GetALLcar(Guid userid);
        void deletecar (Hakucar carid, Guid userid);
    }
}