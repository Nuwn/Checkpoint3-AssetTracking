using System;

namespace Checkpoint3_AssetTracking.App
{
    public static class Office
    {
        public enum OfficeType { Oslo, London, Tokyo }

        readonly static Dictionary<OfficeType, string> keyValuePairs = new()
        {
            { OfficeType.Oslo, "NOK" },
            { OfficeType.London, "GBP" },
            { OfficeType.Tokyo, "JPY" }
        };

        public static string? GetCurrency(OfficeType office)
        {
            if(!keyValuePairs.TryGetValue(office, out string? value))
            {
                Console.WriteLine("Unable to retrieve currency.");
                return null;
            }
            return value;
        }

        public static OfficeType[] GetAllOffices => keyValuePairs.Keys.ToArray();

        public static string[] GetNames => System.Enum.GetNames(typeof(OfficeType));
    }
        
}