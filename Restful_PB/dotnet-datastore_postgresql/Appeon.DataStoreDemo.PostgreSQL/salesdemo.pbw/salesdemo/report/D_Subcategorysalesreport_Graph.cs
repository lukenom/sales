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
    [DataWindow("d_subcategorysalesreport_graph", DwStyle.Graph)]
    public class D_Subcategorysalesreport_Graph
    {
        [DwColumn("name_1")]
        public double? Id { get; set; }

        [DwColumn("name")]
        public string Name { get; set; }

        [DwColumn("month")]
        public string Month { get; set; }

        [DwColumn("TotalSalesqty")]
        public double? Totalsalesqty { get; set; }

        [DwColumn("TotalSaleroom")]
        public decimal? Totalsaleroom { get; set; }

    }

}