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
    [DataWindow("d_dddw_customer_store", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Sales.Customer, \r\n "
                  +"Sales.Store, \r\n "
                  +"Sales.SalesTerritory \r\n "
                  +"WHERE ( Sales.Store.businessentityid = Sales.Customer.storeid ) and \r\n "
                  +"( Sales.SalesTerritory.territoryid = Sales.Customer.territoryid ) and \r\n "
                  +"( ( Sales.Customer.StoreID is not null ) ) \r\n "
                  +"ORDER BY Sales.Customer.customerid ASC")]
    #endregion
    public class D_Dddw_Customer_Store
    {
        [Identity]
        [DwColumn("Sales.Customer", "customerid")]
        public int Customer_Customerid { get; set; }

        [DwColumn("Sales.Customer", "storeid")]
        public int? Customer_Storeid { get; set; }

        [DwColumn("Sales.Customer", "territoryid")]
        public int? Customer_Territoryid { get; set; }

        [DwColumn("Sales.Customer", "accountnumber")]
        [StringLength(10)]
        public string Customer_Accountnumber { get; set; }

        [DwColumn("Sales.Store", "name")]
        [StringLength(50)]
        public string Store_Name { get; set; }

        [DwColumn("Sales.SalesTerritory", "name")]
        [StringLength(50)]
        public string Salesterritory_Name { get; set; }

        [DwColumn("Sales.SalesTerritory", "group", "salesterritory_group")]
        public string Salesterritory_Group { get; set; }

    }

}