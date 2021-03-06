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
    [DataWindow("d_dddw_address", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.Address\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("addressid A")]
    public class D_Dddw_Address
    {
        [DwColumn("Person.Address", "AddressID")]
        public int Addressid { get; set; }

        [DwColumn("Person.Address", "AddressLine1")]
        [StringLength(60)]
        public string Addressline1 { get; set; }

        [DwColumn("Person.Address", "City")]
        [StringLength(30)]
        public string City { get; set; }

        [DwChild("Stateprovinceid", "Name", typeof(D_Dddw_Stateprovince))]
        [DwColumn("Person.Address", "StateProvinceID")]
        public int Stateprovinceid { get; set; }

    }

}