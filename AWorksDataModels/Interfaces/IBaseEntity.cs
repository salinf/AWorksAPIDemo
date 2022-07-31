using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDataModels
{
    public interface IBaseEntity<out T>
    {        
        public DateTime? ModifiedDate { get; set; }
        public T GetKey(string encodedKey);        

    }
}
