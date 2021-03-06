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
    [DataWindow("d_dddw_catesel", DwStyle.Default)]
    public class D_Dddw_Catesel
    {
        [DwChild("Productcategoryid", "Name", typeof(D_Dddw_Category), AutoRetrieve = true)]
        [DwColumn("id")]
        public double? Id { get; set; }

    }

}