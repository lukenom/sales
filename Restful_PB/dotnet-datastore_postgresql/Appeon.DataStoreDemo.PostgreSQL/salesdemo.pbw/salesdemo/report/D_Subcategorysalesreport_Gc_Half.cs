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
    [DataWindow("d_subcategorysalesreport_gc_half", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("select @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"from Sales.SalesOrderDetail SalesOrderDetail \r\n "
                  +"inner join Sales.SalesOrderHeader SalesOrderHeader on SalesOrderDetail.SalesOrderID = SalesOrderHeader.SalesOrderID \r\n "
                  +"inner join Production.Product Product on SalesOrderDetail.ProductID = Product.ProductID \r\n "
                  +"inner join Production.ProductSubcategory ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID \r\n "
                  +"where SalesOrderHeader.Status in(1,2,5) and \r\n "
                  +"(ProductSubcategory.ProductcategoryID = :CategoryId) and \r\n "
                  +"(ExTRACT(month from  SalesOrderHeader.OrderDate) <=:monthto and ExTRACT(month from  SalesOrderHeader.OrderDate) >= :monthfrom) \r\n "
                  +"group by ProductSubcategory.Name, ExTRACT(month from  SalesOrderHeader.OrderDate) \r\n "
                  +"order by ProductSubcategory.Name, ExTRACT(month from  SalesOrderHeader.OrderDate)")]
    #endregion
    [DwParameter("CategoryId", typeof(double?))]
    [DwParameter("Monthfrom", typeof(double?))]
    [DwParameter("Monthto", typeof(double?))]
    public class D_Subcategorysalesreport_Gc_Half
    {
        [SqlCompute("ExTRACT(month from  SalesOrderHeader.OrderDate) as monthname")]
        public double Monthname { get; set; }

        [DwColumn("ProductSubcategory", "Name", "SubcategoryName")]
        public string Subcategoryname { get; set; }

        [SqlCompute("sum(SalesOrderDetail.orderqty) as TotalSalesqty")]
        public long Totalsalesqty { get; set; }

        [SqlCompute("sum(SalesOrderDetail.linetotal) as TotalSaleroom")]
        public decimal Totalsaleroom { get; set; }

    }

}