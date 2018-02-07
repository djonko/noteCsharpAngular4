using System.Collections.Generic;

namespace NoteModelLib.Models
{
    /// <summary>
    /// This class represent Type of an Action
    /// </summary>
    public class ActionType
    {

        public int IdType { get; set; }
        public string LibelleType { get; set; }


        // related to many Action
        /// <summary>
        /// Get all actions from this ActionType
        /// </summary>
        public ICollection<ActionCompte> Actions { get; set; }
    }
}
