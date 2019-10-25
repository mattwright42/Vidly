namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatesMovieDetails : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre) VALUES ('The Fellowship of the Ring', '2001-12-19', '2019-10-24', 4, 'Fantasy')");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre) VALUES ('The Two Towers', '2002-12-18', '2019-10-24', 2, 'Fantasy')");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre) VALUES ('Return of the King', '2003-12-17', '2019-10-24', 5, 'Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
