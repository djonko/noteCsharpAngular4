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
    public class Compte : Entity
    {
        [Key]
        public int IdCompte { get; set; }

        public double CurrentAmont { get; set; }

        private DateTime? _birthDay;
        public DateTime? BirthDay
        {
            get
            {
                if (_birthDay.HasValue)
                {
                    return _birthDay.Value.ToLocalTime();
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    _birthDay = value.Value;
                }
                else
                {
                    _birthDay = null;
                }
            }
        }


        // foreign property 
        public virtual ICollection<DoActionCompte> AllDoActions { get; set; }

        public override void OnBeforeInsert()
        {
            CurrentAmont = 0;
            BirthDay = DateTime.UtcNow;
            base.OnBeforeInsert();
        }

        public override void OnBeforeUpdate()
        {

            base.OnBeforeUpdate();
        }

    }
}
