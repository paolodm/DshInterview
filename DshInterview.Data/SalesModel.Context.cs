﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;
using DshInterview.Domain;


namespace DshInterview.Data
{
    public partial class SalesEntities : ObjectContext
    {
        public const string ConnectionString = "name=SalesEntities";
        public const string ContainerName = "SalesEntities";
    
        #region Constructors
    
        public SalesEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            this.CommandTimeout = 240;
        }
    
        public SalesEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            this.CommandTimeout = 240;
        }
    
        public SalesEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            this.CommandTimeout = 240;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Customer> Customers
        {
            get { return _customers  ?? (_customers = CreateObjectSet<Customer>("Customers")); }
        }
        private ObjectSet<Customer> _customers;
    
        public ObjectSet<Product> Products
        {
            get { return _products  ?? (_products = CreateObjectSet<Product>("Products")); }
        }
        private ObjectSet<Product> _products;
    
        public ObjectSet<Sale> Sales
        {
            get { return _sales  ?? (_sales = CreateObjectSet<Sale>("Sales")); }
        }
        private ObjectSet<Sale> _sales;
    
        public ObjectSet<SoldProduct> SoldProducts
        {
            get { return _soldProducts  ?? (_soldProducts = CreateObjectSet<SoldProduct>("SoldProducts")); }
        }
        private ObjectSet<SoldProduct> _soldProducts;

        #endregion
    }
}