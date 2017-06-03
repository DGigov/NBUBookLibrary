namespace NbuBookLibrary.IdentityMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userOccupationAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Ocupation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Ocupation");
        }
    }
}
