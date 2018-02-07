using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteModelLib.Models
{
    public class ActionCompte
    {
        public int IdAction { get; set; }

        public string LibelleAction { get; set; }

        


        // relation one - by Many
        public int ActionTypeId { get; set; }
        public ActionType Type { get; set; }

        // relation between this and compte
        public ICollection<DoActionCompte> AllDoActions { get; set; }
    }
}
