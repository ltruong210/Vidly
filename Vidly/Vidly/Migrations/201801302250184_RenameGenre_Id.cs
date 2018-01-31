namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameGenre_Id : DbMigration
    {
        public override void Up()
        {
            Sql("sp_rename 'movies.genre_id', 'GenreID', 'COLUMN';");
        }
        
        public override void Down()
        {
        }
    }
}
