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

namespace AWModel
{
    public partial class ProductModelProductDescription
    {
        #region Primitive Properties
    
        public virtual int ProductModelID
        {
            get { return _productModelID; }
            set
            {
                if (_productModelID != value)
                {
                    if (ProductModel != null && ProductModel.ProductModelID != value)
                    {
                        ProductModel = null;
                    }
                    _productModelID = value;
                }
            }
        }
        private int _productModelID;
    
        public virtual int ProductDescriptionID
        {
            get { return _productDescriptionID; }
            set
            {
                if (_productDescriptionID != value)
                {
                    if (ProductDescription != null && ProductDescription.ProductDescriptionID != value)
                    {
                        ProductDescription = null;
                    }
                    _productDescriptionID = value;
                }
            }
        }
        private int _productDescriptionID;
    
        public virtual string Culture
        {
            get;
            set;
        }
    
        public virtual System.Guid rowguid
        {
            get;
            set;
        }
    
        public virtual System.DateTime ModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ProductDescription ProductDescription
        {
            get { return _productDescription; }
            set
            {
                if (!ReferenceEquals(_productDescription, value))
                {
                    var previousValue = _productDescription;
                    _productDescription = value;
                    FixupProductDescription(previousValue);
                }
            }
        }
        private ProductDescription _productDescription;
    
        public virtual ProductModel ProductModel
        {
            get { return _productModel; }
            set
            {
                if (!ReferenceEquals(_productModel, value))
                {
                    var previousValue = _productModel;
                    _productModel = value;
                    FixupProductModel(previousValue);
                }
            }
        }
        private ProductModel _productModel;

        #endregion
        #region Association Fixup
    
        private void FixupProductDescription(ProductDescription previousValue)
        {
            if (previousValue != null && previousValue.ProductModelProductDescriptions.Contains(this))
            {
                previousValue.ProductModelProductDescriptions.Remove(this);
            }
    
            if (ProductDescription != null)
            {
                if (!ProductDescription.ProductModelProductDescriptions.Contains(this))
                {
                    ProductDescription.ProductModelProductDescriptions.Add(this);
                }
                if (ProductDescriptionID != ProductDescription.ProductDescriptionID)
                {
                    ProductDescriptionID = ProductDescription.ProductDescriptionID;
                }
            }
        }
    
        private void FixupProductModel(ProductModel previousValue)
        {
            if (previousValue != null && previousValue.ProductModelProductDescriptions.Contains(this))
            {
                previousValue.ProductModelProductDescriptions.Remove(this);
            }
    
            if (ProductModel != null)
            {
                if (!ProductModel.ProductModelProductDescriptions.Contains(this))
                {
                    ProductModel.ProductModelProductDescriptions.Add(this);
                }
                if (ProductModelID != ProductModel.ProductModelID)
                {
                    ProductModelID = ProductModel.ProductModelID;
                }
            }
        }

        #endregion
    }
}
