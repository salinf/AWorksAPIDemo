using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDataModels
{
    
    public class Address : IBaseEntity<int>
    {
        private Guid _rowGuid;

        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceID { get; set; }
        public string PostalCode { get; set; }
        //public Geometry SpatialLocation { get; set; }
        public Guid rowguid 
        {
            get 
            { 
                if (_rowGuid == Guid.Empty)
                {
                    _rowGuid = Guid.NewGuid();
                }
                return _rowGuid; 
            }
            set { _rowGuid = value; } 
        }
        public DateTime? ModifiedDate { get; set; }
        public int entityKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }      

        public int GetKey(string encodedKey)
        {
            int x = 0;
            int.TryParse(encodedKey, out x);
            return x;
        }
    }
}
