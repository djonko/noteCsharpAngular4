using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteModelLib.Models
{
    /// <summary>
    /// Class for account
    /// </summary>
    [Table("Account")]
    public class Compte
    {
        [Key]
        public int IdCompte { get; set; }
        
        public double CurrentAmont { get; set; }
        
        public DateTime? birthDay { get; set; }


        // foreign property 
        public virtual ICollection<DoActionCompte> AllDoActions { get; set; }



    }
}
