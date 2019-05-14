//------------------------------------------------------------------------------
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

namespace AWModel
{
    public partial class AWEntities : ObjectContext
    {
        public const string ConnectionString = "name=AWEntities";
        public const string ContainerName = "AWEntities";
    
        #region Constructors
    
        public AWEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public AWEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public AWEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Address> Addresses
        {
            get { return _addresses  ?? (_addresses = CreateObjectSet<Address>("Addresses")); }
        }
        private ObjectSet<Address> _addresses;
    
        public ObjectSet<Customer> Customers
        {
            get { return _customers  ?? (_customers = CreateObjectSet<Customer>("Customers")); }
        }
        private ObjectSet<Customer> _customers;
    
        public ObjectSet<CustomerAddress> CustomerAddresses
        {
            get { return _customerAddresses  ?? (_customerAddresses = CreateObjectSet<CustomerAddress>("CustomerAddresses")); }
        }
        private ObjectSet<CustomerAddress> _customerAddresses;
    
        public ObjectSet<Product> Products
        {
            get { return _products  ?? (_products = CreateObjectSet<Product>("Products")); }
        }
        private ObjectSet<Product> _products;
    
        public ObjectSet<ProductCategory> ProductCategories
        {
            get { return _productCategories  ?? (_productCategories = CreateObjectSet<ProductCategory>("ProductCategories")); }
        }
        private ObjectSet<ProductCategory> _productCategories;
    
        public ObjectSet<ProductDescription> ProductDescriptions
        {
            get { return _productDescriptions  ?? (_productDescriptions = CreateObjectSet<ProductDescription>("ProductDescriptions")); }
        }
        private ObjectSet<ProductDescription> _productDescriptions;
    
        public ObjectSet<ProductModel> ProductModels
        {
            get { return _productModels  ?? (_productModels = CreateObjectSet<ProductModel>("ProductModels")); }
        }
        private ObjectSet<ProductModel> _productModels;
    
        public ObjectSet<ProductModelProductDescription> ProductModelProductDescriptions
        {
            get { return _productModelProductDescriptions  ?? (_productModelProductDescriptions = CreateObjectSet<ProductModelProductDescription>("ProductModelProductDescriptions")); }
        }
        private ObjectSet<ProductModelProductDescription> _productModelProductDescriptions;
    
        public ObjectSet<SalesOrderDetail> SalesOrderDetails
        {
            get { return _salesOrderDetails  ?? (_salesOrderDetails = CreateObjectSet<SalesOrderDetail>("SalesOrderDetails")); }
        }
        private ObjectSet<SalesOrderDetail> _salesOrderDetails;
    
        public ObjectSet<SalesOrderHeader> SalesOrderHeaders
        {
            get { return _salesOrderHeaders  ?? (_salesOrderHeaders = CreateObjectSet<SalesOrderHeader>("SalesOrderHeaders")); }
        }
        private ObjectSet<SalesOrderHeader> _salesOrderHeaders;
    
        public ObjectSet<SalesOrderHeaderShipping> SalesOrderHeaderShippings
        {
            get { return _salesOrderHeaderShippings  ?? (_salesOrderHeaderShippings = CreateObjectSet<SalesOrderHeaderShipping>("SalesOrderHeaderShippings")); }
        }
        private ObjectSet<SalesOrderHeaderShipping> _salesOrderHeaderShippings;
    
        public ObjectSet<custview> custviews
        {
            get { return _custviews  ?? (_custviews = CreateObjectSet<custview>("custviews")); }
        }
        private ObjectSet<custview> _custviews;
    
        public ObjectSet<vGetAllCategory> vGetAllCategories
        {
            get { return _vGetAllCategories  ?? (_vGetAllCategories = CreateObjectSet<vGetAllCategory>("vGetAllCategories")); }
        }
        private ObjectSet<vGetAllCategory> _vGetAllCategories;
    
        public ObjectSet<vProductAndDescription> vProductAndDescriptions
        {
            get { return _vProductAndDescriptions  ?? (_vProductAndDescriptions = CreateObjectSet<vProductAndDescription>("vProductAndDescriptions")); }
        }
        private ObjectSet<vProductAndDescription> _vProductAndDescriptions;
    
        public ObjectSet<vProductModelCatalogDescription> vProductModelCatalogDescriptions
        {
            get { return _vProductModelCatalogDescriptions  ?? (_vProductModelCatalogDescriptions = CreateObjectSet<vProductModelCatalogDescription>("vProductModelCatalogDescriptions")); }
        }
        private ObjectSet<vProductModelCatalogDescription> _vProductModelCatalogDescriptions;

        #endregion
    }
}