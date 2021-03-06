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
    [DataWindow("d_setup", DwStyle.Default)]
    [DwData(typeof(D_Setup_Data))]
    public class D_Setup
    {
        [DwColumn("hosttype")]
        public string Hosttype { get; set; }

        [DwColumn("modeltype")]
        public string Modeltype { get; set; }

        [DwColumn("url")]
        public string Url { get; set; }

    }

    #region D_Setup_Data
    public class D_Setup_Data : DwDataInitializer<D_Setup>
    {
        public override IList<D_Setup> GetDefaultData()
        {
            var list = new List<D_Setup>();
			 
            list.Add(new D_Setup() {  });
				
            return list;
        }
    }
    #endregion
}