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
    [DataWindow("d_order_detail_list", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Sales.SalesOrderDetail \r\n "
                  +"WHERE Sales.SalesOrderDetail.SalesOrderID = :al_order_id \r\n "
                  +"ORDER BY Sales.SalesOrderDetail.salesorderdetailid ASC")]
    #endregion
    [DwParameter("al_order_id", typeof(double?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("SalesOrderDetail", Schema = "Sales")]
    public class D_Order_Detail_List
    {
        [DwColumn("Sales.SalesOrderDetail", "salesorderid")]
        [Key]
        public int Salesorderid { get; set; } = 0;

        [Identity]
        [DwColumn("Sales.SalesOrderDetail", "salesorderdetailid")]
        [Key]
        public int Salesorderdetailid { get; set; } = 0;

        [DwColumn("Sales.SalesOrderDetail", "carriertrackingnumber")]
        [ConcurrencyCheck]
        public string Carriertrackingnumber { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "orderqty")]
        [ConcurrencyCheck]
        public short Orderqty { get; set; }

        [DwChild("Product_Productid", "Product_Name", typeof(D_Dddw_Order_Production), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderDetail", "productid")]
        [ConcurrencyCheck]
        public int Productid { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "specialofferid")]
        [ConcurrencyCheck]
        public int Specialofferid { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "unitprice")]
        [ConcurrencyCheck]
        public decimal Unitprice { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "unitpricediscount")]
        [ConcurrencyCheck]
        public decimal Unitpricediscount { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("Sales.SalesOrderDetail", "linetotal")]
        public decimal? Linetotal { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "modifieddate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; } = Convert.ToDateTime("1/1/1990 12:00:00 AM");

        [DwCompute("sum( linetotal )")]
        [JsonIgnore]
        [IgnoreDataMember]
        public object Compute_Sum { get; set; }

    }

}