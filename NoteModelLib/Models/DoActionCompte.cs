using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteModelLib.Models
{
    public class DoActionCompte
    {
        public int IdCompte { get; set; }
        public int IdAction { get; set; }

        public string DetailsAction { get; set; }


        public DateTime? createdDate { get; set; }
        public DateTime? updatedDate { get; set; }


        public double Amont { get; set; }

        //Foreign property 
        public ActionCompte Action { get; set; }
        public Compte Compte { get; set; }
    }
}
