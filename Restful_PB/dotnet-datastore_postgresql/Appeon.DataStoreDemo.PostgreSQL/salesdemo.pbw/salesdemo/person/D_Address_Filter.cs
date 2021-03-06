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
    [DataWindow("d_address_filter", DwStyle.Default)]
    public class D_Address_Filter
    {
        [DwColumn("city")]
        public string City { get; set; }

        [DwChild("Stateprovinceid", "Name", typeof(D_Dddw_Stateprovince), AutoRetrieve = true)]
        [DwColumn("StateProvinceID")]
        public double? Stateprovinceid { get; set; }

    }

}