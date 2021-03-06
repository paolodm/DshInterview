//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DshInterview.Domain
{
    public partial class SoldProduct
    {
        #region Primitive Properties
    
        public virtual int SoldProductID
        {
            get;
            set;
        }
    
        public virtual int SaleID
        {
            get { return _saleID; }
            set
            {
                if (_saleID != value)
                {
                    if (Sale != null && Sale.SaleID != value)
                    {
                        Sale = null;
                    }
                    _saleID = value;
                }
            }
        }
        private int _saleID;
    
        public virtual int ProductID
        {
            get { return _productID; }
            set
            {
                if (_productID != value)
                {
                    if (Product != null && Product.ProductID != value)
                    {
                        Product = null;
                    }
                    _productID = value;
                }
            }
        }
        private int _productID;
    
        public virtual decimal NumberOfUnits
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Sale Sale
        {
            get { return _sale; }
            set
            {
                if (!ReferenceEquals(_sale, value))
                {
                    var previousValue = _sale;
                    _sale = value;
                    FixupSale(previousValue);
                }
            }
        }
        private Sale _sale;
    
        public virtual Product Product
        {
            get { return _product; }
            set
            {
                if (!ReferenceEquals(_product, value))
                {
                    var previousValue = _product;
                    _product = value;
                    FixupProduct(previousValue);
                }
            }
        }
        private Product _product;

        #endregion
        #region Association Fixup
    
        private void FixupSale(Sale previousValue)
        {
            if (previousValue != null && previousValue.SoldProducts.Contains(this))
            {
                previousValue.SoldProducts.Remove(this);
            }
    
            if (Sale != null)
            {
                if (!Sale.SoldProducts.Contains(this))
                {
                    Sale.SoldProducts.Add(this);
                }
                if (SaleID != Sale.SaleID)
                {
                    SaleID = Sale.SaleID;
                }
            }
        }
    
        private void FixupProduct(Product previousValue)
        {
            if (previousValue != null && previousValue.SoldProducts.Contains(this))
            {
                previousValue.SoldProducts.Remove(this);
            }
    
            if (Product != null)
            {
                if (!Product.SoldProducts.Contains(this))
                {
                    Product.SoldProducts.Add(this);
                }
                if (ProductID != Product.ProductID)
                {
                    ProductID = Product.ProductID;
                }
            }
        }

        #endregion
    }
}
