namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ChangeMovieReleaseDateToNullable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies" +
                " ALTER COLUMN ReleaseDate datetime NULL");
            Sql("ALTER TABLE Movies" +
                " ALTER COLUMN AddedDate datetime NULL");
        }

        public override void Down()
        {
        }
    }
}