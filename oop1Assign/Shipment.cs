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


        public Shipment(string trackingCode)
        {
            this.TrackingCode = trackingCode;
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            this.Destination = "Undefined";

        }

        public Shipment(string trackingCode ,string description , double weight , double deliveryFee , string destination)
        {
            this.TrackingCode = trackingCode;
            this.Description = description;
            this.Weight = weight;
            this.DeliveryFee = deliveryFee;
            this.Destination = destination;
        }
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

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = (double)newFee;
            }
        }

        public string PrintShipment()
        {
            return $"Tracking Code: {trackingCode}, Description: {description}, Weight: {weight} kg, Delivery Fee: ${deliveryFee}, Destination: {Destination}, Estimated Cost: ${EstimatedCost}";
        }
    }
}
