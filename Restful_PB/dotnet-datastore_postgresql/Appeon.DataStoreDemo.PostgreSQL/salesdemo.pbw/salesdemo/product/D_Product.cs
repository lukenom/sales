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
    [DataWindow("d_product", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.product\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"production.product.productsubcategoryid\"   OP =\"=\"    EXP2 =\":al_subcate\" ) ) ARG(NAME = \"al_subcate\" TYPE = number)")]
    #endregion
    [DwParameter("al_subcate", typeof(double?))]
    [DwSort("productsubcategoryid A productid A")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [Table("product", Schema = "production")]
    public class D_Product
    {
        [Identity]
        [DwColumn("production.product", "productid")]
        [Key]
        public int Productid { get; set; }

        [DwColumn("production.product", "name")]
        [StringLength(50)]
        public string Name { get; set; }

        [DwColumn("production.product", "productnumber")]
        [StringLength(25)]
        public string Productnumber { get; set; }

        [DwColumn("production.product", "color")]
        [StringLength(15)]
        public string Color { get; set; }

        [DwColumn("production.product", "safetystocklevel")]
        public short Safetystocklevel { get; set; }

        [DwColumn("production.product", "reorderpoint")]
        public short Reorderpoint { get; set; }

        [DwColumn("production.product", "standardcost")]
        public decimal Standardcost { get; set; }

        [DwColumn("production.product", "listprice")]
        public decimal Listprice { get; set; }

        [DwColumn("production.product", "size")]
        [StringLength(5)]
        public string Size { get; set; }

        [DwColumn("production.product", "sizeunitmeasurecode")]
        [StringLength(3)]
        public string Sizeunitmeasurecode { get; set; }

        [DwColumn("production.product", "weightunitmeasurecode")]
        [StringLength(3)]
        public string Weightunitmeasurecode { get; set; }

        [DwColumn("production.product", "weight")]
        public decimal? Weight { get; set; }

        [DwColumn("production.product", "daystomanufacture")]
        public int Daystomanufacture { get; set; }

        [DwColumn("production.product", "productline")]
        [StringLength(2)]
        public string Productline { get; set; }

        [DwColumn("production.product", "class")]
        [StringLength(2)]
        public string Class { get; set; }

        [DwColumn("production.product", "style")]
        [StringLength(2)]
        public string Style { get; set; }

        [DwColumn("production.product", "productsubcategoryid")]
        public int? Productsubcategoryid { get; set; }

        [DwColumn("production.product", "productmodelid")]
        public int? Productmodelid { get; set; }

        [DwColumn("production.product", "sellstartdate", TypeName = "timestamp without time zone")]
        public DateTime Sellstartdate { get; set; }

        [DwColumn("production.product", "sellenddate", TypeName = "timestamp without time zone")]
        public DateTime? Sellenddate { get; set; }

        [SqlDefaultValue("now()")]
        [DwColumn("production.product", "modifieddate", TypeName = "timestamp without time zone")]
        public DateTime Modifieddate { get; set; }

        [SqlDefaultValue("True")]
        [DwColumn("production.product", "makeflag")]
        public bool Makeflag { get; set; }

        [SqlDefaultValue("True")]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("production.product", "finishedgoodsflag")]
        public bool Finishedgoodsflag { get; set; }

    }

}