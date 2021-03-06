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
    [DataWindow("d_dddw_store", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.Store\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("businessentityid A")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [Table("Store", Schema = "Sales")]
    public class D_Dddw_Store
    {
        [DwColumn("Sales.Store", "BusinessEntityID")]
        [Key]
        public int Businessentityid { get; set; }

        [DwColumn("Sales.Store", "Name")]
        [StringLength(50)]
        public string Name { get; set; }

    }

}