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
    [DataWindow("d_person_list_compress", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Person.Person , \r\n "
                  +"Person.BusinessEntityAddress, \r\n "
                  +"Person.Address \r\n "
                  +"Where (Person.Person.persontype = :personType or :personType = 'ALL') \r\n "
                  +"And (Person.Person.businessentityid = Person.BusinessEntityAddress.businessentityid) \r\n "
                  +"And (Person.BusinessEntityAddress.AddressId = Person.Address.AddressId)")]
    #endregion
    [DwParameter("personType", typeof(string))]
    [DwSort("businessentityid A")]
    public class D_Person_List_Compress
    {
        [DwColumn("Person.Person", "businessentityid")]
        public int Businessentityid { get; set; }

        [DwChild("Persontype", "Typedesc", typeof(D_Dddw_Persontype), AutoRetrieve = true)]
        [DwColumn("Person.Person", "persontype")]
        public string Persontype { get; set; }

        [DwColumn("Person.Person", "namestyle")]
        public bool Namestyle { get; set; }

        [DwColumn("Person.Person", "title")]
        [StringLength(8)]
        public string Title { get; set; }

        [DwColumn("Person.Person", "firstname")]
        [StringLength(50)]
        public string Firstname { get; set; }

        [DwColumn("Person.Person", "middlename")]
        [StringLength(50)]
        public string Middlename { get; set; }

        [DwColumn("Person.Person", "lastname")]
        [StringLength(50)]
        public string Lastname { get; set; }

        [DwColumn("Person.Person", "suffix")]
        [StringLength(10)]
        public string Suffix { get; set; }

        [DwColumn("Person.Person", "emailpromotion")]
        public int Emailpromotion { get; set; }

        [DwColumn("Person.Person", "Demographics")]
        public string Demographics { get; set; }

        [DwColumn("Person.Person", "modifieddate", TypeName = "timestamp")]
        public DateTime Modifieddate { get; set; }

        [DwColumn("Person.Address", "AddressLine1")]
        public string Address_Addressline1 { get; set; }

        [DwColumn("Person.Address", "City")]
        public string Address_City { get; set; }

        [DwColumn("Person.Address", "rowguid")]
        public Guid Address_Rowguid { get; set; }

        [DwCompute("getrow()")]
        [JsonIgnore]
        [IgnoreDataMember]
        public object Compute_1 { get; set; }

    }

}