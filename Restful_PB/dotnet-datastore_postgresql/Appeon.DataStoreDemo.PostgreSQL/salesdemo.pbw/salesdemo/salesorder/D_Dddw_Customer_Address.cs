using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    [DataWindow("d_dddw_customer_address", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Person.BusinessEntityAddress, \r\n "
                  +"Person.Address, \r\n "
                  +"Person.AddressType, \r\n "
                  +"Sales.Customer, \r\n "
                  +"Person.StateProvince \r\n "
                  +"WHERE ( Person.Address.addressid = Person.BusinessEntityAddress.addressid ) and \r\n "
                  +"( Person.AddressType.addresstypeid = Person.BusinessEntityAddress.addresstypeid ) and \r\n "
                  +"( Sales.Customer.territoryid = Person.StateProvince.territoryid ) and \r\n "
                  +"(Person.BusinessEntityAddress.BusinessEntityID = Sales.Customer.PersonID OR \r\n "
                  +"Person.BusinessEntityAddress.BusinessEntityID = Sales.Customer.StoreID) AND \r\n "
                  +"Person.Address.StateProvinceID = Person.StateProvince.StateProvinceID AND \r\n "
                  +"Sales.Customer.CustomerID = :al_customer_id")]
    #endregion
    [DwParameter("al_customer_id", typeof(double?))]
    public class D_Dddw_Customer_Address
    {
        [DwColumn("Person.BusinessEntityAddress", "businessentityid")]
        public int Businessentityaddress_Businessentityid { get; set; }

        [DwColumn("Person.BusinessEntityAddress", "addressid")]
        public int Businessentityaddress_Addressid { get; set; }

        [DwColumn("Person.BusinessEntityAddress", "addresstypeid")]
        public int Businessentityaddress_Addresstypeid { get; set; }

        [DwColumn("Person.Address", "addressline1")]
        [StringLength(60)]
        public string Address_Addressline1 { get; set; }

        [DwColumn("Person.Address", "addressline2")]
        [StringLength(60)]
        public string Address_Addressline2 { get; set; }

        [DwColumn("Person.Address", "city")]
        [StringLength(30)]
        public string Address_City { get; set; }

        [DwColumn("Person.Address", "stateprovinceid")]
        public int Address_Stateprovinceid { get; set; }

        [DwColumn("Person.Address", "postalcode")]
        [StringLength(15)]
        public string Address_Postalcode { get; set; }

        [DwColumn("Person.AddressType", "name")]
        [StringLength(50)]
        public string Addresstype_Name { get; set; }

        [DwColumn("Sales.Customer", "customerid")]
        public int Customer_Customerid { get; set; }

        [DwColumn("Person.StateProvince", "stateprovincecode")]
        public string Stateprovince_Stateprovincecode { get; set; }

        [DwColumn("Person.StateProvince", "countryregioncode")]
        public string Stateprovince_Countryregioncode { get; set; }

        [DwColumn("Person.StateProvince", "name")]
        public string Stateprovince_Name { get; set; }

    }

}