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
    [DataWindow("d_categorysalesreport_d", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("select @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"from Sales.SalesOrderDetail SalesOrderDetail \r\n "
                  +"inner join Sales.SalesOrderHeader SalesOrderHeader on SalesOrderDetail.SalesOrderID = SalesOrderHeader.SalesOrderID \r\n "
                  +"inner join Production.Product Product on SalesOrderDetail.ProductID = Product.ProductID \r\n "
                  +"inner join Production.ProductSubcategory ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID \r\n "
                  +"inner join Production.ProductCategory ProductCategory on ProductSubcategory.ProductCategoryID = ProductCategory.ProductCategoryID \r\n "
                  +"where SalesOrderHeader.Status in(1,2,5) and (SalesOrderHeader.OrderDate between :fromDate and :toDate) \r\n "
                  +"group by ProductCategory.ProductCategoryID, ProductCategory.Name \r\n "
                  +"order by ProductCategory.ProductCategoryID")]
    #endregion
    [DwParameter("fromDate", typeof(DateTime?))]
    [DwParameter("toDate", typeof(DateTime?))]
    public class D_Categorysalesreport_D
    {
        [DwColumn("ProductCategory", "Name", "ProductCategoryName")]
        public string Productcategoryname { get; set; }

        [SqlCompute("sum(SalesOrderDetail.orderqty) as TotalSalesqty")]
        public long Totalsalesqty { get; set; }

        [SqlCompute("sum(SalesOrderDetail.linetotal) as TotalSaleroom")]
        public decimal Totalsaleroom { get; set; }

    }

}