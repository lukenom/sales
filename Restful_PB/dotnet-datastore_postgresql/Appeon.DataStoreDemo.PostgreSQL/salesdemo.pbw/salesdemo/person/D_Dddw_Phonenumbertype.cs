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
    [DataWindow("d_dddw_phonenumbertype", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.PhoneNumberType\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("phonenumbertypeid A")]
    public class D_Dddw_Phonenumbertype
    {
        [DwColumn("Person.PhoneNumberType", "PhoneNumberTypeID")]
        public int Phonenumbertypeid { get; set; }

        [DwColumn("Person.PhoneNumberType", "Name")]
        [StringLength(50)]
        public string Name { get; set; }

    }

}