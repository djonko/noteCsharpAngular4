using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteModelLib.Models
{
    [Table("ActionAccount")]
    public class ActionCompte
    {
        [Key]
        public Int32 IdAction { get; set; }
        [MaxLength(100)]
        [Column( "Libelle",TypeName = "nvarchar")]
        public string LibelleAction { get; set; }




        // relation one - by Many
        
        public Int32 IdType { get; set; }
        [ForeignKey("IdType")]
        public ActionType TypeAction { get; set; }

        // relation between this and compte
        public virtual ICollection<DoActionCompte> AllDoActions { get; set; }
    }
}
