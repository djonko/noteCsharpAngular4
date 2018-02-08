using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteModelLib.Models
{
    public abstract class Entity
    {
        public virtual void OnBeforeInsert() { }
        public virtual void OnBeforeUpdate() { }
    }
}
