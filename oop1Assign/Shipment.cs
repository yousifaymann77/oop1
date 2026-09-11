using System;
using System.Collections.Generic;
using System.Text;

namespace oop1Assign
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private double deliveryFee;

        public string Destination { get; set; }
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
              if(!string.IsNullOrEmpty(value))
              {
                  trackingCode = value;
              }
            }

        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return weight;

            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public double DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if(value > 0)
                {
                    deliveryFee = value;
                }
            }
        }
        public double EstimatedCost {
            get
            {
                return deliveryFee + (weight * 5);
            }

        }
    }
}
