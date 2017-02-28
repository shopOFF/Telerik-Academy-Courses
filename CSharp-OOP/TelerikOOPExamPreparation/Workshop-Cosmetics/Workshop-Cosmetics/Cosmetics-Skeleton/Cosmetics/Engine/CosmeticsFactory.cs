﻿namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;
    using Cart;
	
    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            return new Category(name);
        }

        public IShampoo  CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            // TODO: create shampoo
            return new Shampoo(name, brand, price, gender, milliliters, usage);
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            // TODO: create toothpaste
            return new Toothpaste(name, brand, price, gender, string.Join(", ",ingredients));
        }

        public IShoppingCart ShoppingCart()
        {
            // TODO: create shopping cart
            return new ShoppingCart();
        }
    }
}