using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDataModels
{
    public class AddressType : IBaseEntity<int>, IPersonType
    {
        public int AddressTypeID { get; set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid rowguid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetKey(string encodedKey)
        {
            throw new NotImplementedException();
        }
    }
}
