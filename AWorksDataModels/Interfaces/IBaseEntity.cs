using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDataModels
{
    public interface IBaseEntity<out T> where T : new()
    {        
        public DateTime? ModifiedDate { get; set; }
        public Type KeyType { get; init; }
        public T GetKey(string encodedKey);        

    }
}
