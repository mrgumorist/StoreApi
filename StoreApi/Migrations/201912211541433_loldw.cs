namespace StoreApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loldw : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Store_Id", c => c.Int());
            CreateIndex("dbo.People", "Store_Id");
            AddForeignKey("dbo.People", "Store_Id", "dbo.Stores", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Store_Id", "dbo.Stores");
            DropIndex("dbo.People", new[] { "Store_Id" });
            DropColumn("dbo.People", "Store_Id");
            DropTable("dbo.Stores");
        }
    }
}
