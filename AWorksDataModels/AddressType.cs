using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDataModels
{
    public class AddressType : IBaseEntity<int>, IPersonType
    {
        private Guid _rowGuid;
        public int AddressTypeID { get; set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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

        public int GetKey(string encodedKey)
        {
            throw new NotImplementedException();
        }
    }
}
