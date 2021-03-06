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
    [DataWindow("d_personphone", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.PersonPhone\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"Person.PersonPhone.BusinessEntityID\"   OP =\"=\"    EXP2 =\":ai_id\" ) ) ARG(NAME = \"ai_id\" TYPE = number)")]
    #endregion
    [DwParameter("ai_id", typeof(double?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [Table("PersonPhone", Schema = "Person")]
    public class D_Personphone
    {
        [DwColumn("Person.PersonPhone", "BusinessEntityID")]
        [Key]
        public int Businessentityid { get; set; } = 0;

        [DwColumn("Person.PersonPhone", "PhoneNumber")]
        [Key]
        [StringLength(25)]
        public string Phonenumber { get; set; }

        [DwChild("Phonenumbertypeid", "Name", typeof(D_Dddw_Phonenumbertype), AutoRetrieve = true)]
        [DwColumn("Person.PersonPhone", "PhoneNumberTypeID")]
        [Key]
        public int Phonenumbertypeid { get; set; }

        [SqlDefaultValue("now()")]
        [DwColumn("Person.PersonPhone", "ModifiedDate", TypeName = "timestamp without time zone")]
        public DateTime Modifieddate { get; set; }

    }

}