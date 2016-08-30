using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.Core.DomainModels
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public string Created { get; set; }
        public string Creator { get; set; }
        public string Last_editor { get; set; }
        public string Modified { get; set; }
    }
}
