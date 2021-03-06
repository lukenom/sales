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
    [DataWindow("d_businessentityaddress", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Person.BusinessEntityAddress \r\n "
                  +"WHERE Person.BusinessEntityAddress.BusinessEntityID = :ai_id")]
    #endregion
    [DwParameter("ai_id", typeof(double?))]
    [DwSort("lookupdisplay(addressid  ) A")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("BusinessEntityAddress", Schema = "Person")]
    public class D_Businessentityaddress
    {
        [DwColumn("Person.BusinessEntityAddress", "businessentityid")]
        [Key]
        public int Businessentityid { get; set; } = 0;

        [DwChild("Addressid", "Addressline1", typeof(D_Dddw_Address), AutoRetrieve = true)]
        [DwColumn("Person.BusinessEntityAddress", "addressid")]
        [Key]
        public int Addressid { get; set; }

        [DwChild("Addresstypeid", "Name", typeof(D_Dddw_Addresstype), AutoRetrieve = true)]
        [DwColumn("Person.BusinessEntityAddress", "addresstypeid")]
        [Key]
        public int Addresstypeid { get; set; }

        [SqlDefaultValue("now()")]
        [DwColumn("Person.BusinessEntityAddress", "modifieddate", TypeName = "timestamp without time zone")]
        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; }

    }

}