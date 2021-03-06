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
    [DataWindow("d_salesorder_select", DwStyle.Default)]
    public class D_Salesorder_Select
    {
        [DwChild("Customer_Customerid", "Full_Name", typeof(D_Dddw_Customer_Individual), AutoRetrieve = true)]
        [DwColumn("customer")]
        public double? Customer { get; set; }

        [DwColumn("date_from")]
        public DateTime? Date_From { get; set; }

        [DwColumn("date_to")]
        public DateTime? Date_To { get; set; }

    }

}