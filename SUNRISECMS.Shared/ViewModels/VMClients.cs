using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNRISECMS.Shared.ViewModels
{
    public class VMClients
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientFileNo { get; set; } = string.Empty;
        public required string Title { get; set; }
        public required string ForName { get; set; }
        public required string SurName { get; set; }
        public required string Initials { get; set; }
        public required string DisplayName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }
        public string Organisation { get; set; } = string.Empty;
        public string BuildingNo { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public required string City { get; set; }
        public required string Country { get; set; }
        public string PostalCode { get; set; } = string.Empty;
        [DataType(DataType.EmailAddress)]
        public required string EmailAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public required string PhoneNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string AlternateNo { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
