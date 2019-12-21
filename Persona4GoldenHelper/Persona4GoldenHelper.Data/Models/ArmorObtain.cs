namespace Persona4GoldenHelper.Data.Models
{
    public class ArmorObtain
    {
        public string Obtain { get; private set; }
        public string Price { get; private set; }

        public ArmorObtain(string obtain, string price)
        {
            Obtain = obtain;
            Price = price;
        }
    }
}
