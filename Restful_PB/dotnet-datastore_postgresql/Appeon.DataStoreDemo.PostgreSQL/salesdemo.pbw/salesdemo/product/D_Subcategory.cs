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
    [DataWindow("d_subcategory", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM production.productsubcategory \r\n "
                  +"WHERE (production.productsubcategory.productcategoryid = :ai_id or :ai_id = 0)")]
    #endregion
    [DwParameter("ai_id", typeof(double?))]
    [DwSort("productcategoryid A productsubcategoryid A")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [Table("productsubcategory", Schema = "production")]
    public class D_Subcategory
    {
        [Identity]
        [DwColumn("production.productsubcategory", "productsubcategoryid")]
        [Key]
        public int Productsubcategoryid { get; set; } = 0;

        [DwChild("Productcategoryid", "Name", typeof(D_Dddw_Category), AutoRetrieve = true)]
        [DwColumn("production.productsubcategory", "productcategoryid")]
        public int Productcategoryid { get; set; }

        [DwColumn("production.productsubcategory", "name")]
        [StringLength(50)]
        public string Name { get; set; }

        [SqlDefaultValue("now()")]
        [DwColumn("production.productsubcategory", "modifieddate", TypeName = "timestamp without time zone")]
        public DateTime Modifieddate { get; set; }

        [DwCompute("getrow()")]
        [JsonIgnore]
        [IgnoreDataMember]
        public object Compute_1 { get; set; }

    }

}