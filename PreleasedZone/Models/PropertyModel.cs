using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreleasedZone.Models
{
    public class PropertyModel
    {
        public int PropertyModelId { get; set; }
        public string Description { get; set; }
        public int SalePrice { get; set; }
        
        //ToDo: Check how to make this search friendly
        //Society/address?
        public string Location { get; set; }
        
        //ToDo: Or make this enum called type - 1BHK, etc.
        public int NumBedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int CarpetArea { get; set; }
        public int FloorNumber { get; set; }
        public int TotalFloors { get; set; }
        public DateTime Posession { get; set; } //Or immediate
        public int PropertyAge { get; set; }

        //List Images
        //public Boolean interested - per session(cookies)
    }
}