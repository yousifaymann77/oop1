using System;
using System.Collections.Generic;
using System.Text;

namespace oop1Assign
{
    internal struct DeliveryAddress
    {
        public string City {  get; set; }
        public string Street { get; set; }

        public int BuildingNumber { get; set; }

        public DeliveryAddress(string add , string street , int buildingNum)
        {
            City = add;
            Street = street;
            BuildingNumber = buildingNum;
        }
        public string GetFullAddress()
        {
            return $"City :  {City} , Street : {Street} , BuildingNo : {BuildingNumber} ";

        }

    }
}
