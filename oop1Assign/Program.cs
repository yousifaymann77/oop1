namespace oop1Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1 a)	What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            // The modifiaction will be done in the copy only and the original one will not be modified because struct is value type 
            #endregion

            #region Q 1 b)What happens when a Customer variable is copied into another variable and one variable modifies the object
            // The two variables will have the same modification because class is refrene type 
            #endregion

            #region  Q 2 a) Identify at least three problems with this design from an encapsulation perspectiveMyRegion
            // All fields are public and can be accessed directly from any place in the project,
            // No validations so invalid values can be assigned,
            // No Bussiness rules 
            #endregion

            #region Q 2 b) How can private fields and public properties improve this design?MyRegion
            // Private fields and public properties improve encapsulation by hiding the internal data and controlling access to it
            // and Properties can also contain validation logic before assigning values
            #endregion


            // ------------- Part Two -------------
            #region Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that the original did not change.MyRegion
            DeliveryAddress address = new DeliveryAddress("cairo", "Abbas", 33);
            DeliveryAddress address2 = new DeliveryAddress();

            address2 = address;
            address2.City = "Shebin";
            address2.Street = "paris";
            Console.WriteLine(address.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());

            #endregion

            Console.Clear();
            Console.WriteLine("-------------------------------");

            #region part2 Q6 a)
            DeliveryCenter deliveryCenter = new DeliveryCenter(); 
            #endregion

            for(int i = 1; i <=3; i++)
            {
                #region Part 2 Q6 b. Read data for three shipments from the user.
                Console.WriteLine($"Enter details for shipment {i} ");
                string trackingCode;
                do
                {
                    Console.WriteLine("Enter tracking code: ");
                    trackingCode = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(trackingCode))
                    {
                        Console.WriteLine("Invalid tracking code. Please try again.");
                    }
                } while (string.IsNullOrWhiteSpace(trackingCode));

                string description;
                do
                {
                    Console.WriteLine("Enter the Description : ");
                    description = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(description))
                    {
                        Console.WriteLine("Invalid Description. Please try again.");
                    }
                }
                while (string.IsNullOrWhiteSpace(description));


                double weight;
                bool isparsed = false;
                do
                {
                    Console.Write("Enter weight : ");
                    isparsed = double.TryParse(Console.ReadLine(), out weight);

                    if (!isparsed || weight <= 0)
                    {
                        Console.WriteLine("Invalid weight. Please enter a positive number.");
                    }
                }
                while (!isparsed || weight <= 0);

                Console.Write("Enter The Destination : ");
                string destination = Console.ReadLine();

                double deliveryFee;
                bool isparsed1 = false;

                do
                {
                    Console.Write("Enter the DeliveryFee : ");
                    isparsed1 = double.TryParse(Console.ReadLine(), out deliveryFee);
                    if (!isparsed || deliveryFee <= 0)
                    {
                        Console.WriteLine("Invalid delivery fee , please Enter a Positive Number");
                    }
                } while (!isparsed || deliveryFee <= 0); 
                #endregion
            }

        }
    }
}
