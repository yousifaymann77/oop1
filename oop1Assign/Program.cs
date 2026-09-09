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
        }
    }
}
