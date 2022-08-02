using System;
using AWorksDataModels.ClassExtensions;

namespace AWorksDataModels
{
    public class CountryRegion : IBaseEntity<int>
    {
        public CountryRegion()
        {
            KeyType = typeof(int);
        }
        public int CountryRegionCode { get; set; }
        public string Name { get; set; }                
        public DateTime? ModifiedDate { get; set; }
        public Type KeyType { get; init; }

        public int GetKey(string encodedKey)
        {
            int x = 0;
            int.TryParse(encodedKey.DecodeBase64(), out x);
            return x;
        }
    }
}
