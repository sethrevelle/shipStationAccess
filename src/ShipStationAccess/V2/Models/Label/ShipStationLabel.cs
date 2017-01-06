using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using ShipStationAccess.V2.Models.Order;

namespace ShipStationAccess.V2.Models.Label
{
    
    [DataContract]
    public sealed class ShipStationLabel
    {
        [DataMember(IsRequired =true, Name = "carrierCode")]
        public string CarrierCode { get; set; }

        [DataMember(IsRequired = true, Name = "serviceCode")]
        public string ServiceCode { get; set; }

        [DataMember(IsRequired = true, Name = "packageCode")]
        public string PackageCode { get; set; }

        [DataMember(Name = "confirmation")]
        public string Confirmation { get; set; }

        [DataMember(IsRequired = true, Name = "shipDate")]
        public DateTime ShipDate { get; set; }

        [DataMember(IsRequired = true, Name = "weight")]
        public ShipStationItemWeight Weight { set; get; }

        [DataMember(Name = "dimensions")]
        public ShipStationOrderDimensions Dimensions { get; set; }

        [DataMember(IsRequired = true, Name = "shipFrom")]
        public ShipStationAddress SenderShippingAddress { get; set; }

        [DataMember(IsRequired = true, Name = "shipTo")]
        public ShipStationAddress RecipientShippingAddress { get; set; }

        [DataMember(Name = "insuranceOptions")]
        public ShipStationOrderInsuranceOptions InsuranceOptions { get; set; }

        [DataMember(Name = "internationalOptions")]
        public ShipStationOrderInternationalOptions InternationalOptions { get; set; }

        [DataMember(Name = "advancedOptions")]
        public ShipStationOrderAdvancedOptions AdvancedOptions { get; set; }

        [DataMember(Name = "testLabel")]
        public bool TestLabel { get; set; }

        
    }
}
