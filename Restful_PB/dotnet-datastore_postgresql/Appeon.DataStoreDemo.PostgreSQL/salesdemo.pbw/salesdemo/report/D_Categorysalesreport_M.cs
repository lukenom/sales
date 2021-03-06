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
    [DataWindow("d_categorysalesreport_m", DwStyle.Composite)]
    public class D_Categorysalesreport_M
    {
        [DwColumn("a")]
        public string A { get; set; }

        [DwReport(typeof(D_Categorysalesreport_Pie_Saleroom))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Categorysalesreport_Pie_Saleroom> Dw_Catereport_Pie { get; set; }

        [DwReport(typeof(D_Categorysalesreport))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Categorysalesreport> Dw_Reportlist { get; set; }

        [DwReport(typeof(D_Categorysalesreport_D))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Categorysalesreport_D> Dw_Catereport { get; set; }

        [DwReport(typeof(D_Categorysalesreport_Graph_Saleroom))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Categorysalesreport_Graph_Saleroom> Dw_Compare { get; set; }

        [DwReport(typeof(D_Categorysalesreport_Graph_Saleqty))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Categorysalesreport_Graph_Saleqty> Dw_Qty { get; set; }

    }

}