using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL

{
    public abstract class EntityBase
    {
        public enum EntityStateOption { Active, Deleted }
        public bool isNew { get; private set; }
        public bool hasChanges { get; set; }
        public bool isValid => Validate(); // expression body property
        public EntityStateOption Entitystate { get; set; }

        public abstract bool Validate();

    }
}
