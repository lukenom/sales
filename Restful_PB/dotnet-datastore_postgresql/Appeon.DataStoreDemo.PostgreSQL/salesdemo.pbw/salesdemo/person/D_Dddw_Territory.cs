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
    [DataWindow("d_dddw_territory", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SalesTerritory\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("territoryid A")]
    public class D_Dddw_Territory
    {
        [DwColumn("Sales.SalesTerritory", "TerritoryID")]
        public int Territoryid { get; set; }

        [DwColumn("Sales.SalesTerritory", "Name")]
        [StringLength(50)]
        public string Name { get; set; }

    }

}