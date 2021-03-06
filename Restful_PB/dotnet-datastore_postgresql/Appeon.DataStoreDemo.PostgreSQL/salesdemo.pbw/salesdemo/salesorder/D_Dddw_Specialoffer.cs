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
    [DataWindow("d_dddw_specialoffer", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SpecialOffer\" )  TABLE(NAME=\"Sales.SpecialOfferProduct\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"Sales.SpecialOfferProduct.SpecialOfferID\"    OP =\"=\"RIGHT=\"Sales.SpecialOffer.SpecialOfferID\" ))")]
    #endregion
    public class D_Dddw_Specialoffer
    {
        [DwColumn("Sales.SpecialOfferProduct", "SpecialOfferID")]
        public int Specialofferproduct_Specialofferid { get; set; }

        [DwColumn("Sales.SpecialOfferProduct", "ProductID")]
        public int Specialofferproduct_Productid { get; set; }

        [DwColumn("Sales.SpecialOffer", "Description")]
        [StringLength(255)]
        public string Specialoffer_Description { get; set; }

        [SqlDefaultValue("'0'::double precision")]
        [DwColumn("Sales.SpecialOffer", "DiscountPct")]
        public double Specialoffer_Discountpct { get; set; }

        [DwColumn("Sales.SpecialOffer", "Type")]
        [StringLength(50)]
        public string Specialoffer_Type { get; set; }

        [DwColumn("Sales.SpecialOffer", "Category")]
        [StringLength(50)]
        public string Specialoffer_Category { get; set; }

        [SqlDefaultValue("0")]
        [DwColumn("Sales.SpecialOffer", "MinQty")]
        public int Specialoffer_Minqty { get; set; }

        [DwColumn("Sales.SpecialOffer", "MaxQty")]
        public int? Specialoffer_Maxqty { get; set; }

    }

}