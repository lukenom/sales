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
    [DataWindow("d_businessentity", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.BusinessEntity\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [Table("BusinessEntity", Schema = "Person")]
    public class D_Businessentity
    {
        [Identity]
        [DwColumn("Person.BusinessEntity", "BusinessEntityID")]
        [Key]
        public int Businessentityid { get; set; }

        [SqlDefaultValue("uuid_generate_v4()")]
        [DwColumn("Person.BusinessEntity", "rowguid")]
        public Guid Rowguid { get; set; }

        [SqlDefaultValue("now()")]
        [DwColumn("Person.BusinessEntity", "ModifiedDate", TypeName = "timestamp without time zone")]
        public DateTime Modifieddate { get; set; }

    }

}