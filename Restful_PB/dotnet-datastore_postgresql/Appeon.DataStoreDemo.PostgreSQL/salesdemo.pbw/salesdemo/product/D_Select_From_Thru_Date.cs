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
    [DataWindow("d_select_from_thru_date", DwStyle.Default)]
    [DwData(typeof(D_Select_From_Thru_Date_Data))]
    public class D_Select_From_Thru_Date
    {
        [DwColumn("name_1")]
        public string Customer { get; set; }

        [DwColumn("from_date")]
        public DateTime? From_Date { get; set; }

        [DwColumn("to_date")]
        public DateTime? To_Date { get; set; }

    }

    #region D_Select_From_Thru_Date_Data
    public class D_Select_From_Thru_Date_Data : DwDataInitializer<D_Select_From_Thru_Date>
    {
        public override IList<D_Select_From_Thru_Date> GetDefaultData()
        {
            var list = new List<D_Select_From_Thru_Date>();
			 
            list.Add(new D_Select_From_Thru_Date() { From_Date = null, To_Date = null });
				
            return list;
        }
    }
    #endregion
}