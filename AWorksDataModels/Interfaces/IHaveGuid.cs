using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDataModels
{
    public interface IHaveGuid
    {
        public Guid rowguid { get; set; }
    }
}
