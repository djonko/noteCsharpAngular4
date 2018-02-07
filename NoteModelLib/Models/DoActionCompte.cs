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
    /// Do action on Account 
    /// </summary>
    [Table("DoAction")]
    public class DoActionCompte
    {
        
        [Key]
        [Column(Order =1)]
        public Int32 IdCompte { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Action")]
        public Int32 IdAction { get; set; }

        [Column("Details", TypeName ="nvarchar")]
        [MaxLength(300)]
        public string DetailsAction { get; set; }


        public DateTime? createdDate { get; set; }
        public DateTime? updatedDate { get; set; }

        [Required]
        public double Amont { get; set; }

        //Foreign property 
        public virtual ActionCompte Action { get; set; }
        [ForeignKey("IdCompte")]
        public virtual Compte Compte { get; set; }
    }
}
