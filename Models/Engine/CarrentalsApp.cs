using System;
using System.Collections.Generic;
using System.Linq;
using F23.StringSimilarity;
using carrentals.Models.Storage;

namespace carrentals.Models.Engine
{
    public class CarrentalsApp
    {
        public CarrentalsApp(IStorecar cartorage, IStorecustomers customertorage, IStorerent rentStorage) 
        {
            _carStorage = cartorage;
            _customerStorage = customertorage;
            _rentStorage = rentStorage;
        }


             private readonly _carStorage = cartorage;
             private readonly _customerStorage = customertorage;
              private readonly _rentStorage = rentStorage;
    }
}
