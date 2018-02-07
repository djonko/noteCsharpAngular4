using NoteModelLib;
using NoteModelLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyNote
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (var ctx = new MyNoteDbContext())
            {
                ActionType t = new ActionType() { LibelleType = "PaiementFacture" };
                ctx.ActionTypes.Add(t);
                ctx.SaveChanges();
            }
        }
    }
}
