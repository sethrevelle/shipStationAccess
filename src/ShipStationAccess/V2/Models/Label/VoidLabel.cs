using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShipStationAccess.V2.Models.Label
{
    [DataContract]
    public sealed class VoidLabel
    {
        [DataMember(IsRequired = true, Name = "shipmentId")]
        public int ShipmentId { get; set; }
    }
}
