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
    [DataWindow("d_dddw_stateprovince", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.StateProvince\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("stateprovinceid A")]
    public class D_Dddw_Stateprovince
    {
        [DwColumn("Person.StateProvince", "StateProvinceID")]
        public int Stateprovinceid { get; set; }

        [DwColumn("Person.StateProvince", "Name")]
        [StringLength(50)]
        public string Name { get; set; }

    }

}