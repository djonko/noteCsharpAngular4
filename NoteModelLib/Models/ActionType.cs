using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteModelLib.Models
{
    /// <summary>
    /// This class represent Type of an Action
    /// </summary>
    [Table("TypeAction")]
    public class ActionType
    {
        [Key]
        public Int32 IdType { get; set; }
        [MaxLength(50)]
        [Column("Libelle", TypeName = "nvarchar")]
        public string LibelleType { get; set; }


        // related to many Action
        /// <summary>
        /// Get all actions from this ActionType
        /// </summary>
        public virtual ICollection<ActionCompte> Actions { get; set; }
    }
}
