using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteModelLib.Models
{
    /// <summary>
    /// Class for account
    /// </summary>
    public class Compte
    {
        public int IdCompte { get; set; }

        public double CurrentAmont { get; set; }

        public DateTime? birthDay { get; set; }


        // foreign property 
        public ICollection<DoActionCompte> AllDoActions { get; set; }



    }
}
