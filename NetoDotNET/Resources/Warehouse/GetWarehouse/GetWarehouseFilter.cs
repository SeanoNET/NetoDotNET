using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Warehouses
{
    public class GetWarehouseFilter : NetoGetResourceFilter
    {


        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetWarehouse request. These will determine the results returned.
        /// </summary>
        public GetWarehouseFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetWarehouse request. These will determine the results returned.
        /// </summary>
        public GetWarehouseFilter(int[] warehouseID) : base()
        {
            this.WarehouseID = warehouseID;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetWarehouse request. These will determine the results returned.
        /// </summary>
        public GetWarehouseFilter(int warehouseID)
            : this(new int[] { warehouseID })
        {
        }

        public int[] WarehouseID { get; set; }

        public string[] WarehouseReference { get; set; }

        public string[] WarehouseName { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }

        private GetWarehouseFilterOutputSelector[] _outputSelector;
        public GetWarehouseFilterOutputSelector[] OutputSelector
        {
            get
            {
                return this._outputSelector ?? InitEmptyOutputSelector();
            }
            set
            {
                this._outputSelector = value;
            }
        }
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetWarehouseFilterOutputSelector
        {
            ID,
            WarehouseID,
            IsPrimary,
            IsActive,
            ShowQuantity,
            WarehouseReference,
            WarehouseName,
            WarehouseStreet1,
            WarehouseStreet2,
            WarehouseCity,
            WarehouseState,
            WarehousePostcode,
            WarehouseCountry,
            WarehouseContact,
            WarehousePhone,
            WarehouseNotes,
        }

        private GetWarehouseFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetWarehouseFilterOutputSelector>();

            foreach (GetWarehouseFilterOutputSelector item in (GetWarehouseFilterOutputSelector[])System.Enum.GetValues(typeof(GetWarehouseFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }

        internal override bool isValid()
        {

            int requiredFilterCount = WarehouseID.NullSafeLength() +
                            WarehouseReference.NullSafeLength() +
                            WarehouseName.NullSafeLength();


            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetWarehouse request");

        }
    }
}