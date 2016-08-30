using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.Core.DomainModels
{
    public abstract class EntityBaseExtended : EntityBase
    {
        public string Description { get; set; }
        public string Name { get; set; }
        
    }
}
