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
    [DataWindow("d_dddw_unit", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.unitmeasure\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("unitmeasure", Schema = "production")]
    public class D_Dddw_Unit
    {
        [DwColumn("production.unitmeasure", "unitmeasurecode")]
        [Key]
        [StringLength(3)]
        public string Unitmeasurecode { get; set; }

        [DwColumn("production.unitmeasure", "name")]
        [ConcurrencyCheck]
        [StringLength(50)]
        public string Name { get; set; }

    }

}