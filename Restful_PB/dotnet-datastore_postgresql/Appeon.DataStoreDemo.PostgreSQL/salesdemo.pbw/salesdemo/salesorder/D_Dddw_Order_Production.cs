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
    [DataWindow("d_dddw_order_production", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_)      FROM Production.Product ,           Production.ProductCategory ,           Production.ProductModel ,           Production.ProductSubcategory \r\n "
                  +"WHERE ( Production.ProductModel.ProductModelID = Production.Product.ProductModelID ) and \r\n "
                  +"( Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID ) and \r\n "
                  +"( Production.ProductSubcategory.ProductSubcategoryID = Production.Product.ProductSubcategoryID ) and          ( ( Production.Product.FinishedGoodsFlag = '1' ) and          ( Production.Product.ProductID in (  SELECT Sales.SpecialOfferProduct.ProductID      FROM Sales.SpecialOfferProduct   )) )                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ORDER BY Production.Product.ProductID          ASC")]
    #endregion
    [DwSort("product_productnumber A")]
    public class D_Dddw_Order_Production
    {
        [DwColumn("Production.Product", "Name")]
        [StringLength(50)]
        public string Product_Name { get; set; }

        [DwColumn("Production.Product", "ProductNumber")]
        [StringLength(25)]
        public string Product_Productnumber { get; set; }

        [DwColumn("Production.Product", "Color")]
        [StringLength(15)]
        public string Product_Color { get; set; }

        [DwColumn("Production.Product", "ListPrice")]
        public decimal Product_Listprice { get; set; }

        [DwColumn("Production.Product", "Size")]
        [StringLength(5)]
        public string Product_Size { get; set; }

        [DwColumn("Production.Product", "ProductSubcategoryID")]
        public int? Product_Productsubcategoryid { get; set; }

        [DwColumn("Production.Product", "ProductModelID")]
        public int? Product_Productmodelid { get; set; }

        [DwColumn("Production.ProductCategory", "Name")]
        [StringLength(50)]
        public string Productcategory_Name { get; set; }

        [DwColumn("Production.ProductSubcategory", "ProductCategoryID")]
        public int Productsubcategory_Productcategoryid { get; set; }

        [DwColumn("Production.ProductSubcategory", "Name")]
        [StringLength(50)]
        public string Productsubcategory_Name { get; set; }

        [DwColumn("Production.ProductModel", "Name")]
        [StringLength(50)]
        public string Productmodel_Name { get; set; }

        [DwColumn("Production.Product", "ProductID")]
        public int Product_Productid { get; set; }

    }

}