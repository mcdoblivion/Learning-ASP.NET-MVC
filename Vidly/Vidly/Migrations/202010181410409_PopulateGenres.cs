namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Social')");
            Sql("INSERT INTO Genres (Name) VALUES ('Science fiction')");
            Sql("INSERT INTO Genres (Name) VALUES ('Mystery')");
        }

        public override void Down()
        {
        }
    }
}