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
    [DataWindow("d_dddw_currency_rate", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Sales.CurrencyRate \r\n "
                  +"WHERE ( Sales.CurrencyRate.CurrencyRateDate = (select max(CurrencyRateDate) from Sales.CurrencyRate ) )  ORDER BY Sales.CurrencyRate.ToCurrencyCode          ASC")]
    #endregion
    public class D_Dddw_Currency_Rate
    {
        [Identity]
        [DwColumn("Sales.CurrencyRate", "CurrencyRateID")]
        public int Currencyrateid { get; set; }

        [DwColumn("Sales.CurrencyRate", "CurrencyRateDate", TypeName = "timestamp")]
        public DateTime Currencyratedate { get; set; }

        [DwColumn("Sales.CurrencyRate", "FromCurrencyCode")]
        [StringLength(3)]
        public string Fromcurrencycode { get; set; }

        [DwColumn("Sales.CurrencyRate", "ToCurrencyCode")]
        [StringLength(3)]
        public string Tocurrencycode { get; set; }

        [DwColumn("Sales.CurrencyRate", "AverageRate")]
        public decimal Averagerate { get; set; }

        [DwColumn("Sales.CurrencyRate", "EndOfDayRate")]
        public decimal Endofdayrate { get; set; }

    }

}