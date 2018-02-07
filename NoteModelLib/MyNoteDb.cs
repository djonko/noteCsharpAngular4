namespace NoteModelLib
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyNoteDb : DbContext
    {
        // Your context has been configured to use a 'MyNoteDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'NoteModelLib.MyNoteDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyNoteDb' 
        // connection string in the application configuration file.
        public MyNoteDb()
            : base("name=myNoteDb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Compte> Comptes { get; set; }

        public virtual DbSet<ActionCompte> ActionComptes {get; set;}

        public virtual DbSet<DoActionCompte> DoActionCompte { get; set; }

        public virtual DbSet<ActionType> ActionTypes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}