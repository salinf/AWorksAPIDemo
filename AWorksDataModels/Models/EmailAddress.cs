using System;

using AWorksDataModels.ClassExtensions;

namespace AWorksDataModels
{

    public class EmailAddress : IBaseEntity<int>, IHaveGuid
    {
        private Guid _rowGuid;
        public EmailAddress()
        {
            KeyType = typeof(int);
        }
        public int BusinessEntityId { get; set; }
        public int EmailAddressId { get; set; }
        public string EmailAddress1 { get; set; }
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
        public Type KeyType { get; init; }
        public int GetKey(string encodedKey)
        {
            int x = 0;
            int.TryParse(encodedKey.DecodeBase64(), out x);
            return x;
        }
    }
}
