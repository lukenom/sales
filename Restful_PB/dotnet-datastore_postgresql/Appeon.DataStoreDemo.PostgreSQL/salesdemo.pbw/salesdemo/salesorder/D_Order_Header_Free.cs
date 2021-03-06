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
    [DataWindow("d_order_header_free", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Sales.SalesOrderHeader \r\n "
                  +"WHERE Sales.SalesOrderHeader.SalesOrderID = :al_order_id")]
    #endregion
    [DwParameter("al_order_id", typeof(double?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [Table("SalesOrderHeader", Schema = "Sales")]
    public class D_Order_Header_Free
    {
        [Identity]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("Sales.SalesOrderHeader", "salesorderid")]
        [Key]
        public int Salesorderid { get; set; } = 0;

        [DwColumn("Sales.SalesOrderHeader", "revisionnumber")]
        public short Revisionnumber { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "orderdate", TypeName = "timestamp")]
        [Required]
        public DateTime Orderdate { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "duedate", TypeName = "timestamp")]
        public DateTime Duedate { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "shipdate", TypeName = "timestamp")]
        public DateTime? Shipdate { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "status")]
        public short Status { get; set; } = 1;

        [DwColumn("Sales.SalesOrderHeader", "onlineorderflag")]
        public bool Onlineorderflag { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("Sales.SalesOrderHeader", "salesordernumber")]
        public string Salesordernumber { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "purchaseordernumber")]
        [StringLength(25)]
        public string Purchaseordernumber { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "accountnumber")]
        [StringLength(15)]
        public string Accountnumber { get; set; }

        [DwChild("Customer_Customerid", "Full_Name", typeof(D_Dddw_Customer_Individual), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderHeader", "customerid")]
        public int Customerid { get; set; }

        [DwChild("Salesperson_Businessentityid", "Full_Name", typeof(D_Dddw_Salesperson), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderHeader", "salespersonid")]
        public int? Salespersonid { get; set; }

        [DwChild("Salesterritory_Territoryid", "Salesterritory_Name", typeof(D_Dddw_Salesterritory), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderHeader", "territoryid")]
        public int? Territoryid { get; set; }

        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        [DwColumn("Sales.SalesOrderHeader", "billtoaddressid")]
        public int Billtoaddressid { get; set; }

        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        [DwColumn("Sales.SalesOrderHeader", "shiptoaddressid")]
        public int Shiptoaddressid { get; set; }

        [DwChild("Shipmethodid", "Name", typeof(D_Dddw_Shipmethod), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderHeader", "shipmethodid")]
        public int Shipmethodid { get; set; }

        [DwChild("Creditcard_Creditcardid", "Creditcard_Cardnumber", typeof(D_Dddw_Customer_Creditcard))]
        [DwColumn("Sales.SalesOrderHeader", "creditcardid")]
        public int? Creditcardid { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "creditcardapprovalcode")]
        [StringLength(15)]
        public string Creditcardapprovalcode { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "currencyrateid")]
        public int? Currencyrateid { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "subtotal")]
        public decimal Subtotal { get; set; } = 0m;

        [DwColumn("Sales.SalesOrderHeader", "taxamt")]
        public decimal Taxamt { get; set; } = 0m;

        [DwColumn("Sales.SalesOrderHeader", "freight")]
        public decimal Freight { get; set; } = 0m;

        [PropertySave(SaveStrategy.ReadAfterSave)]
        [DwColumn("Sales.SalesOrderHeader", "totaldue")]
        public decimal Totaldue { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "comment")]
        [StringLength(128)]
        public string Comment { get; set; }

        [DwColumn("Sales.SalesOrderHeader", "modifieddate", TypeName = "timestamp")]
        public DateTime Modifieddate { get; set; }

    }

}