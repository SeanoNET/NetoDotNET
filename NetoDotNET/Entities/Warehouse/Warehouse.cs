using NetoDotNET.Extensions;
using Newtonsoft.Json;

namespace NetoDotNET.Entities
{
    public class Warehouse
    {

        public int WarehouseID { get; set; }

        public string WarehouseNotes { get; set; }

        public string WarehousePhone { get; set; }

        public string WarehouseContact { get; set; }

        public string WarehouseCountry { get; set; }

        public string WarehousePostcode { get; set; }

        public string WarehouseState { get; set; }

        public string WarehouseCity { get; set; }

        public string WarehouseStreet2 { get; set; }

        public string WarehouseStreet1 { get; set; }

        public string WarehouseName { get; set; }

        public string WarehouseReference { get; set; }

        public string ShowQuantity { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsPrimary { get; set; }


    }
}