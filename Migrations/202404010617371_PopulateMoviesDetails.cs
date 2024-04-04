namespace Nest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesDetails : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) values ('Titanic',4,'2000-03-02','2000-03-07',5)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) values ('Dictator',1,'2005-03-02','2005-03-07',2)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) values ('Family Man',3,'2004-03-02','2000-03-07',1)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) values ('Mission Impossible 2',2,'2003-03-02','2000-03-07',3)");
        }
        
        public override void Down()
        {
        }
    }
}
