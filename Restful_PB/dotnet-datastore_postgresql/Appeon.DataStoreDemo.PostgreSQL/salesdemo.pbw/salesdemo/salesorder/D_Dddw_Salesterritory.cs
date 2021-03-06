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
    [DataWindow("d_dddw_salesterritory", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Sales.SalesTerritory, \r\n "
                  +"Person.CountryRegion \r\n "
                  +"WHERE ( Person.CountryRegion.countryregioncode = Sales.SalesTerritory.countryregioncode )")]
    #endregion
    public class D_Dddw_Salesterritory
    {
        [Identity]
        [DwColumn("Sales.SalesTerritory", "territoryid")]
        public int Salesterritory_Territoryid { get; set; }

        [DwColumn("Sales.SalesTerritory", "name")]
        [StringLength(50)]
        public string Salesterritory_Name { get; set; }

        [DwColumn("Sales.SalesTerritory", "countryregioncode")]
        [StringLength(3)]
        public string Salesterritory_Countryregioncode { get; set; }

        [DwColumn("Sales.SalesTerritory", "group", "salesterritory_group")]
        public string Salesterritory_Group { get; set; }

        [DwColumn("Person.CountryRegion", "name")]
        [StringLength(50)]
        public string Countryregion_Name { get; set; }

    }

}