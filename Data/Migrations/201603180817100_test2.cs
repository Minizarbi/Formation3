namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RecipeDBs");
            AlterColumn("dbo.RecipeDBs", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.RecipeDBs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.RecipeDBs");
            AlterColumn("dbo.RecipeDBs", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.RecipeDBs", "Id");
        }
    }
}
