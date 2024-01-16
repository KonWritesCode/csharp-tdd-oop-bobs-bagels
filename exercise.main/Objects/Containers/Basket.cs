﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Core;

namespace exercise.main.Objects.Containers
{
    public class Basket : PObject
    {
        List<Ware> _contentsInBasket = new List<Ware>();
        private static int _basketSizeLimit = 50;

        public static int BasketSizeMax { get => _basketSizeLimit; }
        public int BasketSize { get => _contentsInBasket.Capacity; }

        public List<Ware> ContentsInBasket { get => _contentsInBasket; }

        public bool AddProduct(Product bagel)
        {
            throw new NotImplementedException();
        }

        public double GetPriceTotal()
        {
            throw new NotImplementedException();
        }

        public bool RemoveProduct(Product bagel)
        {
            throw new NotImplementedException();
        }

        protected internal bool AlterSize(int newSize)
        {
            throw new NotImplementedException();
        }
    }
}
