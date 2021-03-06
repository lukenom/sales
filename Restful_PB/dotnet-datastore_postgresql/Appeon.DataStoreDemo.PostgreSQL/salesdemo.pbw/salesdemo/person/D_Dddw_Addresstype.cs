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
    [DataWindow("d_dddw_addresstype", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.AddressType\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("addresstypeid A")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("AddressType", Schema = "Person")]
    public class D_Dddw_Addresstype
    {
        [Identity]
        [DwColumn("Person.AddressType", "AddressTypeID")]
        [Key]
        public int Addresstypeid { get; set; }

        [DwColumn("Person.AddressType", "Name")]
        [ConcurrencyCheck]
        [StringLength(50)]
        public string Name { get; set; }

    }

}