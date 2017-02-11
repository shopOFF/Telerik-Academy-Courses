/* globals module */

"use strict";

function solve() {
    class Product {
        constructor(productType, name, price) {
            this.productType = productType;
            this.name = name;
            this.price = price;
        }

        get productType() {
            return this._productType;
        }
        set productType(productType) {
            if (typeof productType !== 'string') {
                throw new Error('ProductType should be a string!');
            }
            if (productType === '') {
                throw new Error('ProductType should not be empty!');
            }

            this._productType = productType;
        }

        get name() {
            return this._name;
        }
        set name(name) {
            if (typeof name !== 'string') {
                throw new Error('Name should be a string!');
            }
            if (name === '') {
                throw new Error('Name should not be empty!');
            }

            this._name = name;
        }

        get price() {
            return this._price;
        }
        set price(price) {
            if (typeof price !== 'number') {
                throw new Error('Price should be a number!');
            }
            if (price < 0) {
                throw new Error('Price should be grater than 0!');
            }

            this._price = price;
        }
    }

    class ShoppingCart {
        constructor() {
            this.products = [];
        }

        add(product) {
            if (product.length === 0) {
                throw new Error('No products are added');
            }

            this.products.push(product);

            return this;
        }

        remove(product) {
            if (product.length === 0) {
                throw new Error('No products in ShoppingCart');
            }

             for (let i = 0; i < this.products.length; i += 1) {
                if (this.products[i].name === product.name &&
                    this.products[i].price === product.price &&
                    this.products[i].productType === product.productType) {

                    this.products.splice(i, 1);
                    return;
                }
            }

            throw 'product not founded';
        }

        showCost() {
            let sum = 0;
            for (let i = 0; i < this.products.length; i += 1) {
                sum += this.products[i].price;
            }

            return sum;
        }

        showProductTypes() {
            let uniqueTypes = {};

            for (let i = 0; i < this.products.length; i += 1) {
                uniqueTypes[this.products[i].productType] = true;
            }

            return Object.keys(uniqueTypes).sort(function(a, b) {
                if (a < b) return -1;
                if (a > b) return 1;
                return 0;
            });
        }

       getInfo() {
            let info = {};

            info.totalPrice = this.showCost();

            info.products = [];

            let names = {};

            for (let i = 0; i < this.products.length; i += 1) {
                if (!names[this.products[i].name]) {
                    names[this.products[i].name] = {};
                    names[this.products[i].name].price = 0;
                    names[this.products[i].name].quantity = 0;
                }

                names[this.products[i].name].price += this.products[i].price;
                names[this.products[i].name].quantity += 1;
            }

            let props = Object.keys(names);

            for (let i = 0; i < props.length; i += 1) {
                info.products.push({
                    name: props[i],
                    totalPrice: names[props[i]].price,
                    quantity: names[props[i]].quantity
                });
            }

            return info;
        }

    }
    return {
        Product, ShoppingCart
    };
}

module.exports = solve;