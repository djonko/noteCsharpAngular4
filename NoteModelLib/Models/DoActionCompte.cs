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
    public class DoActionCompte : Entity
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

        private DateTime? _createdDate;
        private DateTime? _updatedDate;
        

        public DateTime? CreatedDate
        {
            get
            {
                if (_createdDate.HasValue)
                {
                    return _createdDate.Value.ToLocalTime();
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    _createdDate = value.Value;
                }
                else
                {
                    _createdDate = null;
                }
            }
        }

        public DateTime? UpdatedDate
        {
            get
            {
                if (_updatedDate.HasValue)
                {
                    return _updatedDate.Value.ToLocalTime();
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    _updatedDate = value.Value;
                }
                else
                {
                    _updatedDate = null;
                }
            }
        }

        [Required]
        public double Amont { get; set; }

        //Foreign property 
        public virtual ActionCompte Action { get; set; }
        [ForeignKey("IdCompte")]
        public virtual Compte Compte { get; set; }

        public override void OnBeforeInsert()
        {
            CreatedDate = DateTime.UtcNow;
            base.OnBeforeInsert();
        }

        public override void OnBeforeUpdate()
        {
            UpdatedDate = DateTime.UtcNow;
            base.OnBeforeUpdate();
        }
    }
}
