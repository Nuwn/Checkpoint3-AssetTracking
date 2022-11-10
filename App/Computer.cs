namespace Checkpoint3_AssetTracking.App
{
    public class Computer
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Computer()
        {
            Brand = String.Empty;
            Model = String.Empty;
        }

        public Computer(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }


        public virtual string GetCategory => GetType().Name;
    }
}
