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
    public partial class Customer
    {
        #region Primitive Properties
    
        public virtual int CustomerID
        {
            get;
            set;
        }
    
        public virtual string Title
        {
            get;
            set;
        }
    
        public virtual string FirstName
        {
            get;
            set;
        }
    
        public virtual string MiddleName
        {
            get;
            set;
        }
    
        public virtual string LastName
        {
            get;
            set;
        }
    
        public virtual string Suffix
        {
            get;
            set;
        }
    
        public virtual string Company
        {
            get;
            set;
        }
    
        public virtual string SalesPerson
        {
            get;
            set;
        }
    
        public virtual string EmailAddress
        {
            get;
            set;
        }
    
        public virtual string Phone
        {
            get;
            set;
        }
    
        public virtual System.DateTime ModifiedDate
        {
            get;
            set;
        }
    
        public virtual byte[] TimeStamp
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<CustomerAddress> CustomerAddresses
        {
            get
            {
                if (_customerAddresses == null)
                {
                    var newCollection = new FixupCollection<CustomerAddress>();
                    newCollection.CollectionChanged += FixupCustomerAddresses;
                    _customerAddresses = newCollection;
                }
                return _customerAddresses;
            }
            set
            {
                if (!ReferenceEquals(_customerAddresses, value))
                {
                    var previousValue = _customerAddresses as FixupCollection<CustomerAddress>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCustomerAddresses;
                    }
                    _customerAddresses = value;
                    var newValue = value as FixupCollection<CustomerAddress>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCustomerAddresses;
                    }
                }
            }
        }
        private ICollection<CustomerAddress> _customerAddresses;
    
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                if (_salesOrderHeaders == null)
                {
                    var newCollection = new FixupCollection<SalesOrderHeader>();
                    newCollection.CollectionChanged += FixupSalesOrderHeaders;
                    _salesOrderHeaders = newCollection;
                }
                return _salesOrderHeaders;
            }
            set
            {
                if (!ReferenceEquals(_salesOrderHeaders, value))
                {
                    var previousValue = _salesOrderHeaders as FixupCollection<SalesOrderHeader>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupSalesOrderHeaders;
                    }
                    _salesOrderHeaders = value;
                    var newValue = value as FixupCollection<SalesOrderHeader>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupSalesOrderHeaders;
                    }
                }
            }
        }
        private ICollection<SalesOrderHeader> _salesOrderHeaders;

        #endregion
        #region Association Fixup
    
        private void FixupCustomerAddresses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CustomerAddress item in e.NewItems)
                {
                    item.Customer = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CustomerAddress item in e.OldItems)
                {
                    if (ReferenceEquals(item.Customer, this))
                    {
                        item.Customer = null;
                    }
                }
            }
        }
    
        private void FixupSalesOrderHeaders(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (SalesOrderHeader item in e.NewItems)
                {
                    item.Customer = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SalesOrderHeader item in e.OldItems)
                {
                    if (ReferenceEquals(item.Customer, this))
                    {
                        item.Customer = null;
                    }
                }
            }
        }

        #endregion
    }
}